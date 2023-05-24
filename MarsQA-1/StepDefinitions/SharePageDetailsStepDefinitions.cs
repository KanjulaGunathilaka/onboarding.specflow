using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class SharePageDetailsStepDefinitions
    {
        [When(@"Seller is navigate to share skill page")]
        public void WhenSellerIsNavigateToShareSkillPage()
        {
            SharePage.NavigateStep();
        }

        [When(@"Seller enter ""([^""]*)"" Title")]
        public void WhenSellerEnterTitle(string title)
        {
            SharePage.AddTitleStep(title);
        }

        [When(@"Seller enter ""([^""]*)"" Description")]
        public void WhenSellerEnterDescription(string description)
        {
            SharePage.AddShareDescriptionStep(description);
        }

        [When(@"Seller select ""([^""]*)"" as category")]
        public void WhenSellerSelectAsCategory(string business)
        {
            throw new PendingStepException();
        }


        [When(@"Seller enter ""([^""]*)"" and ""([^""]*)"" as tags")]
        public void WhenSellerEnterAndAsTags(string limitedEdition, string qualityProducts)
        {
            throw new PendingStepException();
        }


        [When(@"Seller select ""([^""]*)"" as Service type")]
        public void WhenSellerSelectAsServiceType(string p0)
        {
            throw new PendingStepException();
        }




        [When(@"Seller select ""([^""]*)"" as Location type")]
        public void WhenSellerSelectAsLocationType(string p0)
        {
            throw new PendingStepException();
        }


        [When(@"Seller select (.*)/(.*) as available start date and (.*)/(.*) as end date")]
        public void WhenSellerSelectAsAvailableStartDateAndAsEndDate(Decimal p0, int p1, Decimal p2, int p3)
        {
            throw new PendingStepException();
        }

        [When(@"Seller select ""([^""]*)"" ""([^""]*)"" as available start time and (.*) pm as end time")]
        public void WhenSellerSelectAsAvailableStartTimeAndPmAsEndTime(string p0, string p1, Decimal p2)
        {
            throw new PendingStepException();
        }



        [When(@"Seller choose ""([^""]*)"" as  skill trade")]
        public void WhenSellerChooseAsSkillTrade(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"Seller add new tags ""([^""]*)"" and ""([^""]*)"" for skill exchange")]
        public void WhenSellerAddNewTagsAndForSkillExchange(string businessExchange, string codingExchange)
        {
            throw new PendingStepException();
        }


        [When(@"Seller upload ""([^""]*)"" work samples")]
        public void WhenSellerUploadWorkSamples(string p0)
        {
        
        }

        [When(@"Seller select ""([^""]*)"" services")]
        public void WhenSellerSelectServices(string active)
        {
            throw new PendingStepException();
        }


        [When(@"Seller click save button")]
        public void WhenSellerClickSaveButton()
        {
            throw new PendingStepException();
        }

        [Then(@"Seller is able to save share skill page succussfully")]
        public void ThenSellerIsAbleToSaveShareSkillPageSuccussfully()
        {
            throw new PendingStepException();
        }
    }
}
