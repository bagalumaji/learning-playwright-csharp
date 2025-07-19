using Microsoft.Playwright;

namespace learning_playwright_csharp.Driver
{
    public class PlaywrightDriver
    {
        public async Task<IPage> InitializePLaywright()
        {
            IPlaywright playwright = await Playwright.CreateAsync();
            IBrowser browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false // Set to true for headless mode
            });
            IBrowserContext context = await browser.NewContextAsync();
            IPage page = await context.NewPageAsync();
            return page;

        }
    }
}
