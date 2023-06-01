using MarsQA.Helpers;
using MarsQA.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA.Pages
{
    [Binding]
    public class ProfilePage : CommonMethods
    {
        private IWebDriver driver;
        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //User Name Details Section
        private IWebElement nameExpandBtn => driver.FindElement(By.XPath("//*[@id='account-profile-section']//div[@class='title']/i"));
        private IWebElement firstNameTextBox => driver.FindElement(By.XPath("//input[@name='firstName']"));
        private IWebElement lastNameTextBox => driver.FindElement(By.XPath("//input[@name='lastName']"));
        private IWebElement nameSaveBtn => driver.FindElement(By.XPath("//button[@class='ui teal button']"));
        private IWebElement fullNameDiv => driver.FindElement(By.XPath("//div[@class='title']"));

        //User Preference of Work Section
        private IWebElement availabilityEditBtn => driver.FindElement(By.XPath("//div[@class='item'][2]//div/span/i"));
        private IWebElement availabilityDropDownBtn => driver.FindElement(By.XPath("//select[@class='ui right labeled dropdown' and @name='availabiltyType']"));
        private SelectElement availabilityDropDown => new SelectElement(driver.FindElement(By.XPath("//select[@class='ui right labeled dropdown' and @name='availabiltyType']")));

        private IWebElement hoursEditBtn => driver.FindElement(By.XPath("//div[@class='item'][3]//div/span/i"));
        private IWebElement hoursDropDownBtn => driver.FindElement(By.XPath("//select[@class='ui right labeled dropdown' and @name='availabiltyHour']"));
        private SelectElement hoursDropDown => new SelectElement(driver.FindElement(By.XPath("//select[@class='ui right labeled dropdown' and @name='availabiltyHour']")));

        private IWebElement earnTargetsEditBtn => driver.FindElement(By.XPath("//div[@class='item'][4]//div/span/i"));
        private IWebElement earnTargetsDropDownBtn => driver.FindElement(By.XPath("//select[@class='ui right labeled dropdown' and @name='availabiltyTarget']"));
        private SelectElement earnTargetsDropDown => new SelectElement(driver.FindElement(By.XPath("//select[@class='ui right labeled dropdown' and @name='availabiltyTarget']")));

        //User Description Section
        private IWebElement descriptionEditButton => driver.FindElement(By.XPath("//h3[@class='ui dividing header'][text()='Description']/span/i"));
        private IWebElement descriptionTextArea => driver.FindElement(By.XPath("//textarea[@name='value']"));
        private IWebElement descriptionSaveBtn => driver.FindElement(By.XPath("//div[@class='ui twelve wide column']//button[@class='ui teal button']"));
        private IWebElement successMessageDiv => driver.FindElement(By.XPath("body:nth-child(2) div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show:nth-child(1) > div.ns-box-inner"));

        //Qualifictions Section
        private IWebElement qualificationTable => driver.FindElement(By.XPath("//table[@class='ui fixed table']"));
        private IWebElement languageTabLink => driver.FindElement(By.XPath("//a[@data-tab='first']"));
        private IWebElement skillsTabLink => driver.FindElement(By.XPath("//a[@data-tab='second']"));
        private IWebElement educationTabLink => driver.FindElement(By.XPath("//a[@data-tab='third']"));
        private IWebElement certificationTabLink => driver.FindElement(By.XPath("//a[@data-tab='fourth']"));

        private IWebElement LanguageAddNewButton => driver.FindElement(By.XPath("//table[@class='ui fixed table']//th[3]/div[@class='ui teal button ']"));
        private IWebElement LanguageTextBox => driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        private IWebElement LanguageLevelDropdownBtn => driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='level']"));
        private SelectElement LanguageLevelDropDown => new SelectElement(driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='level']")));
        private IWebElement LanguageAddBtn => driver.FindElement(By.XPath("//input[@value='Add']"));
        private IWebElement LanguageDeleteBtn => driver.FindElement(By.XPath("//tbody//td[@class='right aligned']/span[2]"));


        private IWebElement skillsAddNewBtn => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));

        private IWebElement skillsTextBox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));

        private SelectElement skillsLevelDropDown => new SelectElement(driver.FindElement(By.ClassName("level")));

        private IWebElement skillsAddBtn => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));


        private IWebElement EducationAddNewBtn => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));

        private IWebElement UniversityTextBox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));

        private IWebElement CountryDropdownBtn => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));

        private SelectElement CountryDropdown => new SelectElement(driver.FindElement(By.ClassName("country")));

        private IWebElement TitleDropdownBtn => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));


        private SelectElement TitleDropdown => new SelectElement(driver.FindElement(By.ClassName("title")));

        private IWebElement DegreeTextBox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));

        private IWebElement YearDropdownBtn => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));

        private SelectElement YearDropdown => new SelectElement(driver.FindElement(By.ClassName("year")));

        private IWebElement EducationAddBtn => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));


        private IWebElement CertificationAddNewBtn => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));

        private IWebElement CertificateTextBox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));

        private IWebElement FromTextBox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));

        private IWebElement GraduatedYearDropdownBtn => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));

        private SelectElement GraduatedYearDropDown => new SelectElement(driver.FindElement(By.ClassName("year")));

        private IWebElement CertificationAddBtn => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));

        public void EnterNameStep(string firstName, string lastName)
        {
            nameExpandBtn.Click();
            ScrollToElement(driver, firstNameTextBox);
            SetField(firstNameTextBox, firstName);
            SetField(lastNameTextBox, lastName);
        }

        public void SaveNameStep()
        {
            ScrollToElement(driver, nameSaveBtn);
            nameSaveBtn.Click();
        }

        public void VerifyNameStep()
        {
            Assert.That(fullNameDiv.Text == "Sandha Herath", "Save name details successfully.");
        }

        public void AvailabilityStep(String availabilityType)
        {
            ScrollToElement(driver, availabilityEditBtn);
            availabilityEditBtn.Click();
            availabilityDropDownBtn.Click();
            Thread.Sleep(1000);
            availabilityDropDown.SelectByText(availabilityType);
        }

        public void HoursStep(String HoursType)
        {
            hoursEditBtn.Click();
            hoursDropDownBtn.Click();
            Thread.Sleep(1000);
            hoursDropDown.SelectByText(HoursType);
        }

        public void TargetStep(String TargetsType)
        {
            earnTargetsEditBtn.Click();
            earnTargetsDropDownBtn.Click();
            Thread.Sleep(1000);
            earnTargetsDropDown.SelectByText(TargetsType);
        }

        public void AddDescriptionStep(String description)
        {
            descriptionEditButton.Click();
            descriptionTextArea.Click();
            SetField(descriptionTextArea, description);
            descriptionSaveBtn.Click();
            Assert.That(successMessageDiv.Displayed);
        }

        public void AddLanguagesStep(String language, String level)
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
            Assert.That(successMessageDiv.Displayed);

            // Delete added language
        }

        public void AddSkillsStep(String skill, String level)
        {
            //Click skills Button
            skillsTabLink.Click();

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
            Assert.That(successMessageDiv.Displayed);


        }
        public void AddEducationStep(String university, String country, string title, string degree, string year)
        {
            //Click Education Button
            educationTabLink.Click();

            //skillsEditBtn.Click();
            EducationAddNewBtn.Click();

            //click and clear text in Education textbox
            UniversityTextBox.Click();

            //enter Education valuecountr
            UniversityTextBox.SendKeys(university);


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
            Assert.That(successMessageDiv.Displayed);


        }
        public void AddCertificationStep(String certification, String year, string from)
        {
            //Click Certification Button
            certificationTabLink.Click();

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
            Assert.That(successMessageDiv.Displayed);
        }

        private void DeleteTableRowIfExists(IWebElement table)
        {
            try
            {
                IReadOnlyCollection<IWebElement> rows = table.FindElements(By.TagName("tr"));
                if (rows.Count > 0)
                {
                    IWebElement deleteButton = null;
                    bool deleteButtonFound = false;
                    foreach (IWebElement row in rows)
                    {
                        deleteButton = row.FindElement(By.XPath(".//td[@class='right aligned']/span[2]"));
                        if (deleteButton != null)
                        {
                            deleteButtonFound = true;
                            break;
                        }
                    }
                    if (deleteButtonFound)
                    {
                        deleteButton.Click();
                    }
                    else
                    {
                        Console.WriteLine("Delete button not found in any row.");
                    }
                }
                else
                {
                    Console.WriteLine("No rows found in the table.");
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Table or delete button not found.");
            }
        }


    }
}
