using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace MarsQA.Helpers
{
    public class CommonMethods
    {
        //Screenshots
        //Screenshot

        public class SaveScreenShotClass
        {
            
            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
            {
                var folderLocation = (ConstantHelpers.ScreenshotPath);

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
                //fileName.Append(DateTime.Now.ToString("dd-mm-yyyym_ss"));
                fileName.Append(".jpeg");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
                return fileName.ToString();
            }

        }

        public static void ScrollToElement(IWebDriver driver, IWebElement element)
        {
            var actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }

        public static void SetField(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        public string CheckGivenFieldIsDisplayed(IWebElement element, string message)
        {
            try
            {
                if (element.Displayed)
                {
                    return message + " is displayed";
                }
                else
                {
                    return message + " is NOT displayed";
                }
            }
            catch (NoSuchElementException)
            {
                return message + " is NOT displayed";
            }
        }


    }
}


