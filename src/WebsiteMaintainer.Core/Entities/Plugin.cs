namespace WebsiteMaintainer.Core.Entities;

public class Plugin
{
    public Plugin(
        string name, 
        string url, 
        string version, 
        bool updateAvailable, 
        PluginStatus status)
    {
        Name = name;
        Url = url;
        Version = version;
        UpdateAvailable = updateAvailable;
        Status = status;
    }

    public string Name {get; set;}
    public string Url { get; set; }
    public string Version { get; set; }
    public bool UpdateAvailable { get; set; }
    public PluginStatus Status { get; set; }
}