FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR / App

COPY ./ ./

RUN dotnet publish -c Release

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS RUN

WORKDIR / App

COPY --from=build /App/DockerDemo/bin/Release/net6.0/publish/ ./

ENTRYPOINT ["dotnet", "./DockerDemo.dll"]