using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using BserClient.Types;

namespace BserClient
{
    /// <summary>
    /// Black Survival Eternal Return (bser) Http Client
    /// Implements rate limiting and the v1 endpoints
    /// </summary>
    public class BserHttpClient
    {
        public HttpClient Client { get; } = new HttpClient();
        private SemaphoreSlim Throttler { get; } = null;
        private int RateLimit = 1;

        /// <param name="apikey">Bser apikey from developer api portal.</param>
        /// <param name="rateLimit">Rate limit for requests (should be 1 for personal apikey).</param>
        /// <param name="burstLimit">Burst limit for requests (should be 2 for personal apikey).</param>
        public BserHttpClient(string apiKey, int rateLimit = 1, int burstLimit = 2)
        {
            /// \todo TODO figure out how to handle urls when v2 comes out
            Client.BaseAddress = new Uri("https://open-api.bser.io");
            // GitHub API versioning
            Client.DefaultRequestHeaders.Add("Accept", "application/json");
            Client.DefaultRequestHeaders.Add("x-api-key", apiKey);
            RateLimit = rateLimit;
            // example left in case I need an user-agent
            // Client.DefaultRequestHeaders.Add("User-Agent",
            //     "HttpClientFactory-Sample");
            // rateLimit is 1 requests per second
            // burstLimit is 2 requests per second
            Throttler = new SemaphoreSlim(rateLimit, burstLimit);
        }

        /// <summary>
        /// Fetch game data by metadata
        /// </summary>
        /// <param name="metaType">Meta Type, use 'hash' to find all types</param>
        public async Task<BserData> GetData(string metaType = "hash")
        {
            await Throttler.WaitAsync();
            string endpoint = String.Format("/v1/data/{0}", metaType);
            BserData bserData;
            try
            {
                var response = await Client.GetAsync(endpoint);

                // let's wait here for 1 second to honor the API's rate limit                         
                await Task.Delay(1000 / RateLimit);
                // add error handling
                // response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                bserData = JsonSerializer.Deserialize<BserData>(responseBody);
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

        public async Task<BserRankUser> GetRankUser(string userNum, int seasonId = 0, int matchingTeamMode = 1)
        {
            await Throttler.WaitAsync();
            string endpoint = String.Format("/v1/rank/{0}/{1}/{2}", userNum, seasonId, matchingTeamMode);
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
        /// Output code and message for erronous requests
        /// </summary>
        public static void PrintRespErrors(BserRespData bserData)
        {
            string message = String.Format("{0} - {1}", bserData.code, bserData.message);
            Console.WriteLine(message);
        }
    }
}
