using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class ProfileDetailsStepDefinitions
    {

        [When(@"Seller enter ""([^""]*)"" name details")]
        public static void WhenSellerEnterNameDetails(string valid)
        {
            ProfilePage.EnterNameStep();
            ProfilePage.SaveNameStep();
            //ProfilePage.VerifyNameStep();
        }

        [When(@"Seller enter availability details as ""([^""]*)"" and ""([^""]*)"" and ""([^""]*)""")]
        public void WhenSellerEnterAvailabilityDetails(string availabilityType, string hoursType, string targetType)
        {
            ProfilePage.AvailabilityStep(availabilityType);
            ProfilePage.HoursStep(hoursType);
            ProfilePage.TargetStep(targetType);
        }

        [When(@"Seller enter ""([^""]*)"" description")]
        public void WhenSellerEnterDescription(string description)
        {
            ProfilePage.AddDescriptionStep(description);
        }

        [When(@"Seller add ""([^""]*)"" and ""([^""]*)"" as language details")]
        public void WhenSellerAddLanguageDetails(string language, string level)
        {
            ProfilePage.AddLanguagesStep(language,level);
        }
       
        [When(@"Seller enter ""([^""]*)"" and ""([^""]*)"" as skills details")]
        public void WhenSellerEnterSkillsDetails(String skill, String level)
        {
            ProfilePage.AddSkillsStep(skill,level);
        }

        [When(@"Seller enter ""([^""]*)"",""([^""]*)"",""([^""]*)"", ""([^""]*)"" and ""([^""]*)"" as education details")]
        public void WhenSellerEnterAndAsEducationDetails(String university, String country, string title, string degree, string year)
        {
            ProfilePage.AddEducationStep(university,country, title, degree,year);
        }


        [When(@"Seller enter ""([^""]*)"" , ""([^""]*)""  and ""([^""]*)"" as Certification details")]
        public void WhenSellerEnterCertificationDetails(String certification, String year, string from)
        {
            ProfilePage.AddCertificationStep( certification,  year,  from);
        }

        [Then(@"Seller able to add profile details successfully")]
        public void ThenSellerAbleToAddProfileDetailsSuccessfully()
        {
            throw new PendingStepException();
        }

    }
}
