using MarsQA.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class SharePageDetailsStepDefinitions
    {
        private IWebDriver driver;
        private SharePage sharePage;

        public SharePageDetailsStepDefinitions(ScenarioContext scenarioContext)
        {
            driver = scenarioContext.Get<IWebDriver>("driver");
            sharePage = new SharePage(driver);
        }

        [When(@"Seller is navigate to share skill page")]
        public void WhenSellerIsNavigateToShareSkillPage()
        {
            sharePage.NavigateStep();
        }

        [When(@"Seller enter ""([^""]*)"" Title")]
        public void WhenSellerEnterTitle(string title)
        {
            sharePage.AddTitleStep(title);
        }

        [When(@"Seller enter ""([^""]*)"" Description")]
        public void WhenSellerEnterDescription(string description)
        {
            sharePage.AddShareDescriptionStep(description);
        }

        [When(@"Seller select ""([^""]*)"" as category and ""([^""]*)"" as sub Category")]
        public void WhenSellerSelectAsCategoryAndAsSubCategory(string business, string presentations)
        {
            sharePage.SelectCategoryStep(business, presentations);
        }



        [When(@"Seller enter ""([^""]*)"" and ""([^""]*)"" as tags")]
        public void WhenSellerEnterAndAsTags(string limitedEdition, string qualityProducts)
        {
            sharePage.AddTags(limitedEdition, qualityProducts);
        }


        [When(@"Seller select ""([^""]*)"" as Service type")]
        public void WhenSellerSelectAsServiceType(String radioType)
        {
            sharePage.SelectServiceTypeStep(radioType);
        }




        [When(@"Seller select ""([^""]*)"" as Location type")]
        public void WhenSellerSelectAsLocationType(String locationType)
        {
            sharePage.SelectLocationTypeStep( locationType);
        }


        [When(@"Seller select ""([^""]*)"" as start date and ""([^""]*)"" as end date")]
        public void WhenSellerSelectAsAvailableStartDateAndAsEndDate(string startDate, string endDate)
        {
            sharePage.AvailableDaysstep(startDate);
        }

        [When(@"Seller select ""([^""]*)"" ""([^""]*)"" as available start time and (.*) pm as end time")]
        public void WhenSellerSelectAsAvailableStartTimeAndPmAsEndTime(string p0, string p1, Decimal p2)
        {
            
        }



        [When(@"Seller choose ""([^""]*)"" as  skill trade")]
        public void WhenSellerChooseAsSkillTrade(string tradeType)
        {
            sharePage.SelectSkillTradeStep(tradeType);
        }

        [When(@"Seller add new tags ""([^""]*)"" and ""([^""]*)"" for skill exchange")]
        public void WhenSellerAddNewTagsAndForSkillExchange(string businessExchange, string codingExchange)
        {
            
        }


        [When(@"Seller upload ""([^""]*)"" work samples")]
        public void WhenSellerUploadWorkSamples(string p0)
        {
            sharePage.UploadSampleWorkStep();
        }

        [When(@"Seller select ""([^""]*)"" services")]
        public void WhenSellerSelectServices(string active)
        {
            sharePage.ActiveStep(active);
        }


        [When(@"Seller click save button")]
        public void WhenSellerClickSaveButton()
        {
            sharePage.SaveSharePageStep();
        }

        [Then(@"Seller is able to save share skill page succussfully")]
        public void ThenSellerIsAbleToSaveShareSkillPageSuccussfully()
        {
            throw new PendingStepException();
        }
    }
}
