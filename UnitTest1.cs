using learning_playwright_csharp.Config;
using learning_playwright_csharp.Driver;
using Microsoft.Playwright;

namespace learning_playwright_csharp
{
    public class Tests
    {
        private IPage _page;
        [SetUp]
        public async Task Setup()
        {
            TestSettings testSettings = new TestSettings
            {
                Headless = false,
                DriverType = DriverType.Webkit,
                SlowMo = 500,
            };
           
            PlaywrightDriver playwrightDriver = new PlaywrightDriver();
            _page = await playwrightDriver.InitializePLaywright(testSettings);
        }

        [Test]
        public async Task Test1()
        {
            await _page.GotoAsync("https://google.com/");
        }
    }
}