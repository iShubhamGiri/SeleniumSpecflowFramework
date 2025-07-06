using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumSpecflowFramework.Drivers;
using SeleniumSpecflowFramework.Helpers;
using SeleniumSpecflowFramework.Pages;
using TechTalk.SpecFlow;

namespace SeleniumSpecflowFramework.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _loginPage;

        public LoginSteps(BrowserDriver browserDriver)
        {
            _driver = browserDriver.Current;
            _loginPage = new LoginPage(_driver);
        }

        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            string baseUrl = ResxReader.Get("BaseUrl");
            _driver.Navigate().GoToUrl(baseUrl);
        }

        [When(@"I login with valid credentials")]
        public void WhenILoginWithValidCredentials()
        {
            string username = ResxReader.Get("DefaultUsername");
            string password = ResxReader.Get("DefaultPassword");
            _loginPage.Login(username, password);
        }

        [Then(@"I should see the dashboard")]
        public void ThenIShouldSeeTheDashboard()
        {
            Assert.IsTrue(_loginPage.IsDashboardVisible(), "Dashboard is not visible after login.");
        }
    }
}
