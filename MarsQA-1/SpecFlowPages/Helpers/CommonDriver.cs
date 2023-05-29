using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace MarsQA.Helpers
{
    public class CommonDriver
    {
        public static IWebDriver driver { get; set; }

        public static void Initialize()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static string BaseUrl => ConstantHelpers.baseUrl;

        public static IWebDriver Instance => driver;

        public static void NavigateToUrl()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        public static void CloseDriver()
        {
            try
            {
                driver?.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while closing the driver: {ex.Message}");
            }
            finally
            {
                driver = null;
            }
        }

    }
}
