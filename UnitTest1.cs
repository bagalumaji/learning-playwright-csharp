using learning_playwright_csharp.Config;
using learning_playwright_csharp.Driver;
using Microsoft.Playwright;

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
            TestSettings testSettings = new TestSettings
            {
                Headless = false,
                DriverType = DriverType.Webkit,
                SlowMo = 500,
            };
           
            PlaywrightDriver playwrightDriver = new PlaywrightDriver();
            IPage page = await playwrightDriver.InitializePLaywright(testSettings);
            await page.GotoAsync("https://google.com/");

        }
    }
}