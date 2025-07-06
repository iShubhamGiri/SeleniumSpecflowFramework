using OpenQA.Selenium;
using TechTalk.SpecFlow;
using SeleniumSpecflowFramework.Helpers;
using SeleniumSpecflowFramework.Pages;
using SeleniumSpecflowFramework.Resources;

namespace SeleniumSpecflowFramework.Hooks
{
    [Binding]
    public class DriverHooks
    {
        private static IWebDriver _driver;

        [BeforeScenario]
        public void Setup()
        {
            _driver = DriverFactory.CreateDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(TestData.AppUrl); // From .resx
            ScenarioContext.Current["WebDriver"] = _driver;
        }

        [AfterScenario]
        public void TearDown()
        {
            _driver?.Quit();
        }
    }
}
