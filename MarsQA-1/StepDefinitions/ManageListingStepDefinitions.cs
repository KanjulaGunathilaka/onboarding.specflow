using MarsQA.Pages;
using MarsQA.Utils;
using NLog;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class ManageListingStepDefinitions
    {
        private IWebDriver driver;
        private static readonly Logger Logger = LoggerManager.Logger;
        private ManageListingPage manageListingPage;

        public ManageListingStepDefinitions(ScenarioContext scenarioContext)
        {
            driver = scenarioContext.Get<IWebDriver>("driver");
            manageListingPage = new ManageListingPage(driver);
        }

        [Then(@"Seller should be able to see saved skills in Manage Listings successfully")]
        public void ThenSellerIsAbleToSaveShareSkillPageSuccessfully(Table table)
        {
            manageListingPage.verifySavedSkillStep(table);
            manageListingPage.DeleteSkillsStep();
        }

        [Given(@"Seller navigate to manage listing page")]
        public void GivenSellerNavigateToManageListing()
        {
            manageListingPage.NavigateToManageListingsStep();
        }

        [When(@"Seller click ""([^""]*)"" on Manage Listings page")]
        public void WhenSellerClickOnShareSkillPage(string viewSkill)
        {
            manageListingPage.ViewProfileDetailsStep();
        }

        [Then(@"Seller is able to see the seller’s profile details successfully")]
        public void ThenSellerIsAbleToSeeTheSellerSProfileDetailsSuccessfully(Table table)
        {
            manageListingPage.verifySharedSkillDetails(table);
            try
            {
                manageListingPage.NavigateToManageListingsStep();
                manageListingPage.DeleteSkillsStep();
            }
            catch
            {
                Logger.Info("Delete Skills not successful");
            }
        }


    }
}
