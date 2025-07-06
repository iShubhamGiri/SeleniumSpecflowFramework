using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumSpecflowFramework.Drivers
{
    public static class DriverFactory
    {
        public static IWebDriver CreateDriver()
        {
            var options = new ChromeOptions();
            return new ChromeDriver(options);
        }
    }
}
