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
            Assert.Equal(code, 200);
            Assert.Equal(message, "Success");
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
            Assert.Equal(code, 200);
            Assert.Equal(message, "Success");
            Assert.IsType<List<UserRankObj>>(bserData.topRanks);
        }

        [Fact]
        public async Task TestGetRankUser()
        {
            // Testing first place 189543
            var bserData = await client.GetRankUser("189543", 1, 1);
            // string responseBody = await response.Content.ReadAsStringAsync();
            _testOutputHelper.WriteLine(bserData.code.ToString());
            int code = bserData.code;
            string message = bserData.message;
            Assert.Equal(code, 200);
            Assert.Equal(message, "Success");
            Assert.IsType<UserRankObj>(bserData.userRank);
        }
    }
}
