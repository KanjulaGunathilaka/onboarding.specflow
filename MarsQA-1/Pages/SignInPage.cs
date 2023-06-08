using MarsQA.Helpers;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MarsQA.Pages
{
    [Binding]
    public class SignInPage : CommonDriver
    {
        private IWebDriver driver;

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement SignInBtn => driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
        private IWebElement Email => driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
        private IWebElement Password => driver.FindElement(By.XPath("//INPUT[@type='password']"));
        private IWebElement LoginBtn => driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));

        public void SignInStep()
        {
            NavigateToUrl();
            SignInBtn.Click();
            Email.SendKeys(ExcelLibHelper.ReadData(2, "username"));
            Password.SendKeys(ExcelLibHelper.ReadData(2, "password"));
            LoginBtn.Click();
        }

        public void Login()
        {
            NavigateToUrl();
            driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();
            driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys("");
            driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys("");
            driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();
        }
    }
}