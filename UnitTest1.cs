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
            TestSettings testSettings = new TestSettings();

            testSettings.Headless = false;
            testSettings.DevTool = true;
            testSettings.Channel = "chrome";
                testSettings.SlowMo = 500;
           

            PlaywrightDriver playwrightDriver = new PlaywrightDriver(testSettings);
            IPage page = await playwrightDriver.InitializePLaywright();
            await page.GotoAsync("https://google.com/");

        }
    }
}