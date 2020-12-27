using System;
using System.Net.Http;
using System.Threading;
namespace BserClient 
{
    /// <summary>
    /// Black Survival Eternal Return (bser) Http Client
    /// Implements rate limiting and the v1 endpoints
    /// </summary>
    public class BserHttpClient 
    {
        public HttpClient Client { get; } = new HttpClient();
        public SemaphoreSlim Throttler {get;} = null;
        
        /// <param name="apikey">Bser apikey from developer api portal.</param>
        /// <param name="rateLimit">Rate limit for requests (should be 1 for personal apikey).</param>
        /// <param name="burstLimit">Burst limit for requests (should be 2 for personal apikey).</param>
        public BserHttpClient(string apiKey, int rateLimit = 1, int burstLimit = 2) 
        {
            /// \todo TODO figure out how to handle urls when
            Client.BaseAddress = new Uri("https://open-api.bser.io");
            // GitHub API versioning
            Client.DefaultRequestHeaders.Add("Accept", "application/json");
            Client.DefaultRequestHeaders.Add("x-api-key", apiKey);
            
            // example left in case I need an user-agent
            // Client.DefaultRequestHeaders.Add("User-Agent",
            //     "HttpClientFactory-Sample");
            // rateLimit is 1 requests per second
            // burstLimit is 2 requests per second
            Throttler = new SemaphoreSlim(rateLimit, burstLimit);
        }
    }
}
