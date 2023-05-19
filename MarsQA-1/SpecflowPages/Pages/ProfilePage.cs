using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public static class ProfilePage
    {
        private static IWebElement NameExpandBtn =>  Driver.driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/i[1]"));
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


        public static void EnterNameStep()
        {
            //Enter name Details
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

        internal static void HoursStep(object hoursType)
        {
            throw new NotImplementedException();
        }
    } 
}
