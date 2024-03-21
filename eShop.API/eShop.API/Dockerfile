FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["eShop.API/eShop.API.csproj", "eShop.API/"]
COPY ["eShop.Infrastructure/eShop.Infrastructure.csproj", "eShop.Infrastructure/"]
COPY ["eShop.ApplicationCore/eShop.ApplicationCore.csproj", "eShop.ApplicationCore/"]
RUN dotnet restore "eShop.API/eShop.API.csproj"
COPY . .
WORKDIR "/src/eShop.API"
RUN dotnet build "eShop.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "eShop.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "eShop.API.dll"]
