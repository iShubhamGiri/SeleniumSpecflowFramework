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

        private IWebElement TxtUsername => _driver.FindElement(By.Id("username"));
        private IWebElement TxtPassword => _driver.FindElement(By.Id("password"));
        private IWebElement BtnLogin => _driver.FindElement(By.Id("loginButton"));

        public void Login(string username, string password)
        {
            TxtUsername.Clear();
            TxtUsername.SendKeys(username);

            TxtPassword.Clear();
            TxtPassword.SendKeys(password);

            BtnLogin.Click();
        }

        public bool IsDashboardVisible()
        {
            try
            {
                return _driver.FindElement(By.Id("dashboard")).Displayed;
            }
            catch
            {
                return false;
            }
        }
    }
}
