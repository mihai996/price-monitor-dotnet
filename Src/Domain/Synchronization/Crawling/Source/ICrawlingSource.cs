using System;
using PriceMonitor.Domain.Synchronization.Crawling.Entities;

namespace PriceMonitor.Domain.Synchronization.Crawling.Source;

public interface ICrawlingSource
{
    public CrawledPage CrawlPage(PageUrl pageUrl);

    public List<PageUrl> RetrieveUrls(CrawledPage crawledPage);
}

