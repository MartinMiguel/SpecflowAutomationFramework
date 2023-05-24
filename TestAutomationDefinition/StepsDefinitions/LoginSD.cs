using TechTalk.SpecFlow;
using TestAutomationFramework.Pages;

namespace TestAutomationFramework.Steps
{
    [Binding]
    public class LoginSD
    {
        private LoginPO _loginPO;

        public LoginSD(LoginPO loginPO)
        {
            _loginPO = loginPO;
        }

        [When(@"I provide ""([^""]*)"" and ""([^""]*)""")]
        public void WhenIProvideAnd(string userName, string password)
        {
            _loginPO.EnterUserNameAndPassword(userName, password);
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            _loginPO.ClickLogin();
        }

    }
}
