# Use the official image as a parent image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
# Copying the published artifacts into the image
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "YourApp.dll"]
