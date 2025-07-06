using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumSpecflowFramework.Drivers
{
    public static class DriverFactory
    {
        public static IWebDriver Driver { get; private set; }

        public static void InitializeDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            Driver = new ChromeDriver(options);
        }

        public static void QuitDriver()
        {
            Driver?.Quit();
            Driver = null;
        }
    }
}

