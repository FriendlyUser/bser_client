#!/usr/bin/env dotnet-script
// dotnet tool install -g dotnet-script
#r "nuget: dotenv.net, 3.0.0"
#r "nuget: BserClient"

using System;
using System.Reflection;
using System.IO;
using BserClient;
using System.Collections.Generic;
using System.Text.Json;
using dotenv.net;
DotEnv.Load();
var envVars = DotEnv.Read();
// Set up (called once per test)
var API_KEY = envVars["BSER_API_KEY"];
Console.WriteLine(API_KEY);
var client = new BserClient.BserHttpClient(API_KEY);

// get data and then iterate across data

var gameMetaData = await client.GetData();

var gameData = gameMetaData.data;
Type type = gameData.GetType();
PropertyInfo[] properties = type.GetProperties();

foreach (PropertyInfo property in properties)
{
   if (property.Name != "/") {
       var dynamicDataToSave = await client.GetData(property.Name);
       System.IO.StreamWriter file = new System.IO.StreamWriter(property.Name +".json", false);
       while (true)
        {
            file.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
            file.WriteLine(dynamicDataToSave);
            file.Flush();
        }
   }
}