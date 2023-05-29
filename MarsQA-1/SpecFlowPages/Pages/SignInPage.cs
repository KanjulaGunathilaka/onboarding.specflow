using MarsQA.Helpers;
using OpenQA.Selenium;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA.Pages
{
    [Binding]
    public class SignInPage : CommonDriver
    {

        private static IWebElement SignInBtn => driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
        private static IWebElement Email => driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
        private static IWebElement Password => driver.FindElement(By.XPath("//INPUT[@type='password']"));
        private static IWebElement LoginBtn => driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));

        public static void SignInStep()
        {
            NavigateToUrl();
            SignInBtn.Click();
            Email.SendKeys(ExcelLibHelper.ReadData(2, "username"));
            Password.SendKeys(ExcelLibHelper.ReadData(2, "password"));
            LoginBtn.Click();
        }

        public static void Login()
        {
            NavigateToUrl();
            //Enter Url
            driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();
            //Enter Username
            driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys("");
            //Enter password
            driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys("");
            //Click on Login Button
            driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();
        }
    }
}