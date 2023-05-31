using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using BoDi;
using MarsQA.Helpers;
using MarsQA.Pages;
using OpenQA.Selenium;
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
    public class Start : ExtentReport
    {
        private readonly IObjectContainer _container;
        public Start(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Console.WriteLine("Running before test run...");
            ExtentReportInit();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Console.WriteLine("Running after test run...");
            ExtentReportTearDown();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            Console.WriteLine("Running before feature...");
            _feature = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("Running after feature...");
        }

        [BeforeScenario(Order = 1)]
        public void Setup(ScenarioContext scenarioContext)
        {
            //launch the browser
            CommonDriver.Initialize();
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.baseProjectPath + @"SpecflowTests\Data\Mars.xlsx", "Credentials");
            _container.RegisterInstanceAs<IWebDriver>(CommonDriver.webDriver);

            ScenarioContext.Current.Add("driver", CommonDriver.webDriver);
            _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);

            string scenarioName = ScenarioContext.Current.ScenarioInfo.Title;
            CreateTest(scenarioName);
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
            Console.WriteLine("Running after scenario...");
            var driver = _container.Resolve<IWebDriver>();
            CommonDriver.CloseDriver();
        }

        [AfterStep]
        public void AfterStep(ScenarioContext scenarioContext)
        {
            Console.WriteLine("Running after step....");
            string stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            string stepName = scenarioContext.StepContext.StepInfo.Text;

            var driver = _container.Resolve<IWebDriver>();

            //When scenario passed
            if (scenarioContext.TestError == null)
            {
                if (stepType == "Given")
                {
                    _scenario.CreateNode<Given>(stepName);
                    LogTestStep(Status.Info, stepName);
                }
                else if (stepType == "When")
                {
                    _scenario.CreateNode<When>(stepName);
                    LogTestStep(Status.Info, stepName);

                }
                else if (stepType == "Then")
                {
                    _scenario.CreateNode<Then>(stepName);
                    LogTestStep(Status.Info, stepName);

                }
                else if (stepType == "And")
                {
                    _scenario.CreateNode<And>(stepName);
                    LogTestStep(Status.Info, stepName);

                }
            }

            //When scenario fails
            if (scenarioContext.TestError != null)
            {

                if (stepType == "Given")
                {
                    _scenario.CreateNode<Given>(stepName).Fail(scenarioContext.TestError.Message,
                        MediaEntityBuilder.CreateScreenCaptureFromPath(addScreenshot(driver, scenarioContext)).Build());
                }
                else if (stepType == "When")
                {
                    _scenario.CreateNode<When>(stepName).Fail(scenarioContext.TestError.Message,
                        MediaEntityBuilder.CreateScreenCaptureFromPath(addScreenshot(driver, scenarioContext)).Build());
                }
                else if (stepType == "Then")
                {
                    _scenario.CreateNode<Then>(stepName).Fail(scenarioContext.TestError.Message,
                        MediaEntityBuilder.CreateScreenCaptureFromPath(addScreenshot(driver, scenarioContext)).Build());
                }
                else if (stepType == "And")
                {
                    _scenario.CreateNode<And>(stepName).Fail(scenarioContext.TestError.Message,
                        MediaEntityBuilder.CreateScreenCaptureFromPath(addScreenshot(driver, scenarioContext)).Build());
                }
            }
        }
    }
}
