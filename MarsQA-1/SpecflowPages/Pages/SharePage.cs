using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public static class SharePage
    {
        private static IWebElement shareSkillBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a"));
        private static IWebElement titleTextArea => Driver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
        private static IWebElement shareDescriptionTextArea => Driver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
        private static IWebElement categoryDropdownBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select"));

        private static SelectElement categoryDropdown = new SelectElement(Driver.driver.FindElement(By.ClassName("category")));



        public static void NavigateStep()
        {
            shareSkillBtn.Click();
        }

        public static void AddTitleStep(string title)
        {
            //click and clear text in title textbox
            titleTextArea.Click();
            titleTextArea.Clear();

            //enter description value
            titleTextArea.SendKeys(title);
        }

        public static void AddShareDescriptionStep(string description)
        {
            //click and clear text in title textbox
            shareDescriptionTextArea.Click();
            shareDescriptionTextArea.Clear();

            //enter description value
            shareDescriptionTextArea.SendKeys(description);

        }
        public static void AvailabilityStep(String availabilityType)
        {
           
            //click drop down
            AvailabilityDropdownBtn.Click();
            //select value from dropdown
            AvailabilityDropDown.SelectByText(availabilityType);
        }

    }
}
