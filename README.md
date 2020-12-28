[![codecov](https://codecov.io/gh/FriendlyUser/bser_client/branch/main/graph/badge.svg?token=EH0L58M6E3)](https://codecov.io/gh/FriendlyUser/bser_client)
# Eternal Return Black Survival

Simple wrapper around the eternal return black survival documentation.

Most of the documentation can be found at [https://friendlyuser.github.io/bser_client/classBserClient_1_1BserHttpClient.html](BserClient).

## Disclaimer 

Havent done too many C# projects.


```bash
dotnet new sln -n BserClient
dotnet new console -o BserClient.Cmd
dotnet new classlib -o BserClient.Http
dotnet new classlib -o BserClient.Tests
dotnet sln BserClient.sln add BserClient.Cmd/BserClient.Cmd.csproj
dotnet sln BserClient.sln add BserClient.Http/BserClient.Http.csproj
dotnet sln BserClient.sln add BserClient/BserClient.csproj --solution-folder .
dotnet sln BserClient.sln add BserClient.Tests/BserClient.Tests.csproj --solution-folder .
```

## References

* https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test
* https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-sln
* https://github.com/giraffe-fsharp/Giraffe (for .net build process)

## Donate

If you would like to motivate me to spend more time improving open source projects please consider donating.

[![Donate with Ethereum](https://en.cryptobadges.io/badge/big/0x9d18acAB9Fe749Cbf899B2FD63Bf25e64829bbF3)](https://en.cryptobadges.io/donate/0x9d18acAB9Fe749Cbf899B2FD63Bf25e64829bbF3)

[![Donate with Bitcoin](https://en.cryptobadges.io/badge/big/1BMWhjCrTE3Dn94oHnrk6XMZAS3hjq3vdD)](https://en.cryptobadges.io/donate/1BMWhjCrTE3Dn94oHnrk6XMZAS3hjq3vdD)

[![paypal](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=Z6M6Y83D3URSU&item_name=Motivating+me+to+continue+to+produce+open+source+projects&currency_code=CAD)