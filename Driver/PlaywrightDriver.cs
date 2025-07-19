using learning_playwright_csharp.Config;
using Microsoft.Playwright;
using System.Threading.Channels;

namespace learning_playwright_csharp.Driver
{
    public class PlaywrightDriver
    {
        public async Task<IPage> InitializePLaywright(TestSettings testSettings)
        {
            IBrowser browser = await GetBrowserAsync(testSettings);
            IBrowserContext context = await browser.NewContextAsync();
            IPage page = await context.NewPageAsync();
            return page;
        }
        public async Task<IBrowser> GetBrowserAsync(TestSettings testSettings)
        {
            IPlaywright playwright = await Playwright.CreateAsync();
            BrowserTypeLaunchOptions launchOptions = new BrowserTypeLaunchOptions
            {
                Headless = testSettings.Headless,
                SlowMo = testSettings.SlowMo
            };

            switch (testSettings.DriverType)
            {
                case DriverType.Chrome:
                    launchOptions.Channel = "chrome";
                    return await playwright.Chromium.LaunchAsync(launchOptions);
                case DriverType.Firefox:
                    return await playwright.Firefox.LaunchAsync(launchOptions);
                case DriverType.Webkit:
                    return await playwright.Webkit.LaunchAsync(launchOptions);
                case DriverType.Edge:
                    launchOptions.Channel = "msedge";
                    return await playwright.Chromium.LaunchAsync(launchOptions);
                default:
                    return await playwright.Chromium.LaunchAsync(launchOptions);
            }
        }
    }
}
