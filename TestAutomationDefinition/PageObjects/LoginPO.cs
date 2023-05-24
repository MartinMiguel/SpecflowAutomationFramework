using OpenQA.Selenium;

namespace TestAutomationFramework.Pages
{
    public class LoginPO
    {
        DriverHelper _driverHelper;

        public LoginPO(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
        }

        IWebElement btnLogin => _driverHelper.Driver.FindElement(By.XPath("//input[contains(@class, 'btn')]"));

        IWebElement txtPassword => _driverHelper.Driver.FindElement(By.Name("Password"));

        IWebElement txtUserName => _driverHelper.Driver.FindElement(By.Name("UserName"));

        public void EnterUserNameAndPassword(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }
    }
}
