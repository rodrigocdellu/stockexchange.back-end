FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_URLS=http://+:80

FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["StockExchange.WebAPI/StockExchange.WebAPI.csproj", "StockExchange.WebAPI/"]
RUN dotnet restore "StockExchange.WebAPI/StockExchange.WebAPI.csproj"
COPY . .
WORKDIR "/src/StockExchange.WebAPI"
RUN dotnet build "StockExchange.WebAPI.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "StockExchange.WebAPI.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StockExchange.WebAPI.dll"]
