using MarsQA.SpecFlowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
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

        [When(@"Seller select ""([^""]*)"" as category and ""([^""]*)"" as sub Category")]
        public void WhenSellerSelectAsCategoryAndAsSubCategory(string business, string presentations)
        {
            SharePage.SelectCategoryStep(business, presentations);
        }



        [When(@"Seller enter ""([^""]*)"" and ""([^""]*)"" as tags")]
        public void WhenSellerEnterAndAsTags(string limitedEdition, string qualityProducts)
        {
            SharePage.AddTags(limitedEdition, qualityProducts);
        }


        [When(@"Seller select ""([^""]*)"" as Service type")]
        public void WhenSellerSelectAsServiceType(String radioType)
        {
            SharePage.SelectServiceTypeStep(radioType);
        }




        [When(@"Seller select ""([^""]*)"" as Location type")]
        public void WhenSellerSelectAsLocationType(String locationType)
        {
            SharePage.SelectLocationTypeStep( locationType);
        }


        [When(@"Seller select ""([^""]*)"" as start date and ""([^""]*)"" as end date")]
        public void WhenSellerSelectAsAvailableStartDateAndAsEndDate(string startDate, string endDate)
        {
            SharePage.AvailableDaysstep(startDate);
        }

        [When(@"Seller select ""([^""]*)"" ""([^""]*)"" as available start time and (.*) pm as end time")]
        public void WhenSellerSelectAsAvailableStartTimeAndPmAsEndTime(string p0, string p1, Decimal p2)
        {
            
        }



        [When(@"Seller choose ""([^""]*)"" as  skill trade")]
        public void WhenSellerChooseAsSkillTrade(string tradeType)
        {
            SharePage.SelectSkillTradeStep(tradeType);
        }

        [When(@"Seller add new tags ""([^""]*)"" and ""([^""]*)"" for skill exchange")]
        public void WhenSellerAddNewTagsAndForSkillExchange(string businessExchange, string codingExchange)
        {
            
        }


        [When(@"Seller upload ""([^""]*)"" work samples")]
        public void WhenSellerUploadWorkSamples(string p0)
        {
            SharePage.UploadSampleWorkStep();
        }

        [When(@"Seller select ""([^""]*)"" services")]
        public void WhenSellerSelectServices(string active)
        {
            SharePage.ActiveStep(active);
        }


        [When(@"Seller click save button")]
        public void WhenSellerClickSaveButton()
        {
            SharePage.SaveSharePageStep();
        }

        [Then(@"Seller is able to save share skill page succussfully")]
        public void ThenSellerIsAbleToSaveShareSkillPageSuccussfully()
        {
            throw new PendingStepException();
        }
    }
}
