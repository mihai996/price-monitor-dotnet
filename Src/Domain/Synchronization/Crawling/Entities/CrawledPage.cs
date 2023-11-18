namespace PriceMonitor.Domain.Synchronization.Crawling.Entities;

public class CrawledPage
{
    private readonly string _pageData;

    public CrawledPage(string pageData)
    {
        _pageData = pageData;
    }

    public List<PageUrl> RetrieveUrls()
    {
        var urls = new List<PageUrl>();

        if (_pageData?.Length > 0)
        {
            // todo
            urls.Add(new PageUrl("http://some.domain.test/some/product/id?param=1"));
        }

        return urls;
    }
}