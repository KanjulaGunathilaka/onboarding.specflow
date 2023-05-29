using MarsQA.SpecFlowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class ManageListingStepDefinitions
    {
        [When(@"Seller navigate to manage listing")]
        public void WhenSellerNavigateToManageListing()
        {
            ManageListingPage.NavigateStep();
        }

        [When(@"listing details visible")]
        public void WhenListingDetailsVisible()
        {
            ManageListingPage.VisibleStep();
        }

        [When(@"Seller click ""([^""]*)""  on share skill page")]
        public void WhenSellerClickOnShareSkillPage(string p0)
        {
            ManageListingPage.ViewProfileDetailsStep();
        }

        [Then(@"Seller is able to see the seller’s profile details successfully")]
        public void ThenSellerIsAbleToSeeTheSellerSProfileDetailsSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
