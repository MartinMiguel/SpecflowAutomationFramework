using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestAutomationFramework.Hooks;

namespace TestAutomationFramework.Pages
{
    public class HomePO
    {
        DriverHelper _driverHelper;

        public HomePO(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
        }

        IWebElement LnkLogin => _driverHelper.Driver.FindElement(By.Id("loginLink"));

        public void NavigateToHome() => _driverHelper.Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        public void ClickLoginLink() => LnkLogin.Click();
    }
}
