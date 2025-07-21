using learning_playwright_csharp.TestBase;

namespace learning_playwright_csharp
{
    public class TestsBase :TestBaseSetup
    {
        [Test]
        public async Task Test1()
        {
            await _playwrightDriver.Page.Result.GotoAsync("https://google.com/");
        }

        [Test]
        public async Task Test2()
        {
            await _playwrightDriver.Page.Result.GotoAsync("https://github.com/");
        }
    }
}