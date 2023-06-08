using MarsQA.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    public class ProfileDetailsStepDefinitions
    {
        private IWebDriver driver;
        private ProfilePage profilePage;

        public ProfileDetailsStepDefinitions(ScenarioContext scenarioContext)
        {
            driver = scenarioContext.Get<IWebDriver>("driver");
            profilePage = new ProfilePage(driver);
        }

        [When(@"Seller enter name details$")]
        public void WhenSellerEnterNameDetails(Table table)
        {
            foreach (var row in table.Rows)
            {
                string firstName = row["FirstName"];
                string lastName = row["LastName"];
                profilePage.EnterNameStep(firstName, lastName);
            }
            profilePage.SaveNameStep();
        }

        [When(@"Seller enter availability details$")]
        public void WhenSellerEnterAvailabilityDetails(Table table)
        {
            foreach (var row in table.Rows)
            {
                string availabilityType = row["Availability"];
                string hoursType = row["Hours"];
                string targetType = row["EarnTarget"];
                profilePage.AvailabilityStep(availabilityType);
                profilePage.HoursStep(hoursType);
                profilePage.TargetStep(targetType);
            }
        }

        [When(@"Seller enter ""([^""]*)"" as description")]
        public void WhenSellerEnterDescription(string description)
        {
            profilePage.AddDescriptionStep(description);
        }

        [When(@"Seller add language details$")]
        public void WhenSellerAddLanguageDetails(Table table)
        {
            foreach (var row in table.Rows)
            {
                string language = row["Language"];
                string level = row["Level"];
                profilePage.AddLanguagesStep(language, level);
            }
        }

        [When(@"Seller enter skills details$")]
        public void WhenSellerEnterSkillsDetails(Table table)
        {
            foreach (var row in table.Rows)
            {
                string skill = row["Skill"];
                string level = row["Level"];
                profilePage.AddSkillsStep(skill, level);
            }
        }

        [When(@"Seller enter education details$")]
        public void WhenSellerEnterAndAsEducationDetails(Table table)
        {
            foreach (var row in table.Rows)
            {
                string university = row["University"];
                string country = row["Country"];
                string title = row["Title"];
                string degree = row["Degree"];
                string year = row["Year"];
                profilePage.AddEducationStep(university, country, title, degree, year);
            }
        }


        [When(@"Seller enter Certification details")]
        public void WhenSellerEnterCertificationDetails(Table table)
        {
            foreach (var row in table.Rows)
            {
                string certificate = row["Certificate"];
                string certifiedFrom = row["Institute"];
                string year = row["Year"];
                profilePage.AddCertificationStep(certificate, certifiedFrom, year);
            }
        }

        [Then(@"Seller should be able to see profile details successfully")]
        public void ThenSellerShouldBeAbleToSeeProfileDetailsSuccessfully()
        {
            profilePage.VerifyProfileSection();
        }

    }
}
