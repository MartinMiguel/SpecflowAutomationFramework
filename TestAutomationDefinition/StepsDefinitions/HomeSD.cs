using TechTalk.SpecFlow;
using TestAutomationFramework.Pages;

namespace TestAutomationFramework.Steps
{
    [Binding]
    public class HomeSD
    {
        private HomePO _homePO;

        public HomeSD(HomePO homePO)
        {
            _homePO = homePO;
        }

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            _homePO.NavigateToHome();
        }

        [Given(@"I click login link")]
        public void GivenIClickLogin()
        {
            _homePO.ClickLoginLink();
        }
    }
}
