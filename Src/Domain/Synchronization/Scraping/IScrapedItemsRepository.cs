using System;
namespace PriceMonitor.Domain.Synchronization.Scraping;

public interface IScrapedItemsRepository
{
    public void Save(ScrapedItem scrapedItem);

    public ScrapedItem? Get(Guid guid);
}

