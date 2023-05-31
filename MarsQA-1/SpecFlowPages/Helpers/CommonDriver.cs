using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace MarsQA.Helpers
{
    public class CommonDriver
    {
        public static IWebDriver webDriver { get; set; }

        public static void Initialize()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            webDriver = new ChromeDriver(options);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static string BaseUrl => ConstantHelpers.baseUrl;

        public static IWebDriver Instance => webDriver;

        public static void NavigateToUrl()
        {
            webDriver.Navigate().GoToUrl(BaseUrl);
        }

        public static void CloseDriver()
        {
            try
            {
                webDriver?.Quit();
                webDriver.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while closing the driver: {ex.Message}");
            }
            finally
            {
                webDriver = null;
            }
        }

    }
}
