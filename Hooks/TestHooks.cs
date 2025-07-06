using SeleniumSpecflowFramework.Drivers;
using TechTalk.SpecFlow;

namespace SeleniumSpecflowFramework.Hooks
{
    [Binding]
    public class TestHooks
    {
        private readonly BrowserDriver _browserDriver;

        public TestHooks(BrowserDriver browserDriver)
        {
            _browserDriver = browserDriver;
        }

        [AfterScenario]
        public void CleanUp()
        {
            _browserDriver.Quit();
        }
    }
}
