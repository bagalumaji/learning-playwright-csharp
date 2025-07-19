using Microsoft.Playwright;

namespace learning_playwright_csharp
{
    public class LaunchingBrowserTests
    {
        [Test]
        public async Task LaunchChromeBrowserTest()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false, Channel = "chrome" });
            var browserContext = await browser.NewContextAsync();
            var page = await browserContext.NewPageAsync();
            await page.GotoAsync("https://www.google.com");
            Console.WriteLine(await page.TitleAsync());
            Console.WriteLine(page.Url);
            await page.CloseAsync();
            await browserContext.CloseAsync();
            await browser.CloseAsync();
        }
        [Test]
        public async Task LaunchFirefoxBrowserTest()
        {
            IPlaywright playwright = await Playwright.CreateAsync();
            IBrowser browser = await playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            IBrowserContext browserContext = await browser.NewContextAsync();
            IPage page = await browserContext.NewPageAsync();
            await page.GotoAsync("https://www.google.com");
            Console.WriteLine(await page.TitleAsync());
            Console.WriteLine(page.Url);
            await page.CloseAsync();
            await browserContext.CloseAsync();
            await browser.CloseAsync();
        }
        [Test]
        public async Task LaunchChromiumBrowserTest()
        {
            IPlaywright playwright = await Playwright.CreateAsync();
            IBrowser browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            IBrowserContext browserContext = await browser.NewContextAsync();
            IPage page = await browserContext.NewPageAsync();
            await page.GotoAsync("https://www.google.com");
            Console.WriteLine(await page.TitleAsync());
            Console.WriteLine(page.Url);
            await page.CloseAsync();
            await browserContext.CloseAsync();
            await browser.CloseAsync();
        }
        [Test]
        public async Task LaunchEdgeBrowserTest()
        {
            IPlaywright playwright = await Playwright.CreateAsync();
            IBrowser browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false, Channel = "msedge" });
            IBrowserContext browserContext = await browser.NewContextAsync();
            IPage page = await browserContext.NewPageAsync();
            await page.GotoAsync("https://www.google.com");
            Console.WriteLine(await page.TitleAsync());
            Console.WriteLine(page.Url);
            await page.CloseAsync();
            await browserContext.CloseAsync();
            await browser.CloseAsync();
        }
        [Test]
        public async Task LaunchWebkitTest()
        {
            IPlaywright playwright = await Playwright.CreateAsync();
            IBrowser browser = await playwright.Webkit.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            IBrowserContext browserContext = await browser.NewContextAsync();
            IPage page = await browserContext.NewPageAsync();
            await page.GotoAsync("https://www.google.com");
            Console.WriteLine(await page.TitleAsync());
            Console.WriteLine(page.Url);
            await page.CloseAsync();
            await browserContext.CloseAsync();
            await browser.CloseAsync();
        }
        [Test]
        public async Task LaunchBrowserAnotherOptionTest()
        {
            IPlaywright playwright = await Playwright.CreateAsync();
            IBrowser browser = await playwright["chromium"].LaunchAsync(new BrowserTypeLaunchOptions { Headless = false, Channel = "msedge" });
            IBrowserContext browserContext = await browser.NewContextAsync();
            IPage page = await browserContext.NewPageAsync();
            await page.GotoAsync("https://www.google.com");
            Console.WriteLine(await page.TitleAsync());
            Console.WriteLine(page.Url);
            await page.CloseAsync();
            await browserContext.CloseAsync();
            await browser.CloseAsync();
        }
    }
}
