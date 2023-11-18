using PriceMonitor.Domain.Synchronization.Crawling.Entities;
using PriceMonitor.Domain.Synchronization.Crawling.Source.Exceptions;

namespace PriceMonitor.Domain.Synchronization.Crawling.Source;

public interface ICrawlingSource
{
    /// <summary>
    /// This method performs a critical operation.
    /// </summary>
    /// <exception cref="PageNotFoundException">Thrown if a critical condition is not met.</exception>
    /// <exception cref="PageTimeoutException">Thrown if a critical condition is not met.</exception>
    public CrawledPage CrawlPage(PageUrl pageUrl);
}

