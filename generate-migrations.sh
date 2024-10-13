rm -rf ./src/EnhanceSiteUpdater.Infrastructure/Migrations
rm -rf ./src/EnhanceSiteUpdater.Web/Data/app.db

sqlite3 /src/EnhanceSiteUpdater.Web/Data/app.db | .quit

dotnet ef migrations add MigrationName -p src/EnhanceSiteUpdater.Infrastructure -s src/EnhanceSiteUpdater.Web
dotnet ef database update -p src/EnhanceSiteUpdater.Infrastructure -s src/EnhanceSiteUpdater.Web