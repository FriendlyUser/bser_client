using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BserClient.Cmd
{
    public class Program
    {
        public static async Task Main()
        {
            string apiKey = Environment.GetEnvironmentVariable("BSER_APIKEY");
            // Set up (called once per test)
            var client = new BserHttpClient(apiKey);

            var tasks = new List<Task>();
            for (var i = 0; i < 12; i++)
            {
                tasks.Add(Task.Run(async () =>
                {
                    var result = await client.GetData();
                    Console.WriteLine(result.ToString());
                }));
            }
            await Task.WhenAll(tasks.ToArray());
        }
    }
}
