using learning_playwright_csharp.TestBase;

namespace learning_playwright_csharp
{
    public class TestsBase :TestBaseSetup
    {
        [Test]
        public async Task Test1()
        {
            await PlaywrightDriver.Page.GotoAsync("https://google.com/");
        }

        [Test]
        public async Task Test2()
        {
            await PlaywrightDriver.Page.GotoAsync("https://github.com/");
        }
    }
}