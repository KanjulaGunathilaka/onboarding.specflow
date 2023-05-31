using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using BoDi;
using MarsQA.Helpers;
using NLog;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.Utils
{
    [Binding]
    public class Hooks : ExtentReportManager
    {
        private readonly IObjectContainer _container;
        private static readonly Logger Logger = LoggerManager.Logger;
        public Hooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Logger.Info($"{Environment.NewLine}==========================Running Before Test Run=========================={Environment.NewLine}");
            ExtentReportInit();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Logger.Info($"{Environment.NewLine}==========================Running After Test Run=========================={Environment.NewLine}");
            LogManager.Shutdown();
            ExtentReportTearDown();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            Logger.Info($"{Environment.NewLine}==========================Running before feature=========================={Environment.NewLine}");
            _feature = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }

        [BeforeScenario(Order = 1)]
        public void Setup(ScenarioContext scenarioContext)
        {
            CommonDriver.Initialize();
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.baseProjectPath + @"SpecflowTests\Data\Mars.xlsx", "Credentials");
            _container.RegisterInstanceAs<IWebDriver>(CommonDriver.webDriver);

            ScenarioContext.Current.Add("driver", CommonDriver.webDriver);
            _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
            Logger.Info($"{Environment.NewLine}Running before Scenario - " + scenarioContext.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void TearDown()
        {
            Logger.Info($"{Environment.NewLine}==========================Running after scenario=========================={Environment.NewLine}");
            var driver = _container.Resolve<IWebDriver>();
            CommonDriver.CloseDriver();
        }

        [AfterStep]
        public void AfterStep(ScenarioContext scenarioContext)
        {
            string stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            string stepName = scenarioContext.StepContext.StepInfo.Text;

            var driver = _container.Resolve<IWebDriver>();
            var stepNode = CreateStepNode(stepType, stepName);

            if (scenarioContext.TestError != null)
            {
                stepNode.Fail(scenarioContext.TestError.Message,
                    MediaEntityBuilder.CreateScreenCaptureFromPath(CommonMethods.AddScreenshot(driver, scenarioContext)).Build());
            }
            else
            {
                stepNode.Pass(stepName);
            }
        }

        private ExtentTest CreateStepNode(string stepType, string stepName)
        {
            switch (stepType)
            {
                case "Given":
                    return _scenario.CreateNode<Given>(stepName);
                case "When":
                    return _scenario.CreateNode<When>(stepName);
                case "Then":
                    return _scenario.CreateNode<Then>(stepName);
                case "And":
                    return _scenario.CreateNode<And>(stepName);
                default:
                    throw new NotSupportedException($"Step type '{stepType}' is not supported.");
            }
        }

    }
}
