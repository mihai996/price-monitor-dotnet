using PriceMonitor.Domain.Synchronization.Crawling.Entities;
using PriceMonitor.Domain.Synchronization.Crawling.Repository;
using PriceMonitor.Domain.Synchronization.Crawling.Source;

namespace PriceMonitor.Domain.Synchronization.Crawling.Services;

public class PageCrawlingService
{
    private readonly ICrawlingSource _crawlingSource;
    private readonly ICrawledPagesRepository _crawledPagesRepository;

    public PageCrawlingService(ICrawlingSource crawlingSource, ICrawledPagesRepository crawledPagesRepository)
    {
        _crawlingSource = crawlingSource;
        _crawledPagesRepository = crawledPagesRepository;
    }

    public CrawledPage Crawl(string aUrl)
    {
        var url = new PageUrl(aUrl);
        var page = _crawlingSource.CrawlPage(url);
        _crawledPagesRepository.Save(page);
        return page;
    }
}