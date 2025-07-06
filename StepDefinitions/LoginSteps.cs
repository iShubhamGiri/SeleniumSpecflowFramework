using TechTalk.SpecFlow;
using SeleniumSpecflowFramework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumSpecflowFramework.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage _loginPage;

        public LoginSteps()
        {
            _loginPage = new LoginPage();
        }

        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            DriverFactory.InitializeDriver();
            _loginPage.NavigateToLoginPage();
        }

        [When(@"I enter username ""(.*)"" and password ""(.*)""")]
        public void WhenIEnterUsernameAndPassword(string username, string password)
        {
            _loginPage.EnterUsername(username);
            _loginPage.EnterPassword(password);
        }

        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            _loginPage.ClickLogin();
        }

        [Then(@"I should be navigated to the homepage")]
        public void ThenIShouldBeNavigatedToTheHomepage()
        {
            Assert.IsTrue(_loginPage.IsLoginSuccessful());
            DriverFactory.QuitDriver();
        }
    }
}
