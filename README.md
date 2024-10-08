# EnhanceSiteUpdater
_Enhance Site Updater_ helps you to efficiently manage your WordPress sites hosted with an Enhance Control Panel.
It gives you a way to safely and efficiently update WordPress sites within your control panel.

Add your sites to the control panel, manage which ones are mantained by you, to which degree care should be taken
when updating the site, and update them from a single dashboard.

Sites will be backed up, updated, automatically reviewed and then manually reviewed to ensure nothing is broken. This is all done in bulk
or for single sites that are chosen by the user. Websites that are maintained by you are added to a persistent database, and more websites
can be added through our API integration with Enhance Control Panel. 

## Start Developing

The project is shipped with a local SQLite database, and uses Asp.Net Individual authentication.

### Setup Project Tools

To contribute to this project, you should have your local tool manifest setup correctly. The project is dependent on EF Migrations

    dotnet new tool-manifest   
    dotnet tool install --local dotnet-ef

### Create and apply migrations

Make sure the database has the correct schema applied to it, you will need to create and update the project migrations.

    dotnet ef migrations add MigrationName -p src/EnhanceSiteUpdater.Service -s src/EnhanceSiteUpdater.Web
    dotnet ef database update -p src/EnhanceSiteUpdater.Service -s src/EnhanceSiteUpdater.Web