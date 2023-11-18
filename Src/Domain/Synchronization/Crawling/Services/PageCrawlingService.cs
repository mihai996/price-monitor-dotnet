using System;
using PriceMonitor.Domain.Synchronization.Crawling.Entities;

namespace PriceMonitor.Domain.Synchronization.Crawling.Services;

public class PageCrawlingService
{
	private readonly ICrawlingSource CrawlingSource;

    public PageCrawlingService(ICrawlingSource crawlingSource)
	{
		CrawlingSource = crawlingSource;
	}

	public void Crawl(PageUrl url)
	{
		CrawledPage page = CrawlingSource.CrawlPage(url);
		// todo
	}
}
