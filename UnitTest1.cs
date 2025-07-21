using learning_playwright_csharp.Config;
using learning_playwright_csharp.Driver;
using Microsoft.Playwright;

namespace learning_playwright_csharp
{
    public class Tests
    {
        
        private IPage _page;
        private PlaywrightDriver _playwrightDriver;
        [SetUp]
        public async Task Setup()
        {
            TestSettings testSettings = new TestSettings
            {
                Headless = false,
                DriverType = DriverType.Chrome,
                SlowMo = 500,
            };
           
             _playwrightDriver = new PlaywrightDriver();
            _page = await _playwrightDriver.InitializePLaywright(testSettings);
        }

        [Test]
        public async Task Test1()
        {
            await _page.GotoAsync("https://google.com/");
        }

        [TearDown]
        public async Task TearDown()
        {
            await _playwrightDriver.Browser.CloseAsync();
            await _playwrightDriver.Browser.DisposeAsync();
        }
    }
}