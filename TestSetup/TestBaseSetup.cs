using learning_playwright_csharp.Config;
using learning_playwright_csharp.Driver;

namespace learning_playwright_csharp.TestBase;

public abstract class TestBaseSetup
{
    //public required IPage Page;
    protected PlaywrightDriver PlaywrightDriver;
    [SetUp]
    public async Task Setup()
    {
        TestSettings testSettings = new TestSettings
        {
            Headless = false,
            DriverType = DriverType.Chrome,
            SlowMo = 500,
        };
           
        PlaywrightDriver = new PlaywrightDriver(testSettings);
        //Page = await _playwrightDriver.InitializePLaywright();
    }
    [TearDown]
    public async Task TearDown()
    {
        await PlaywrightDriver.Page.CloseAsync();
        await PlaywrightDriver.BrowserContext.CloseAsync();
        await PlaywrightDriver.Browser.CloseAsync();
        await PlaywrightDriver.Browser.DisposeAsync();
    }
}