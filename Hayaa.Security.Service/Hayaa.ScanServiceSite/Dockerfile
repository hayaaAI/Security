FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 10821

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ${WORKSPACE}/Hayaa.ScanServiceSite/Hayaa.ScanServiceSite.csproj Hayaa.ScanServiceSite/
RUN dotnet restore Hayaa.ScanServiceSite/Hayaa.ScanServiceSite.csproj  -s http://nexus.xieqj.net/repository/nuget-group/ -s https://api.nuget.org/v3/index.json
COPY . .
WORKDIR /src/Hayaa.ScanServiceSite
RUN dotnet build Hayaa.ScanServiceSite.csproj -c Release -o /app  -r centos.7-x64

FROM build AS publish
RUN dotnet publish Hayaa.ScanServiceSite.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Hayaa.ScanServiceSite.dll"]
