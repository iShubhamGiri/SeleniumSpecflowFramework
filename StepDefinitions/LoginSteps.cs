using TechTalk.SpecFlow;
using SeleniumSpecflowFramework.Pages;
using OpenQA.Selenium;
using SeleniumSpecflowFramework.Resources;

namespace SeleniumSpecflowFramework.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _loginPage;

        public LoginSteps()
        {
            _driver = (IWebDriver)ScenarioContext.Current["WebDriver"];
            _loginPage = new LoginPage(_driver);
        }

        [Given(@"I login with valid credentials")]
        public void GivenILoginWithValidCredentials()
        {
            _loginPage.Login(TestData.LoginUsername, TestData.LoginPassword);
        }

        [Then(@"I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            var title = _driver.FindElement(By.ClassName("title")).Text;
            Assert.AreEqual("Products", title);
        }
    }
}
