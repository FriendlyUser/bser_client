[![codecov](https://codecov.io/gh/FriendlyUser/bser_client/branch/main/graph/badge.svg?token=EH0L58M6E3)](https://codecov.io/gh/FriendlyUser/bser_client)
[![Nuget](https://img.shields.io/nuget/v/BserClient?color=blue)](https://www.nuget.org/packages/BserClient/)
# Eternal Return Black Survival

Simple wrapper around the eternal return black survival documentation.

Most of the documentation can be found at 
[BserClient](https://friendlyuser.github.io/bser_client/classBserClient_1_1BserHttpClient.html).

## Disclaimer 

Havent done too many C# projects. Free feel to have any pr you believe can improve this project.

### Install

The initial version is 

```bash
dotnet add package BserClient --version 1.0.0
```

A simple project looks like

```csharp
using System;
using BserClient;
using System.Threading.Tasks;
namespace sample_bser_console_app
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string apiKey = Environment.GetEnvironmentVariable("BSER_APIKEY");
            BserHttpClient client = new BserHttpClient(apiKey, "v1);
            BserClient.Types.BserMetaData bserData = await client.GetData();
        }
    }
}
```


For interactive notebooks see https://github.com/FriendlyUser/black-survival-interactive

## References

* https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test
* https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-sln
* https://github.com/giraffe-fsharp/Giraffe (for .net build process)

## Donate

If you would like to motivate me to spend more time improving open source projects please consider donating.

[![Donate with Ethereum](https://en.cryptobadges.io/badge/big/0x9d18acAB9Fe749Cbf899B2FD63Bf25e64829bbF3)](https://en.cryptobadges.io/donate/0x9d18acAB9Fe749Cbf899B2FD63Bf25e64829bbF3)

[![Donate with Bitcoin](https://en.cryptobadges.io/badge/big/1BMWhjCrTE3Dn94oHnrk6XMZAS3hjq3vdD)](https://en.cryptobadges.io/donate/1BMWhjCrTE3Dn94oHnrk6XMZAS3hjq3vdD)

[![paypal](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=Z6M6Y83D3URSU&item_name=Motivating+me+to+continue+to+produce+open+source+projects&currency_code=CAD)
