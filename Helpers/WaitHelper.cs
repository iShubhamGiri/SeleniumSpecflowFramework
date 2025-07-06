using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumSpecflowFramework.Helpers
{
    public static class WaitHelper
    {
        public static void WaitForElementVisible(IWebDriver driver, By locator, int timeoutSeconds = 10)
        {
            WebDriverWait wait = new(driver, TimeSpan.FromSeconds(timeoutSeconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }
    }
}
