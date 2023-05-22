using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace MarsQA_1.SpecflowPages.Pages
{
    public static class ProfilePage
    {
        private static IWebElement NameExpandBtn =>  Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
        private static IWebElement FirstNameTextBox => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[1]"));
        private static IWebElement LastNameTextBox => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[2]"));
        private static IWebElement SaveBtn => Driver.driver.FindElement(By.XPath("//button[contains(text(),'Save')]"));

        private static IWebElement NameTextBox => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]"));

        private static IWebElement AvailabilityEditBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));

        
        private static IWebElement AvailabilityDropdownBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));

        private static SelectElement AvailabilityDropDown = new SelectElement(Driver.driver.FindElement(By.ClassName("availabiltyType")));
        private static IWebElement PartTimeOption => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[2]"));
        private static IWebElement FullTimeOption => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[3]"));
        
        private static IWebElement HoursEditBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));

        private static IWebElement HoursDropdownBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select"));
        
        private static SelectElement HoursDropDown = new SelectElement(Driver.driver.FindElement(By.ClassName("HoursType")));

        private static IWebElement Morethan30hoursOption => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[1]"));
        private static IWebElement Lessthan30hoursOption => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[2]"));
        private static IWebElement AsNeededOption => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[4]"));

        private static IWebElement EarnTargetsEditBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));

        
        private static IWebElement EarnTargetsDropdownBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select"));

        private static SelectElement EarnTargetsDropDown = new SelectElement(Driver.driver.FindElement(By.ClassName("TargetsType")));
        private static IWebElement LessThan500Option => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[1]"));
        private static IWebElement Between5001000Option => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[3]"));
        private static IWebElement MoreThan1000Option => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[4]"));

        
       private static IWebElement DescriptionEditButton => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));

       private static IWebElement DescriptionTextArea = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));

       private static IWebElement DescriptionSaveBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
        private static IWebElement SuccessMessageDiv => Driver.driver.FindElement(By.XPath("body:nth-child(2) div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show:nth-child(1) > div.ns-box-inner"));

        private static IWebElement LanguageAddNewButton => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));

        private static IWebElement LanguageTextBox = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));

        private static IWebElement LanguageLevelDropdownBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));

        private static SelectElement LanguageLevelDropDown = new SelectElement(Driver.driver.FindElement(By.ClassName("level")));

        private static IWebElement LanguageAddBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));

        private static IWebElement SkillsBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));

        private static IWebElement skillsAddNewBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));

       private static IWebElement skillsTextBox => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));

        private static SelectElement skillsLevelDropDown = new SelectElement(Driver.driver.FindElement(By.ClassName("level")));

        private static IWebElement skillsAddBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));

        private static IWebElement EducationBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));

        private static IWebElement EducationAddNewBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));

        private static IWebElement UniversityTextBox => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));

        private static IWebElement CountryDropdownBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
        
        private static SelectElement CountryDropdown = new SelectElement(Driver.driver.FindElement(By.ClassName("country")));

        private static IWebElement TitleDropdownBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));


        private static SelectElement TitleDropdown = new SelectElement(Driver.driver.FindElement(By.ClassName("title")));

        private static IWebElement DegreeTextBox => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));

        private static IWebElement YearDropdownBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));

        private static SelectElement YearDropdown = new SelectElement(Driver.driver.FindElement(By.ClassName("year")));

        private static IWebElement EducationAddBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));

        private static IWebElement CertificationBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));

        private static IWebElement CertificationAddNewBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));

        private static IWebElement CertificateTextBox => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));

        private static IWebElement FromTextBox => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));

        private static IWebElement GraduatedYearDropdownBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));

        private static SelectElement GraduatedYearDropDown = new SelectElement(Driver.driver.FindElement(By.ClassName("year")));

        private static IWebElement CertificationAddBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));

        public static void EnterNameStep()
        {
            Thread.Sleep(2000);
            //Enter name Details
            CommonMethods.ScrollToElement(Driver.driver, NameExpandBtn);
            NameExpandBtn.Click();
            FirstNameTextBox.SendKeys("Sandha");
            LastNameTextBox.SendKeys("Herath");
        }

        public static void SaveNameStep() 
        {
            // Save name Details
            SaveBtn.Click();
        }

        public static void VerifyNameStep() 
        {
            Assert.That(NameTextBox.Text == "Sandha Herath", "Save name details succussfully.");
        }

        public static void AvailabilityStep(String availabilityType)
        {
            //click edit button
            AvailabilityEditBtn.Click();
            //click drop down
            AvailabilityDropdownBtn.Click();
            //select value from dropdown
            AvailabilityDropDown.SelectByText(availabilityType);
        }

        public static void HoursStep(String HoursType)
        {
            //click Hours edit button
            HoursEditBtn.Click();
            //click drop down
            HoursDropdownBtn.Click();
            //select value from dropdown
            HoursDropDown.SelectByText(HoursType);
        }

        public static void TargetStep(String TargetsType)
        {
            //click edit button
            EarnTargetsEditBtn.Click();
            //click drop down
            EarnTargetsDropdownBtn.Click();
            //select value from dropdown
            EarnTargetsDropDown.SelectByText(TargetsType);
        }

        public static void AddDescriptionStep(String description)
        {
            //DescriptionEditBtn.Click();
            DescriptionEditButton.Click();

            //click and clear text in description textbox
            DescriptionTextArea.Click();
            DescriptionTextArea.Clear();

            //enter description value
            DescriptionTextArea.SendKeys(description);

            //click on save button
            DescriptionSaveBtn.Click();

            //verify alert text for description update
            Assert.That(SuccessMessageDiv.Displayed);
        }

        public static void AddLanguagesStep(String language, String level)
        {
            //LanguageEditBtn.Click();
            LanguageAddNewButton.Click();

            //click and clear text in Language textbox
            LanguageTextBox.Click();

            //enter Language value
            LanguageTextBox.SendKeys(language);

            LanguageLevelDropdownBtn.Click();
            //select value from dropdown
            LanguageLevelDropDown.SelectByText(level);

            //click on save button
            LanguageAddBtn.Click();

            //verify alert text for Language update
            Assert.That(SuccessMessageDiv.Displayed);

            // Delete added language
        }

        public static void AddSkillsStep(String skill, String level)
        {
            //Click skills Button
            SkillsBtn.Click();

            //skillsEditBtn.Click();
            skillsAddNewBtn.Click();

            //click and clear text in Language textbox
            skillsTextBox.Click();

            //enter Language value
            skillsTextBox.SendKeys(skill);

            LanguageLevelDropdownBtn.Click();
            //select value from dropdown
            skillsLevelDropDown.SelectByText(level);

            //click on save button
            skillsAddBtn.Click();

            //verify alert text for Skills update
            Assert.That(SuccessMessageDiv.Displayed);


        }
        public static void AddEducationStep(String education, String country, string title, string degree, string year)
        {
            //Click Education Button
            EducationBtn.Click();

            //skillsEditBtn.Click();
            EducationAddNewBtn.Click();

            //click and clear text in Education textbox
            UniversityTextBox.Click();

            //enter Education valuecountr
            UniversityTextBox.SendKeys(education);


            //Select Country of the University
            CountryDropdownBtn.Click();

            //select value from dropdown
            CountryDropdown.SelectByText(country);


            //Select Title
            TitleDropdownBtn.Click();

            //select value from dropdown
            TitleDropdown.SelectByText(title);

            //Add Degree on Degree Text Box
            DegreeTextBox.SendKeys(degree);

            //Select graduation Year
            YearDropdownBtn.Click();

            //select value from dropdown
            YearDropdown.SelectByText(year);

            //click on save button
            EducationAddBtn.Click();

            //verify alert text for Education update
            Assert.That(SuccessMessageDiv.Displayed);


        }
        public static void AddCertificationStep(String certification, String year, string from)
        {
            //Click Certification Button
            CertificationBtn.Click();

            //CertificationEditBtn.Click();
            CertificationAddNewBtn.Click();

            //click and clear text in Certification textbox
            CertificateTextBox.Click();
            CertificateTextBox.Clear();

            //enter Certification value
            CertificateTextBox.SendKeys(certification);

            //click and clear text in From textbox
            FromTextBox.Click();
            FromTextBox.Clear();

            //Enter certified from
            FromTextBox.SendKeys(from);

            GraduatedYearDropdownBtn.Click();

            //select value from dropdown
            GraduatedYearDropDown.SelectByText(year);

            //click on save button
            CertificationAddBtn.Click();

            //verify alert text for Language update
            Assert.That(SuccessMessageDiv.Displayed);


        }
    }
}
