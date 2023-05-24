using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestAutomationFramework.PageObjects
{
    public class DashboardPO
    {
        DriverHelper _driverHelper;

        public DashboardPO(DriverHelper driverHelper) 
        {
            _driverHelper = driverHelper;
        }

        public bool IsLogOffExist() => LnkLogOff.Displayed;
        IWebElement LnkLogOff => _driverHelper.Driver.FindElement(By.LinkText("Log off"));
    }
}
