using MarsQA.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefinitions
{
    [Binding]
    class LoginStepDefinitions
    {
        private IWebDriver driver;
        private SignInPage signInPage;

        public LoginStepDefinitions(IWebDriver driver) { this.driver = driver; }

        [BeforeScenario]
        public void Setup(ScenarioContext scenarioContext)
        {
            driver = scenarioContext.Get<IWebDriver>("driver");
            signInPage = new SignInPage(driver);
        }

        [Given(@"Seller logged in to the website")]
        public void GivenSellerLoggedInToTheWebsite()
        {
            signInPage.SignInStep();
        }

    }
}
