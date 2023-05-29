using MarsQA.Helpers;
using MarsQA.Pages;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA.Helpers.CommonMethods;

namespace MarsQA.Utils
{
    [Binding]
    public class Start : CommonDriver
    {
        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.baseProjectPath + @"SpecflowTests\Data\Mars.xlsx", "Credentials");
            //call the SignInPage class
            //SignInPage.SignInStep();
        }

        [AfterScenario]
        public void TearDown()
        {
            // Screenshot
            // string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            //test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));
            //Close the browser
            CloseDriver();

            //Extent.EndTest(test);
            //Extent.Flush();
        }
    }
}
