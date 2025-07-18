using Microsoft.Playwright;
using System.Threading.Tasks;

namespace learning_playwright_csharp
{
    public class FrameDemo
    {
        [Test]
        public async Task FrameDemoTest()
        {
            IPlaywright playwright = await Playwright.CreateAsync();
            IBrowser browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless=false});
            IBrowserContext browserContext = await browser.NewContextAsync();
            IPage page = await browserContext.NewPageAsync();
            await page.GotoAsync("https://www.lambdatest.com/selenium-playground/iframe-demo/");
            await page.FrameLocator("#iFrame1").Locator("//div[text()='Your content.']").FillAsync("SayajiRaje");
            await page.WaitForTimeoutAsync(6000);
        }
    }
}
