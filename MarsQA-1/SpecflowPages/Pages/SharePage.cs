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
        private static IWebElement tagsTextBox => Driver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));

        private static IWebElement serviceHourlyRadioBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
        private static IWebElement serviceOneOffRadioBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
        private static IWebElement locationOnSiteRadioBtn => Driver.driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[6]/div[2]/div[1]/div[1]/div[1]/input[1]"));
        private static IWebElement locationOnlineRadioBtn => Driver.driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[6]/div[2]/div[1]/div[2]/div[1]/input[1]"));

        private static IWebElement skillExchangeRadioBtn => Driver.driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]/div[2]/div[1]/div[1]/div[1]/input[1]"));
        private static IWebElement creditRadioBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
        private static IWebElement skilltagsTextBox => Driver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
        private static IWebElement creditTextBox => Driver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));

        private static IWebElement uploadBtn => Driver.driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));

        private static IWebElement activeRadioBtn => Driver.driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[10]/div[2]/div[1]/div[1]/div[1]/input[1]"));
        private static IWebElement hiddenRadioBtn => Driver.driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[10]/div[2]/div[1]/div[2]/div[1]/input[1]"));

        private static IWebElement startDateTextBox => Driver.driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[1]/div[2]/input[1]"));
        private static IWebElement endDateTextBox => Driver.driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[1]/div[4]/input[1]"));
        private static IWebElement saveBtn => Driver.driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[11]/div[1]/input[1]"));
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
        public static void SelectCategoryStep(String categoryType)
        {
            //click drop down
            categoryDropdownBtn.Clear();

            //select value from dropdown
            categoryDropdown.SelectByText(categoryType);

        }
        public static void AddTags(string tags)
        {
            //click and clear text in tags textbox
            tagsTextBox.Click();
            tagsTextBox.Clear();

            //enter tags value
            tagsTextBox.SendKeys(tags);

        }
        public static void SelectServiceTypeStep(String radioType)
        {
            if (radioType == "Hourly basis")
            {
                //select value from radio button
                serviceHourlyRadioBtn.Click();
            }
            else
                serviceOneOffRadioBtn.Click();

        }

        public static void SelectLocationTypeStep(String locationType)
        {
            if (locationType == "on-site")
            {
                //select value from radiobutton
                locationOnSiteRadioBtn.Click();
            }
            else
                locationOnlineRadioBtn.Click();

        }

        public static void AvailableDays(string days)
        {
            //click and clear text in start date textbox
            startDateTextBox.Click();
            startDateTextBox.Clear();

            //enter tags value
            startDateTextBox.SendKeys(days);

            //click and clear text in start date textbox
            endDateTextBox.Click();
            endDateTextBox.Clear();

            //enter tags value
            endDateTextBox.SendKeys(days);

        }

        public static void SelectSkillTradeStep(String tradeType)
        {
            if (tradeType == "on-site")
            {
                //select value from radiobutton
                skillExchangeRadioBtn.Click();
                skilltagsTextBox.Click();
                skilltagsTextBox.SendKeys("BusinessExchange");
                skilltagsTextBox.SendKeys(Keys.Enter);
                skilltagsTextBox.SendKeys("CodingExchange");
                skilltagsTextBox.SendKeys(Keys.Enter);

            }
            else
            {
                creditRadioBtn.Click();
                creditTextBox.Click();
                creditTextBox.SendKeys("5");
            }

        }


        public static void UploadSampleWorkStep()
        {
            //click Upload samples Button
            uploadBtn.Click();
            string fileName = "worksample.pdf";
            string relativeFilePath = ConstantHelpers.GetRelativeFilePath(fileName);
        }

        public static void ActiveStep(String activeType)
        {
            if (activeType == "on-site")
            {
                //select value from radiobutton
                activeRadioBtn.Click();
            }
            else
                hiddenRadioBtn.Click();

        }
        public static void SaveSharePageStep(string tags)
        {

            saveBtn.Click();
        }




    }    
        
}

