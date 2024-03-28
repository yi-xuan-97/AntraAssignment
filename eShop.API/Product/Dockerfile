FROM mcr.microsoft.com/dotnet/aspnet:8.0-bookworm-slim-amd64 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081
ENV eShopDb="Server=10.0.0.29,1433; Database=eShopApiDb; User=SA; Password=NewStrongPassword456; TrustServerCertificate=True;"
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Product/Product.csproj", "Product/"]
COPY ["Product.Infrastructure/Product.Infrastructure.csproj", "Product.Infrastructure/"]
COPY ["Product.ApplicationCore/Product.ApplicationCore.csproj", "Product.ApplicationCore/"]
RUN dotnet restore "Product/Product.csproj"
COPY . .
WORKDIR "/src/Product"
RUN dotnet build "Product.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Product.csproj" -c $BUILD_CONFIGURATION -o /app/publish -r linux-x64 --self -contained false /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Product.dll"]
