using MarsQA.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA.Pages
{
    [Binding]
    public class ManageListingPage : CommonDriver
    {
        private IWebDriver driver;
        public ManageListingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private static IWebElement manageListingBtn => webDriver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/section[1]/div/a[3]"));
        private static IWebElement categoryTextBox => webDriver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[2]"));
        private static IWebElement titleTextBox => webDriver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[3]"));
        private static IWebElement descriptionTextBox => webDriver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[4]"));
        private static IWebElement serviceTypeOption => webDriver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[5]"));
        private static IWebElement skillTradeOption => webDriver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[6]"));
        private static IWebElement activeOption => webDriver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[7]/div/input"));
        private static IWebElement viewBtn => webDriver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[1]/i"));

        public void NavigateStep()
        {
            manageListingBtn.Click();
        }

        public void VisibleStep()
        {

            {
                Assert.That(categoryTextBox.Text == "Business", "Category type details mismatch.");
                Assert.That(titleTextBox.Text == "Quality Finds", "Saved title details mismatch.");
                Assert.That(descriptionTextBox.Text == "Discover a world of handpicked treasures and unique finds", "Saved Description details mismatch.");
                Assert.That(serviceTypeOption.Text == "Hourly", "Saved Service type details mismatch.");
                Assert.That(activeOption.Displayed, "Active option not displayed succussfully.");

            }


        }

        public void ViewProfileDetailsStep()
        {
            viewBtn.Click();
        }

    }
}
