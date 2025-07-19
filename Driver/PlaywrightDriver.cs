using Microsoft.Playwright;

namespace learning_playwright_csharp.Driver
{
    public class PlaywrightDriver
    {
        public async Task<IPage> InitializePLaywright()
        {
            IPlaywright playwright = await Playwright.CreateAsync();
            BrowserTypeLaunchOptions launchOptions = new BrowserTypeLaunchOptions
            {
                Headless = false
            };
            IBrowser browser = await playwright.Chromium.LaunchAsync(launchOptions);
            IBrowserContext context = await browser.NewContextAsync();
            IPage page = await context.NewPageAsync();
            return page;

        }
    }
}
