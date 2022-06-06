from mcr.microsoft.com/dotnet/sdk:6.0 as build

workdir /app

copy /publish ./

entrypoint ["dotnet", "ModelApi.dll"]

expose 5000

env ASPNETCORE_URLS=http://+:5000