using System;
using Xunit;
using Xunit.Abstractions;
using System.Threading.Tasks;
using BserClient.Types;
using System.Collections.Generic;
namespace BserClient.Tests
{
    // [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class BserTests : IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        // setup http client
        BserHttpClient client;
        // number 1 user should never get deleted.
        int userNum = 189543;
        public BserTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            string apiKey = Environment.GetEnvironmentVariable("BSER_APIKEY");
            // Set up (called once per test)
            client = new BserHttpClient(apiKey);
        }

        // no functionality right now
        public void Dispose()
        {
            // Tear down (called once per test)
        }

        [Fact]
        public async Task TestGetData()
        {
            var bserData = await client.GetData();
            string debugMessage = String.Format("{0} - {1}", bserData.code, bserData.message);
            _testOutputHelper.WriteLine(debugMessage);
            int code = bserData.code;
            string message = bserData.message;
            Assert.Equal(200, code);
            Assert.Equal("Success", message);
            Assert.IsType<GameDataObj>(bserData.data);
        }

        [Fact]
        public async Task TestGetRankTop()
        {
            var bserData = await client.GetRankTop(1, 1);
            // string responseBody = await response.Content.ReadAsStringAsync();
            string debugMessage = String.Format("{0} - {1}", bserData.code, bserData.message);
            _testOutputHelper.WriteLine(debugMessage);
            int code = bserData.code;
            string message = bserData.message;
            Assert.Equal(200, code);
            Assert.Equal("Success", message);
            Assert.IsType<List<UserRankObj>>(bserData.topRanks);
        }

        [Fact]
        public async Task TestGetRankUser()
        {
            // Testing first place 189543
            var bserData = await client.GetRankUser(userNum, 1, 1);
            string debugMessage = String.Format("{0} - {1}", bserData.code, bserData.message);
            _testOutputHelper.WriteLine(debugMessage);
            int code = bserData.code;
            string message = bserData.message;
            Assert.Equal(200, code);
            Assert.Equal("Success", message);
            Assert.IsType<UserRankObj>(bserData.userRank);
        }

        [Fact]
        public async Task TestGetUserGames()
        {
            // Testing first place 189543
            var data = await client.GetUserStats(userNum);
            // string responseBody = await response.Content.ReadAsStringAsync();
            string debugMessage = String.Format("{0} - {1}", data.code, data.message);
            _testOutputHelper.WriteLine(debugMessage);
            int code = data.code;
            string message = data.message;
            Assert.Equal(200, code);
            Assert.Equal("Success", message);
            Assert.IsType<List<UserStatsCharacterStatsObj>>(data.userStats);
        }
    }
}
