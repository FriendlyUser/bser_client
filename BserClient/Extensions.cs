
using System.Collections.Generic;
using System;
// keep logic until v2 or v1 has more functionality
namespace BserClient.Extensions
{
    // cant map json data from bser to standard C# primatives
    // public static class DictionaryExtensions
    // {
    //     public static object Get(this Dictionary<string, System.Text.Json.JsonElement> instance, string name)
    //     {
    //         // check if element is System.Text.Json.JsonElement
    //         // if (instance[name].GetType().Name == "System.Text.Json.JsonElement") 
    //         // {
    //         // }
    //         List<string> bserNumList = new List<string>{ "code", "sp", "time", "maskCode", "craftSetPoint"}; ; 
    //         if (bserNumList.Contains(name)) {
    //             return instance[name].ValueKind;
    //         }
    //         if (instance[name].GetType().Name == "System.Text.Json.JsonElement") {
    //             // try to destructure based on generic type
    //             string typeParameterType = typeof(T).ToString();
    //             Console.WriteLine(typeParameterType);
    //             Console.WriteLine(typeof(T).ToString());
    //             switch (typeParameterType)
    //             {
    //                 case "System.String":
    //                     return (T)instance[name].ToString();
                    
    //                 case "System.Int":
    //                     return (T)instance[name].GetInt64();
    //             }
    //         }
    //         return (T)instance[name];
    //     }

    // }
}