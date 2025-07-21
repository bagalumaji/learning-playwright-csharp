using learning_playwright_csharp.Config;
using learning_playwright_csharp.Constants;
using Microsoft.Playwright;

namespace learning_playwright_csharp.Driver
{
    public class PlaywrightDriver
    {
        private TestSettings _settings;
        public PlaywrightDriver(TestSettings testSettings)
        {
            _settings = testSettings;
        }
        public IBrowser Browser;
        public async Task<IPage> InitializePLaywright()
        {
            Browser = await GetBrowserAsync(_settings);
            IBrowserContext context = await Browser.NewContextAsync();
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
                    launchOptions.Channel = FrameworkConstants.CHROME_CHANNEL;
                    return await playwright.Chromium.LaunchAsync(launchOptions);
                case DriverType.Firefox:
                    return await playwright.Firefox.LaunchAsync(launchOptions);
                case DriverType.Webkit:
                    return await playwright.Webkit.LaunchAsync(launchOptions);
                case DriverType.Edge:
                    launchOptions.Channel = FrameworkConstants.EDGE_CHANNEL;
                    return await playwright.Chromium.LaunchAsync(launchOptions);
                default:
                    return await playwright.Chromium.LaunchAsync(launchOptions);
            }
        }
    }
}
