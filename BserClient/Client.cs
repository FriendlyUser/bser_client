using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;
using BserClient.Types;
namespace BserClient
{
    /// <summary>
    /// Black Survival Eternal Return (bser) Http Client
    /// Implements rate limiting and the v1 endpoints.
    /// \todo label this package as v1 (intend to support v2 as a hobby)
    /// </summary>
    /// <remark>
    /// Consider making validators in a different class
    /// </remark>
    public class BserHttpClient
    {
        public HttpClient Client { get; } = new HttpClient();
        private SemaphoreSlim Throttler { get; } = null;
        private int RateLimit = 1;
        private string Version = "v1";
        /// <param name="apikey">Bser apikey from developer api portal.</param>
        /// <param name="rateLimit">Rate limit for requests (should be 1 for personal apikey).</param>
        /// <param name="burstLimit">Burst limit for requests (should be 2 for personal apikey).</param>
        public BserHttpClient(string apiKey, string version = "v1", int rateLimit = 1, int burstLimit = 2)
        {
            /// \todo TODO figure out how to handle urls when v2 comes out
            Client.BaseAddress = new Uri("https://open-api.bser.io");
            // GitHub API versioning
            Client.DefaultRequestHeaders.Add("Accept", "application/json");
            Client.DefaultRequestHeaders.Add("x-api-key", apiKey);
            RateLimit = rateLimit;
            Version = version;
            Client.DefaultRequestHeaders.Add("User-Agent", "BserClient");
            // rateLimit is 1 requests per second
            // burstLimit is 2 requests per second
            Throttler = new SemaphoreSlim(rateLimit, burstLimit);
        }

        /// <summary>
        /// Fetch game data by metadata - calls /v1/data/{metaType}
        /// </summary>
        /// <param name="metaType">Meta Type, use 'hash' to find all types</param>
        public async Task<BserMetaData> GetData()
        {
            string metaType = "hash";
            await Throttler.WaitAsync();
            string endpoint = String.Format("/v1/data/{0}", metaType);
            BserMetaData bserData;
            try
            {
                var response = await Client.GetAsync(endpoint);

                // let's wait here for 1 second to honor the API's rate limit                         
                await Task.Delay(1000 / RateLimit);
                // add error handling
                // response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                bserData = JsonSerializer.Deserialize<BserMetaData>(responseBody);
                if (!response.IsSuccessStatusCode)
                {
                    PrintRespErrors(bserData);
                }
            }
            finally
            {
                // here we release the throttler immediately
                Throttler.Release();
            }
            return bserData;
        }

        /// <summary>
        /// Overloaded function that can get values for given metadata type
        /// Fetch game data by metadata - calls /v1/data/{metaType}
        /// </summary>
        /// <remark>
        /// Since arbitary json data is returned from the api, data is a List of dictionary of System.Text.Json.JsonElement
        // I believe for most purposes using `itemData.data[0]["code"].ToString()` should be adequate.
        /// </remark>
        public async Task<BserTypeData> GetData(string metaType)
        {
            await Throttler.WaitAsync();
            string endpoint = String.Format("/v1/data/{0}", metaType);
            BserTypeData bserData;
            try
            {
                var response = await Client.GetAsync(endpoint);

                // let's wait here for 1 second to honor the API's rate limit                         
                await Task.Delay(1000 / RateLimit);
                // add error handling
                // response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                bserData = JsonSerializer.Deserialize<BserTypeData>(responseBody);
                if (!response.IsSuccessStatusCode)
                {
                    PrintRespErrors(bserData);
                }
            }
            finally
            {
                // here we release the throttler immediately
                Throttler.Release();
            }
            return bserData;
        }

        /// <summary>
        /// Fetch game data by metadata - calls /v1/rank/top/{seasonId}/{matchingTeamMode}
        /// </summary>
        public async Task<BserRankTop> GetRankTop(int seasonId = 0, int matchingTeamMode = 1)
        {
            await Throttler.WaitAsync();
            string endpoint = String.Format("/v1/rank/top/{0}/{1}", seasonId, matchingTeamMode);
            // range of game modes
            if (matchingTeamMode < 1 && matchingTeamMode > 3)
            {
                // matching team modes are 1, 2 and 3
                Console.WriteLine("matchingTeamMode should be within 1 and 3");
                return null;
            }
            if (seasonId < 0)
            {
                Console.WriteLine("seasonId should be greater than 0");
                return null;
            }
            BserRankTop bserRankTop;
            try
            {
                var response = await Client.GetAsync(endpoint);

                // let's wait here for 1 second to honor the API's rate limit                         
                await Task.Delay(1000 / RateLimit);
                // add error handling
                // response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                bserRankTop = JsonSerializer.Deserialize<BserRankTop>(responseBody);
                if (!response.IsSuccessStatusCode)
                {
                    PrintRespErrors(bserRankTop);
                }
            }
            finally
            {
                // here we release the throttler immediately
                Throttler.Release();
            }
            return bserRankTop;
        }

