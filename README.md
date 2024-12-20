# Website Maintainer
Website Maintainer is a tool designed to help WordPress website administrators efficiently and securely manage multiple 
WordPress sites hosted on an Enhance Control Panel. The project aims to enforce better devops protocols for updating 
WordPress websites while streamlining the maintenance process.

## Project Overview
The primary goal of Website Maintainer is to address the common challenges faced by WordPress website administrators 
when managing their sites. Traditional WordPress maintenance can be time-consuming, error-prone, and lack the necessary 
safeguards to ensure a smooth and secure update process. Website Maintainer aims to solve these issues by providing the 
following key features:

## Features
- Bulk Site Maintenance: Maintain multiple WordPress sites from a single, centralized dashboard, reducing the overhead 
of managing sites individually.
- Selective Maintenance: Choose which sites are maintained and set different acceptance criteria for each, allowing for 
more granular control over the update process.
- Safe Updates: Automatically back up sites before updating, and perform both automatic and manual reviews to ensure 
the integrity of the updated websites.
- Persistent Database: Keep track of maintained websites in a persistent database, providing a comprehensive overview 
of the managed sites and their update history.
- API Integration: Integrate with the Enhance Control Panel API to seamlessly add more websites to the maintenance 
system, reducing the need for manual site onboarding.
## Getting Started

### Prerequisites
- .NET 8.0 SDK installed on your machine.
- Access to an Enhance Control Panel.
- Basic knowledge of ASP.NET and Entity Framework Core.

The project is shipped with a local SQLite database, and uses Asp.Net Individual authentication.

### Setup Project Tools

To contribute to, or use, this project, you should have your local tool manifest setup correctly. The project is 
dependent on EF Migrations and Microsoft Kiota.

    dotnet new tool-manifest   
    dotnet tool install --local dotnet-ef
    dotnet tool install --local Microsoft.OpenApi.Kiota

### Create and apply migrations

Make sure the database has the correct schema applied to it, you will need to create and update the project migrations.
This is also needed to seed the database when you first setup the application.

    generate-migrations.sh

This script will delete the old migrations (Should they exist), and add and apply new ones.

### Adding Api Clients to the project

To add new Api clients to the project, we make use of Kiota.
Modify the generate-clients.sh script to include your new client, and then run:

    ./generate-clients.sh

### Running the application

Run the application through .NET CLI

    dotnet run --project src/WebsiteMaintainer.Web

or:

    dotnet watch --project= src/WebsiteMaintainer.Web

To enable _Hot-readling_ while developing, run the application with

    dotnet run --project src/WebsiteMaintainer.Web

## License

This project is licensed under the MIT License.
