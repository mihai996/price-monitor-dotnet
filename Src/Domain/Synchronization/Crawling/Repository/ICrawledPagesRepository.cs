using System;
using PriceMonitor.Domain.Synchronization.Crawling.Entities;

namespace PriceMonitor.Domain.Synchronization.Crawling.Repository;

public interface ICrawledPagesRepository
{
    public void Save(CrawledPage crawledPage);

    public CrawledPage? Get(Guid guid);

    public List<CrawledPage> Filter(CrawledPagesFilter filter, Pagination pagination);
}

