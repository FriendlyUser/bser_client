# Notes and Thoughts

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