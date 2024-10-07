# EnhanceSiteUpdater
A web application from which you can update your Enhance websites in a safe and efficient way.

## Getting started

To get started with the project, you should first create a new SQLite database in the services directory.

Run the following command to create a new SQLite datbase:

### Setup Project Tools

To contribute to this project, you should have your local tool manifest setup correctly. The project is dependant on
Asp.Net Codegenerator and EF Migrations

    dotnet new tool-manifest   
    dotnet tool install --local dotnet-aspnet-codegenerator
    dotnet tool install --local dotnet-ef