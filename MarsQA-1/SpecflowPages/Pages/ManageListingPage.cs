using MarsQA.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA.SpecFlowPages.Pages
{
    [Binding]
    public class ManageListingPage : CommonDriver
    {
        private static IWebElement manageListingBtn => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/section[1]/div/a[3]"));
        private static IWebElement categoryTextBox => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[2]"));
        private static IWebElement titleTextBox => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[3]"));
        private static IWebElement descriptionTextBox => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[4]"));
        private static IWebElement serviceTypeOption => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[5]"));
        private static IWebElement skillTradeOption => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[6]"));
        private static IWebElement activeOption => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[7]/div/input"));
        private static IWebElement viewBtn => driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[1]/i"));

        public static void NavigateStep()
        {
            manageListingBtn.Click();
        }

        public static void VisibleStep()
        {

            {
                Assert.That(categoryTextBox.Text == "Business", "Category type details mismatch.");
                Assert.That(titleTextBox.Text == "Quality Finds", "Saved title details mismatch.");
                Assert.That(descriptionTextBox.Text == "Discover a world of handpicked treasures and unique finds", "Saved Description details mismatch.");
                Assert.That(serviceTypeOption.Text == "Hourly", "Saved Service type details mismatch.");
                Assert.That(activeOption.Displayed, "Active option not displayed succussfully.");

            }


        }

        public static void ViewProfileDetailsStep()
        {
            viewBtn.Click();
        }

    }
}
