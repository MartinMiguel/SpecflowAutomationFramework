using NUnit.Framework;
using TechTalk.SpecFlow;
using TestAutomationFramework.PageObjects;
using TestAutomationFramework.Pages;

namespace TestAutomationFramework.StepsDefinitions
{
    [Binding]
    public class DashboardSD
    {
        private DashboardPO _dashboardPO; 

        public DashboardSD(DashboardPO dashboardePO) 
        {
            _dashboardPO = dashboardePO;
        }

        [Then(@"I should see user logged in the application")]
        public void ThenIShouldSeeUserLoggedInTheApplication()
        {
            Assert.That(_dashboardPO.IsLogOffExist(), Is.True, "Log off button did not displayed");
        }

    }
}
