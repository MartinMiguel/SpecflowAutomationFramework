using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace TestAutomationFramework.Hooks
{
    [Binding]
    public class Base
    {
        public DriverHelper _driverHelper;

        public Base(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driverHelper.Driver = new ChromeDriver();
            _driverHelper.Driver.Manage().Window.Maximize();
            Console.WriteLine("Setup");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverHelper.Driver.Quit();
            Console.WriteLine("Teardown");
        }
    }
}
