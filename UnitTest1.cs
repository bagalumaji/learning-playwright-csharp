using Microsoft.Playwright;
using System.Threading.Tasks;

namespace learning_playwright_csharp
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test1()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false, Channel = "msedge" });
            var browserContext = await browser.NewContextAsync();
            var page = await browserContext.NewPageAsync();
            await page.GotoAsync("https://google.com/");
            await browser.CloseAsync();
        }
    }
}