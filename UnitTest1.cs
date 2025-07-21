using learning_playwright_csharp.Config;
using learning_playwright_csharp.Driver;
using learning_playwright_csharp.TestBase;
using Microsoft.Playwright;

namespace learning_playwright_csharp
{
    public class Tests :TestSetup
    {
        [Test]
        public async Task Test1()
        {
            await Page.GotoAsync("https://google.com/");
        }

        [Test]
        public async Task Test2()
        {
            await Page.GotoAsync("https://github.com/");
        }
    }
}