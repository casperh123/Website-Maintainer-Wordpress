FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/WebsiteMaintainer.Web/WebsiteMaintainer.Web.csproj", "src/WebsiteMaintainer.Web/"]
RUN dotnet restore "src/WebsiteMaintainer.Web/WebsiteMaintainer.Web.csproj"
COPY . .
WORKDIR "/src/src/WebsiteMaintainer.Web"
RUN dotnet build "WebsiteMaintainer.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "WebsiteMaintainer.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebsiteMaintainer.Web.dll"]
