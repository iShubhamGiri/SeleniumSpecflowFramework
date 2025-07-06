using OpenQA.Selenium;

namespace SeleniumSpecflowFramework.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement Username => _driver.FindElement(By.Id("user-name"));
        private IWebElement Password => _driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => _driver.FindElement(By.Id("login-button"));

        public void Login(string username, string password)
        {
            Username.Clear();
            Username.SendKeys(username);

            Password.Clear();
            Password.SendKeys(password);

            LoginButton.Click();
        }
    }
}