        /// <summary>
        /// Fetch game data by metadata - calls /v1/rank/{userNum}/{seasonId}{matchingTeamMode}
        /// </summary>
        public async Task<BserRankUser> GetRankUser(int userNum, int seasonId = 0, int matchingTeamMode = 1)
        {
            await Throttler.WaitAsync();
            // range of game modes
            if (matchingTeamMode < 1 && matchingTeamMode > 3)
            {
                // matching team modes are 1, 2 and 3
                Console.WriteLine("matchingTeamMode should be within 1 and 3");
                return null;
            }
            if (seasonId < 0)
            {
                Console.WriteLine("seasonId should be greater than 0");
                return null;
            }
            string endpoint = String.Format("/v1/rank/{0}/{1}/{2}", userNum, seasonId, matchingTeamMode);
            BserRankUser bserRankUser;
            try
            {
                var response = await Client.GetAsync(endpoint);

                // let's wait here for 1 second to honor the API's rate limit                         
                await Task.Delay(1000 / RateLimit);
                // add error handling
                // response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                bserRankUser = JsonSerializer.Deserialize<BserRankUser>(responseBody);
                if (!response.IsSuccessStatusCode)
                {
                    PrintRespErrors(bserRankUser);
                }
            }
            finally
            {
                // here we release the throttler immediately
                Throttler.Release();
            }
            return bserRankUser;
        }

        /// <summary>
        /// Fetch game data by metadata - calls /v1/user/games/{userNum}
        /// </summary>
        public async Task<BserUserGames> GetUserGames(int userNum, int next = 0)
        {
            await Throttler.WaitAsync();
            string endpoint;
            // range of game modes
            if (userNum < 0)
            {
                // matching team modes are 1, 2 and 3
                Console.WriteLine("userNum should be valid Number");
                return null;
            }
            if (next == 0)
            {
                endpoint = String.Format("/v1/user/games/{0}", userNum);
            }
            else
            {
                endpoint = String.Format("/v1/user/games/{0}?next={1}", userNum, next);
            }
            BserUserGames userGames;
            try
            {
                var response = await Client.GetAsync(endpoint);

                // let's wait here for 1 second to honor the API's rate limit                         
                await Task.Delay(1000 / RateLimit);
                // add error handling
                // response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                userGames = JsonSerializer.Deserialize<BserUserGames>(responseBody);
                if (!response.IsSuccessStatusCode)
                {
                    PrintRespErrors(userGames);
                }
            }
            finally
            {
                // here we release the throttler immediately
                Throttler.Release();
            }
            return userGames;
        }

        /// <summary>
        /// Fetch game data by metadata - calls /v1/user/games/{userNum}
        /// </summary>
        public async Task<BserUserStats> GetUserStats(int userNum, int seasonId = 1)
        {
            await Throttler.WaitAsync();
            // range of game modes
            if (userNum < 0)
            {
                // matching team modes are 1, 2 and 3
                Console.WriteLine("userNum should be valid String");
                return null;
            }
            string endpoint = String.Format("/v1/user/stats/{0}/{1}", userNum, seasonId);
            BserUserStats userStats;
            try
            {
                var response = await Client.GetAsync(endpoint);

                // let's wait here for 1 second to honor the API's rate limit                         
                await Task.Delay(1000 / RateLimit);
                // add error handling
                // response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                userStats = JsonSerializer.Deserialize<BserUserStats>(responseBody);
                if (!response.IsSuccessStatusCode)
                {
                    PrintRespErrors(userStats);
                }
            }
            finally
            {
                // here we release the throttler immediately
                Throttler.Release();
            }
            return userStats;
        }

                /// <summary>
        /// Fetch game data by metadata - calls /v1/rank/top/{seasonId}/{matchingTeamMode}
        /// </summary>
        public async Task<BserRankTop> GetUserNickname(string nickname)
        {
            await Throttler.WaitAsync();
            string endpoint = String.Format("/v1/user/nickname?query={0}", nickname);
            // range of game modes
            if (matchingTeamMode < 1 && matchingTeamMode > 3)
            {
                // matching team modes are 1, 2 and 3
                Console.WriteLine("matchingTeamMode should be within 1 and 3");
                return null;
            }
            if (seasonId < 0)
            {
                Console.WriteLine("seasonId should be greater than 0");
                return null;
            }
            BserRankTop bserRankTop;
            try
            {
                var response = await Client.GetAsync(endpoint);

                // let's wait here for 1 second to honor the API's rate limit                         
                await Task.Delay(1000 / RateLimit);
                // add error handling
                // response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                bserRankTop = JsonSerializer.Deserialize<BserRankTop>(responseBody);
                if (!response.IsSuccessStatusCode)
                {
                    PrintRespErrors(bserRankTop);
                }
            }
            finally
            {
                // here we release the throttler immediately
                Throttler.Release();
            }
            return bserRankTop;
        }

        /// <summary>
        /// Output code and message for erronous requests
        /// </summary>
        public static void PrintRespErrors(BserRespData bserData)
        {
            string message = String.Format("{0} - {1}", bserData.code, bserData.message);
            Console.WriteLine(message);
        }

        /// https://stackoverflow.com/questions/21316339/how-to-loop-through-a-dictionary-to-get-all-class-properties
        /// utility function to get all classes
    }
}
