namespace learning_playwright_csharp.Config
{
    public class TestSettings
    {
        public bool Headless { get; set; }
        public DriverType DriverType { get; set; }
        //public string Channel { get; set; }
        public int SlowMo { get; set; }
    }
    public enum DriverType
    {
        Chrome,
        Firefox,
        Webkit,
        Chromium,
        Edge
    }
}
