using MarsQA.Helpers;
using MarsQA.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace MarsQA.Pages
{
    [Binding]
    public class SharePage : CommonMethods
    {
        private IWebDriver driver;
        public SharePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private static IWebElement shareSkillBtn => CommonDriver.webDriver.FindElement(By.XPath("//a[contains(text(),'Share Skill')]"));
        private static IWebElement titleTextBox => CommonDriver.webDriver.FindElement(By.XPath("//input[@name='title']"));
        private static IWebElement shareDescriptionTextArea => CommonDriver.webDriver.FindElement(By.XPath("//textarea[@name='description']"));
        private static IWebElement categoryDropdownBtn => CommonDriver.webDriver.FindElement(By.XPath("//select[@name='categoryId']"));
        private static SelectElement categoryDropdown => new SelectElement(CommonDriver.webDriver.FindElement(By.XPath("//select[@name='categoryId']")));
        private static IWebElement subCategoryDropdownBtn => CommonDriver.webDriver.FindElement(By.XPath("//select[@name='subcategoryId']"));
        private static SelectElement subCategoryDropdown => new SelectElement(CommonDriver.webDriver.FindElement(By.XPath("//select[@name='subcategoryId']")));
        private static IWebElement tagsTextBox => CommonDriver.webDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]//input"));

        private static IWebElement serviceHourlyRadioBtn => CommonDriver.webDriver.FindElement(By.XPath("//label[text()='Hourly basis service']/preceding-sibling::input[@type='radio']"));
        private static IWebElement serviceOneOffRadioBtn => CommonDriver.webDriver.FindElement(By.XPath("//label[text()='One-off service']/preceding-sibling::input[@type='radio']"));
        private static IWebElement locationOnSiteRadioBtn => CommonDriver.webDriver.FindElement(By.XPath("//label[text()='On-site']/preceding-sibling::input[@type='radio']"));
        private static IWebElement locationOnlineRadioBtn => CommonDriver.webDriver.FindElement(By.XPath("//label[text()='Online']/preceding-sibling::input[@type='radio']"));
        private static IWebElement startDateTextBox => CommonDriver.webDriver.FindElement(By.XPath("//input[@name='startDate']"));
        private static IWebElement endDateTextBox => CommonDriver.webDriver.FindElement(By.XPath("//input[@name='endDate']"));

        private static IWebElement skillExchangeRadioBtn => CommonDriver.webDriver.FindElement(By.XPath("//label[text()='Skill-exchange']/preceding-sibling::input[@type='radio']"));
        private static IWebElement creditRadioBtn => CommonDriver.webDriver.FindElement(By.XPath("//label[text()='Credit']/preceding-sibling::input[@type='radio']"));
        private static IWebElement skillTagsTextBox => CommonDriver.webDriver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]//input"));
        private static IWebElement creditTextBox => CommonDriver.webDriver.FindElement(By.XPath("//input[@name='charge']"));

        private static IWebElement uploadBtn => CommonDriver.webDriver.FindElement(By.XPath("//i[@class='huge plus circle icon padding-25']"));
        private static IWebElement activeRadioBtn => CommonDriver.webDriver.FindElement(By.XPath("//label[text()='Active']/preceding-sibling::input[@type='radio']"));
        private static IWebElement hiddenRadioBtn => CommonDriver.webDriver.FindElement(By.XPath("//label[text()='Hidden']/preceding-sibling::input[@type='radio']"));
        private static IWebElement saveBtn => CommonDriver.webDriver.FindElement(By.XPath("//input[@class='ui teal button' and @value='Save']"));

        public void NavigateStep()
        {
            shareSkillBtn.Click();
            Wait.WaitFor(500);
        }

        public void AddTitleStep(string title)
        {
            SetField(titleTextBox, title);
        }

        public void AddShareDescriptionStep(string description)
        {
            SetField(shareDescriptionTextArea, description);
        }
        public void SelectCategoryStep(string category, string subCategory)
        {
            ScrollToElement(driver, categoryDropdownBtn);
            categoryDropdownBtn.Click();
            categoryDropdown.SelectByText(category);

            subCategoryDropdownBtn.Click();
            subCategoryDropdown.SelectByText(subCategory);
        }
        public void AddTags(string tag1, string tag2)
        {
            SetField(tagsTextBox, tag1);
            tagsTextBox.SendKeys(Keys.Enter);
            tagsTextBox.SendKeys(tag2);
            tagsTextBox.SendKeys(Keys.Enter);
        }
        public void SelectServiceTypeStep(string serviceType)
        {
            if (serviceType == "Hourly basis service")
            {
                serviceHourlyRadioBtn.Click();
            }
            else
                serviceOneOffRadioBtn.Click();
        }

        public void SelectLocationTypeStep(string locationType)
        {
            if (locationType == "On-site")
            {
                locationOnSiteRadioBtn.Click();
            }
            else
                locationOnlineRadioBtn.Click();
        }

        public void AvailableDaysStep(string startDate, string endDate)
        {
            SetField(startDateTextBox, startDate);
            SetField(endDateTextBox, endDate);
        }

        public void SelectSkillTradeStep(string tradeType)
        {
            if (tradeType == "Skill-exchange")
            {
                skillExchangeRadioBtn.Click();
                SetField(skillTagsTextBox, "BusinessExchange");
                skillTagsTextBox.SendKeys(Keys.Enter);
                skillTagsTextBox.SendKeys("CodingExchange");
                skillTagsTextBox.SendKeys(Keys.Enter);
            }
            else
            {
                creditRadioBtn.Click();
                SetField(creditTextBox, "5");
                Wait.WaitFor(500);
            }
        }

        public void UploadSampleWorkStep()
        {
            //click Upload samples Button
            uploadBtn.Click();
            string fileName = "worksample.pdf";
            string relativeFilePath = ConstantHelpers.GetRelativeFilePath(fileName);
        }

        public void ActiveStep(string activeType)
        {
            if (activeType == "Active")
            {
                activeRadioBtn.Click();
            }
            else
                hiddenRadioBtn.Click();
        }

        public void SaveSharePageStep()
        {
            saveBtn.Click();
            Wait.WaitFor(1000);
        }

    }

}

