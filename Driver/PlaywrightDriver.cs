using learning_playwright_csharp.Config;
using learning_playwright_csharp.Constants;
using Microsoft.Playwright;

namespace learning_playwright_csharp.Driver
{
    public class PlaywrightDriver
    {
        private TestSettings _settings;
        public Task<IPage> Page;
        public Task<IBrowser> Browser;
        public Task<IBrowserContext> BrowserContext;
        
        public PlaywrightDriver(TestSettings testSettings)
        {
            _settings = testSettings;
            Browser = Task.Run(InitializePLaywright);
            BrowserContext = Task.Run(CreateBrowserContextAsync);
            Page = Task.Run(CreateNewPageAsync);
        }

        private async Task<IBrowser> InitializePLaywright()
        {
            return await GetBrowserAsync(_settings);
        }
        private async Task<IBrowserContext> CreateBrowserContextAsync()
        {
            return await (await Browser).NewContextAsync();
        }

        protected async Task<IPage> CreateNewPageAsync()
        {
           return await(await CreateBrowserContextAsync()).NewPageAsync();
        }
       
        private async Task<IBrowser> GetBrowserAsync(TestSettings testSettings)
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
