using OpenQA.Selenium;

namespace SeleniumSpecflowFramework.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;

        public LoginPage()
        {
            _driver = DriverFactory.Driver;
        }

        private IWebElement UsernameField => _driver.FindElement(By.Id("user-name"));
        private IWebElement PasswordField => _driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => _driver.FindElement(By.Id("login-button"));
        private IWebElement InventoryContainer => _driver.FindElement(By.Id("inventory_container"));

        public void NavigateToLoginPage() => _driver.Navigate().GoToUrl("https://www.saucedemo.com/");

        public void EnterUsername(string username) => UsernameField.SendKeys(username);

        public void EnterPassword(string password) => PasswordField.SendKeys(password);

        public void ClickLogin() => LoginButton.Click();

        public bool IsLoginSuccessful() => InventoryContainer.Displayed;
    }
}
