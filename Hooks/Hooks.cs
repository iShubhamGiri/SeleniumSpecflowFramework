using TechTalk.SpecFlow;

namespace SeleniumSpecflowFramework.Hooks
{
    [Binding]
    public class Hooks
    {
        [AfterScenario]
        public void CleanUp()
        {
            Drivers.DriverFactory.QuitDriver();
        }
    }
}

