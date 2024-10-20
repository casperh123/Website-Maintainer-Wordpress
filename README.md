# Website Maintainer
Website Maintainer helps you to efficiently manage your WordPress sites hosted with an Enhance Control Panel. It provides a way to safely and efficiently update WordPress sites within your control panel.

## Features
 - Bulk Site Maintenance: Maintain multiple WordPress sites from a single dashboard.
 - Selective Maintenance: Choose which sites are maintained by you and set different acceptence criteria for each.
 - Safe Updates: Automatically back up sites before updating and perform both automatic and manual reviews.
 - Persistent Database: Keep track of maintained websites in a persistent database.
 - API Integration: Add more websites through API integration with the Enhance Control Panel.

## Getting Started

### Prerequisites
- .NET 8.0 SDK installed on your machine.
- Access to an Enhance Control Panel.
- Basic knowledge of ASP.NET and Entity Framework Core.

The project is shipped with a local SQLite database, and uses Asp.Net Individual authentication.

### Setup Project Tools

To contribute to this project, you should have your local tool manifest setup correctly. The project is dependent on EF Migrations

    dotnet new tool-manifest   
    dotnet tool install --local dotnet-ef
    dotnet tool install --local Microsoft.OpenApi.Kiota


### Create and apply migrations

Make sure the database has the correct schema applied to it, you will need to create and update the project migrations.

    dotnet ef migrations add MigrationName -p src/WebsiteMaintainer.Infrastructure -s src/WebsiteMaintainer.Web
    dotnet ef database update -p src/WebsiteMaintainer.Infrastructure -s src/WebsiteMaintainer.Web

To delete these clients, use

sudo rm -rf src/WebsiteMaintainer.Infrastructure/Clients/Enhance

### Running the application

Run the application through .NET CLI

    dotnet run --project src/WebsiteMaintainer.Web

To enable _Hot-readling_ while developing, run the application with

    dotnet run --project src/WebsiteMaintainer.Web

### Adding Api Clients to the project

To add new Api clients to the project, we make use of Kiota.

    sudo dotnet tool restore
    sudo dotnet kiota generate -l CSharp -c EnhanceClient -n Enhance.Client -d=src/WebsiteMaintainer.Infrastructure/ApiSpecifications/enhance-api.yaml -o=./src/WebsiteMaintainer.Infrastructure/Clients/Enhance --ebc false --co true


## License

This project is licensed under the MIT License.
