using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class ProfileDetailsStepDefinitions
    {
        [Given(@"Seller navigate to sellers profile page")]
        public void GivenSellerNavigateToSellersProfilePage()
        {
            throw new PendingStepException();
        }

        [When(@"Seller enter ""([^""]*)"" name details")]
        public static void WhenSellerEnterNameDetails(string valid)
        {
            ProfilePage.EnterNameStep();
        }

        [When(@"Seller save name details")]
        public void WhenSellerSaveNameDetails()
        {
            ProfilePage.SaveNameStep();
        }

        [Then(@"Name details section should be updated succussfully")]
        public void ThenNameDetailsSectionShouldBeUpdatedSuccussfully()
        {
            ProfilePage.VerifyNameStep();
        }

        [When(@"Seller enter availability details as ""([^""]*)""")]
        public void WhenSellerEnterAvailabilityDetailsAs(string availabilityType)
        {
            ProfilePage.AvailabilityStep(availabilityType);
        }

        [When(@"Seller enter Hours details as ""([^""]*)""")]
        public void WhenSellerEnterHoursDetailsAs(string HoursType)
        {
            ProfilePage.HoursStep(HoursType);
        }

        [When(@"Seller enter Earn Targets as ""([^""]*)""")]
        public void WhenSellerEnterEarnTargetsAs(string TargetsType)
        {
            ProfilePage.TargetStep(TargetsType);
        }

        [Then(@"""([^""]*)"" should be updated succussfully")]
        public void ThenShouldBeUpdatedSuccussfully(string p0)
        {
            throw new PendingStepException();
        }

    }
}
