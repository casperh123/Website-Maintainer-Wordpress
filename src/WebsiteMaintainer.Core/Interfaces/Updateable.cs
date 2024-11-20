namespace WebsiteMaintainer.Core.Interfaces;

public interface IUpdateable
{
    bool UpdateAvailable
    {
        get;
        set;
    }
}