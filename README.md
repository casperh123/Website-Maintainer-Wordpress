# EnhanceSiteUpdater
A web application from which you can update your Enhance websites in a safe and efficient way.

## Getting started

The project is shipped with a local SQLite database, and uses Asp.Net Individual authentication.

### Setup Project Tools

To contribute to this project, you should have your local tool manifest setup correctly. The project is dependent on EF Migrations

    dotnet new tool-manifest   
    dotnet tool install --local dotnet-ef

### Create and apply migrations

Make sure the database has the correct schema applied to it, you will need to create and update the project migrations.

    dotnet ef migrations add MigrationName -p src/EnhanceSiteUpdater.Service -s src/EnhanceSiteUpdater.Web
    dotnet ef database update -p src/EnhanceSiteUpdater.Service -s src/EnhanceSiteUpdater.Web