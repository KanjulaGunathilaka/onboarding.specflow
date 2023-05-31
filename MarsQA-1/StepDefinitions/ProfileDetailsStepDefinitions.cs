using MarsQA.SpecFlowPages.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA
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

        [When(@"Seller enter availability details as ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)""")]
        public void WhenSellerEnterAvailabilityDetails(string availabilityType, string hoursType, string targetType)
        {
            profilePage.AvailabilityStep(availabilityType);
            profilePage.HoursStep(hoursType);
            profilePage.TargetStep(targetType);
        }

        [When(@"Seller enter ""([^""]*)"" description")]
        public void WhenSellerEnterDescription(string description)
        {
            profilePage.AddDescriptionStep(description);
        }

        [When(@"Seller add ""([^""]*)"" and ""([^""]*)"" as language details")]
        public void WhenSellerAddLanguageDetails(string language, string level)
        {
            profilePage.AddLanguagesStep(language, level);
        }

        [When(@"Seller enter ""([^""]*)"" and ""([^""]*)"" as skills details")]
        public void WhenSellerEnterSkillsDetails(String skill, String level)
        {
            profilePage.AddSkillsStep(skill, level);
        }

        [When(@"Seller enter ""([^""]*)"",""([^""]*)"",""([^""]*)"", ""([^""]*)"" and ""([^""]*)"" as education details")]
        public void WhenSellerEnterAndAsEducationDetails(String university, String country, string title, string degree, string year)
        {
            profilePage.AddEducationStep(university, country, title, degree, year);
        }


        [When(@"Seller enter ""([^""]*)"" , ""([^""]*)""  and ""([^""]*)"" as Certification details")]
        public void WhenSellerEnterCertificationDetails(String certification, String year, string from)
        {
            profilePage.AddCertificationStep(certification, year, from);
        }

        [Then(@"Seller able to add profile details successfully")]
        public void ThenSellerAbleToAddProfileDetailsSuccessfully()
        {
            throw new PendingStepException();
        }

    }
}
