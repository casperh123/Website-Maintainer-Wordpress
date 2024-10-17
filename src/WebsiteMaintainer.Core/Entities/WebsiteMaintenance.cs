namespace WebsiteMaintainer.Core.Entities;

public class WebsiteMaintenance
{
    public Website Website { get; set; }
    public List<Plugin> Plugins { get; set; }
    
    public WebsiteMaintenance(Website website, List<Plugin> plugins)
    {
        Website = website;
        Plugins = plugins;
    }
}