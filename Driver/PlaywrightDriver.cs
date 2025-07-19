using learning_playwright_csharp.Config;
using Microsoft.Playwright;

namespace learning_playwright_csharp.Driver
{
    public class PlaywrightDriver
    {
        public async Task<IPage> InitializePLaywright(TestSettings testSettings)
        {
            IPlaywright playwright = await Playwright.CreateAsync();
            BrowserTypeLaunchOptions launchOptions = new BrowserTypeLaunchOptions();
            launchOptions.Headless = testSettings.Headless;
            launchOptions.SlowMo = testSettings.SlowMo;
            launchOptions.Channel =testSettings.Channel;
            IBrowser browser = await playwright.Chromium.LaunchAsync(launchOptions);
            IBrowserContext context = await browser.NewContextAsync();
            IPage page = await context.NewPageAsync();
            return page;

        }
    }
}
