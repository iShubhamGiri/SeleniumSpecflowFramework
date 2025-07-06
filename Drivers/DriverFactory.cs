using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumSpecflowFramework.Helpers;

namespace SeleniumSpecflowFramework.Drivers
{
    public class BrowserDriver
    {
        public IWebDriver Current { get; private set; }

        public BrowserDriver()
        {
            string browser = ResxReader.Get("Browser").ToLower();
            int implicitWait = ResxReader.GetInt("ImplicitWaitInSeconds");

            if (browser == "chrome")
            {
                var options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                Current = new ChromeDriver(options);
            }
            else
            {
                throw new NotSupportedException($"Browser '{browser}' is not supported.");
            }

            Current.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWait);
        }

        public void Quit()
        {
            Current.Quit();
        }
    }
}
