using MarsQA_1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    class Login
    {
        [Given(@"Seller logged in to the website")]
        public static void GivenSellerLogggedInToTheWebsite()
        {
            SignIn.SigninStep();
        }

    }
}
