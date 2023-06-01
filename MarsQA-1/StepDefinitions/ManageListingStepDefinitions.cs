using MarsQA.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class ManageListingStepDefinitions
    {
        private IWebDriver driver;
        private ManageListingPage manageListingPage;

        public ManageListingStepDefinitions(ScenarioContext scenarioContext)
        {
            driver = scenarioContext.Get<IWebDriver>("driver");
            manageListingPage = new ManageListingPage(driver);
        }

        [When(@"Seller navigate to manage listing")]
        public void WhenSellerNavigateToManageListing()
        {
            manageListingPage.NavigateStep();
        }

        [When(@"listing details visible")]
        public void WhenListingDetailsVisible()
        {
            manageListingPage.VisibleStep();
        }

        [When(@"Seller click ""([^""]*)""  on share skill page")]
        public void WhenSellerClickOnShareSkillPage(string p0)
        {
            manageListingPage.ViewProfileDetailsStep();
        }

        [Then(@"Seller is able to see the seller’s profile details successfully")]
        public void ThenSellerIsAbleToSeeTheSellerSProfileDetailsSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
