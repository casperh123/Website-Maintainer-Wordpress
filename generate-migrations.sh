rm -rf ./src/WebsiteMaintainer.Infrastructure/Migrations
rm -rf ./src/WebsiteMaintainer.Web/Data/app.db

sqlite3 /src/WebsiteMaintainer.Web/Data/app.db | .quit

dotnet ef migrations add MigrationName -p src/WebsiteMaintainer.Infrastructure -s src/WebsiteMaintainer.Web
dotnet ef database update -p src/WebsiteMaintainer.Infrastructure -s src/WebsiteMaintainer.Web