using System;
namespace PriceMonitor.Domain.Synchronization.Crawling;

public interface ICrawlingSource
{
    public CrawledPage CrawlPage(PageUrl pageUrl);

    public List<PageUrl> RetrieveUrls(CrawledPage crawledPage);
}

