using MarsQA.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarsQA.Pages
{
    [Binding]
    public class SharePage
    {
        private IWebDriver driver;
        public SharePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private static IWebElement shareSkillBtn => CommonDriver.webDriver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a"));
        private static IWebElement titleTextArea => CommonDriver.webDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
        private static IWebElement shareDescriptionTextArea => CommonDriver.webDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
        private static IWebElement categoryDropdownBtn => CommonDriver.webDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div/select"));

        private static SelectElement categoryDropdown = new SelectElement(CommonDriver.webDriver.FindElement(By.ClassName("category")));
        private static IWebElement subCategoryDropdownBtn => CommonDriver.webDriver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[3]/div[2]/div[1]/div[2]/div[1]/select[1]"));

        private static SelectElement subCategoryDropdown = new SelectElement(CommonDriver.webDriver.FindElement(By.ClassName("subcategory")));
        private static IWebElement tagsTextBox => CommonDriver.webDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));

        private static IWebElement serviceHourlyRadioBtn => CommonDriver.webDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
        private static IWebElement serviceOneOffRadioBtn => CommonDriver.webDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
        private static IWebElement locationOnSiteRadioBtn => CommonDriver.webDriver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[6]/div[2]/div[1]/div[1]/div[1]/input[1]"));
        private static IWebElement locationOnlineRadioBtn => CommonDriver.webDriver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[6]/div[2]/div[1]/div[2]/div[1]/input[1]"));

        private static IWebElement skillExchangeRadioBtn => CommonDriver.webDriver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]/div[2]/div[1]/div[1]/div[1]/input[1]"));
        private static IWebElement creditRadioBtn => CommonDriver.webDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
        private static IWebElement skilltagsTextBox => CommonDriver.webDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
        private static IWebElement creditTextBox => CommonDriver.webDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));

        private static IWebElement uploadBtn => CommonDriver.webDriver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));

        private static IWebElement activeRadioBtn => CommonDriver.webDriver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[10]/div[2]/div[1]/div[1]/div[1]/input[1]"));
        private static IWebElement hiddenRadioBtn => CommonDriver.webDriver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[10]/div[2]/div[1]/div[2]/div[1]/input[1]"));

        private static IWebElement startDateTextBox => CommonDriver.webDriver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[1]/div[2]/input[1]"));
        private static IWebElement endDateTextBox => CommonDriver.webDriver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[1]/div[4]/input[1]"));
        private static IWebElement saveBtn => CommonDriver.webDriver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[11]/div[1]/input[1]"));



        public void NavigateStep()
        {
            shareSkillBtn.Click();
        }

        public void AddTitleStep(string title)
        {
            //click and clear text in title textbox
            titleTextArea.Click();
            titleTextArea.Clear();

            //enter description value
            titleTextArea.SendKeys(title);
        }

        public void AddShareDescriptionStep(string description)
        {
            //click and clear text in title textbox
            shareDescriptionTextArea.Click();
            shareDescriptionTextArea.Clear();

            //enter description value
            shareDescriptionTextArea.SendKeys(description);

        }
        public void SelectCategoryStep(String business, string presentations)
        {
            //click drop down
            categoryDropdownBtn.Clear();

            //select value from dropdown
            categoryDropdown.SelectByText(business);

            //click drop down
            subCategoryDropdownBtn.Clear();

            //select value from dropdown
            subCategoryDropdown.SelectByText(presentations);

        }
        public void AddTags(string limitedEdition, string qualityProducts)
        {
            //click and clear text in tags textbox
            tagsTextBox.Click();
            tagsTextBox.Clear();

            //enter tags value
            tagsTextBox.SendKeys(limitedEdition);
            tagsTextBox.SendKeys(Keys.Enter);
            tagsTextBox.SendKeys(qualityProducts);
            tagsTextBox.SendKeys(Keys.Enter);

        }
        public void SelectServiceTypeStep(String radioType)
        {
            if (radioType == "Hourly basis")
            {
                //select value from radio button
                serviceHourlyRadioBtn.Click();
            }
            else
                serviceOneOffRadioBtn.Click();

        }

        public void SelectLocationTypeStep(String locationType)
        {
            if (locationType == "on-site")
            {
                //select value from radiobutton
                locationOnSiteRadioBtn.Click();
            }
            else
                locationOnlineRadioBtn.Click();

        }

        public void AvailableDaysstep(string days)
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

        public void SelectSkillTradeStep(String tradeType)
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


        public void UploadSampleWorkStep()
        {
            //click Upload samples Button
            uploadBtn.Click();
            string fileName = "worksample.pdf";
            string relativeFilePath = ConstantHelpers.GetRelativeFilePath(fileName);
        }

        public void ActiveStep(String activeType)
        {
            if (activeType == "on-site")
            {
                //select value from radiobutton
                activeRadioBtn.Click();
            }
            else
                hiddenRadioBtn.Click();

        }
        public void SaveSharePageStep()
        {

            saveBtn.Click();
        }

        public void verifystep()
        {


        }


    }

}

