using Microsoft.Playwright;

namespace learning_playwright_csharp
{
    public class BasicOpearation
    {
        [Test]
        public async Task BasicOperationTest()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false, Channel = "msedge" });
            var browserContext = await browser.NewContextAsync();
            var page = await browserContext.NewPageAsync();
            await page.GotoAsync("https://testautomationpractice.blogspot.com/");
            Console.WriteLine("Title : " + await page.TitleAsync());
            Console.WriteLine("URL : " + page.Url);
            await page.GetByPlaceholder("Enter Name").FillAsync("SayajiRaje");
            await page.GetByPlaceholder("Enter EMail").FillAsync("Sharu@bagal.com");
            await page.GetByLabel("Male", new PageGetByLabelOptions { Exact = true }).CheckAsync();
            await page.GetByLabel("Sunday").CheckAsync();
            await page.WaitForTimeoutAsync(6000); 
        }
    }
}
