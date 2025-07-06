using BoDi;
using SeleniumSpecflowFramework.Drivers;
using TechTalk.SpecFlow;

[Binding]
public class SpecFlowHooks
{
    private readonly IObjectContainer _container;

    public SpecFlowHooks(IObjectContainer container)
    {
        _container = container;
    }

    [BeforeScenario(Order = 0)]
    public void Setup()
    {
        var driver = new BrowserDriver();
        _container.RegisterInstanceAs(driver);
    }
}
