FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 10811
EXPOSE 10812
COPY . .
ENTRYPOINT ["dotnet", "Hayaa.AppScanServiceSite.dll"]
