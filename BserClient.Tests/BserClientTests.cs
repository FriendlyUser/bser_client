using System;
using Xunit;
using Xunit.Abstractions;
using System.Threading.Tasks;
using BserClient.Types;
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
        public async Task Get()
        {
            _testOutputHelper.WriteLine("Hello");
            var bserData = await client.GetData();
            // string responseBody = await response.Content.ReadAsStringAsync();
            _testOutputHelper.WriteLine(bserData.code.ToString());
            int code = bserData.code;
            string message = bserData.message;
            Assert.Equal(code, 200);
            Assert.Equal(message, "Success");
            Assert.IsType<BserGameObj>(bserData.data);
        }
    }
}
