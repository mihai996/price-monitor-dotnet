using System;
using PriceMonitor.Domain.Synchronization.Crawling.Source;

namespace PriceMonitor.Domain.Synchronization.Crawling.Services;

public class PageCrawlingService
{
    private readonly ICrawlingSource _crawlingSource;

    public PageCrawlingService(ICrawlingSource crawlingSource)
    {
        _crawlingSource = crawlingSource;
    }

    public void Crawl(PageUrl url)
    {
        var page = _crawlingSource.CrawlPage(url);
        // todo
    }
}