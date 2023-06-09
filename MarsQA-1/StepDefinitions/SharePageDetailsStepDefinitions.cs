using MarsQA.Pages;
using OpenQA.Selenium;
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
        public void WhenSellerEnterAndAsTags(string tag1, string tag2)
        {
            sharePage.AddTags(tag1, tag2);
        }

        [When(@"Seller select ""([^""]*)"" as Service type")]
        public void WhenSellerSelectAsServiceType(string serviceType)
        {
            sharePage.SelectServiceTypeStep(serviceType);
        }

        [When(@"Seller select ""([^""]*)"" as Location type")]
        public void WhenSellerSelectAsLocationType(string locationType)
        {
            sharePage.SelectLocationTypeStep(locationType);
        }

        [When(@"Seller select ""([^""]*)"" as start date and ""([^""]*)"" as end date")]
        public void WhenSellerSelectAsAvailableStartDateAndAsEndDate(string startDate, string endDate)
        {
            sharePage.AvailableDaysStep(startDate, endDate);
        }

        [When(@"Seller choose ""([^""]*)"" as skill trade")]
        public void WhenSellerChooseAsSkillTrade(string tradeType)
        {
            sharePage.SelectSkillTradeStep(tradeType);
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

        [Given(@"Seller add new skills to the profile")]
        public void GivenSellerAddNewSkillsToTheProfile(Table table)
        {
            foreach (var row in table.Rows)
            {
                string title = row["Title"];
                string description = row["Description"];
                string category = row["Category"];
                string subCategory = row["SubCategory"];

                sharePage.NavigateStep();
                sharePage.AddTitleStep(title);
                sharePage.AddShareDescriptionStep(description);
                sharePage.SelectCategoryStep(category, subCategory);
                sharePage.AddTags("viewTag1", "viewTag2");
                sharePage.SelectServiceTypeStep("Hourly basis service");
                sharePage.SelectLocationTypeStep("On-site");
                sharePage.AvailableDaysStep("31/12/2023", "30/12/2024");
                sharePage.SelectSkillTradeStep("On-site");
                sharePage.ActiveStep("Active");
                sharePage.SaveSharePageStep();
            }
        }

    }
}
