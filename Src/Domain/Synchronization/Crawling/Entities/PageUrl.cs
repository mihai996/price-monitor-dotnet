namespace PriceMonitor.Domain.Synchronization.Crawling.Entities;

public class PageUrl
{
    public readonly string RawUrl;

    private string? _sanitizedUrl;

    public PageUrl(string rawUrl)
    {
        RawUrl = rawUrl;
    }

    public string GetSanitizedUrl()
    {
        _sanitizedUrl = RawUrl + ""; // todo
        
        return _sanitizedUrl;
    }
}