using learning_playwright_csharp.Config;
using learning_playwright_csharp.Driver;
using Microsoft.Playwright;

namespace learning_playwright_csharp.TestBase;

public abstract class TestBaseSetup
{
    public required IPage Page;
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
           
        _playwrightDriver = new PlaywrightDriver(testSettings);
        Page = await _playwrightDriver.InitializePLaywright();
    }
    [TearDown]
    public async Task TearDown()
    {
        await _playwrightDriver.Browser.CloseAsync();
        await _playwrightDriver.Browser.DisposeAsync();
    }
}