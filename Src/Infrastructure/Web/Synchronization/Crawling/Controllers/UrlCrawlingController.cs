using Microsoft.AspNetCore.Mvc;

namespace PriceMonitor.Infrastructure.Web.Synchronization.Crawling.Controllers;

public class UrlCrawlingController: Controller
{
    [Route("/synchronization/crawling/crawl/{encodedUrl}")]
    public IActionResult Run(string encodedUrl)
    {
        // todo

        return View("~/Src/Infrastructure/Web/Synchronization/Crawling/Views/Index.cshtml");
    }
}