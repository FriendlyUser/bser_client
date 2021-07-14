using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using System.IO;
namespace BserClient.Cmd
{
    public class Program
    {
        public static async Task Main()
        {
            /// \todo https://open-api.bser.io/v1/data/ItemWeapon get all item weapon datas
            /// and list all types programatically
            string apiKey = Environment.GetEnvironmentVariable("BSER_APIKEY");
            // Set up (called once per test)
            var client = new BserHttpClient(apiKey);

            var gameMetaData = await client.GetData();
            Console.WriteLine(gameMetaData);
            var gameData = gameMetaData.data;
            Type type = gameData.GetType();
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                if (property.Name != "/") {
                    var dynamicDataToSave = await client.GetData(property.Name);
                    string file_name = "data/" + property.Name +".json";
                    string json = JsonSerializer.Serialize(dynamicDataToSave);

                    File.WriteAllText(file_name, json);
                }
            }
        }
    }
}
