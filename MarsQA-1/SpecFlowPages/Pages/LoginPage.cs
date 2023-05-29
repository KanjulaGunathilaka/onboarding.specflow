using MarsQA.Pages;
using TechTalk.SpecFlow;

namespace MarsQA.Feature
{
    [Binding]
    class LoginPage
    {
        [Given(@"Seller logged in to the website")]
        public static void GivenSellerLoggedInToTheWebsite()
        {
            SignInPage.SignInStep();
        }

    }
}
