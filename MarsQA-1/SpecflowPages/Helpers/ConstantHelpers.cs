using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Helpers
{
    public class ConstantHelpers
    {
        //Base Url
        public static string Url = "http://localhost:5000";

        //ScreenshotPath
        public static string ScreenshotPath = "C:\\AAAindustryConnect\\internship\\onboarding.specflow\\MarsQA-1\\TestReports\\Screenshots\\";

        //ExtentReportsPath
        public static string ReportsPath = "C:\\AAAindustryConnect\\internship\\onboarding.specflow\\MarsQA-1\\TestReports\\Test_files\\";

        //ReportXML Path
        public static string ReportXMLPath = "C:\\AAAindustryConnect\\internship\\onboarding.specflow\\MarsQA-1\\TestReports\\Test_files\\";

        public static string GetRelativeFilePath(string fileName)
        {
            string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            string projectDirectory = Path.GetDirectoryName(assemblyLocation);
            string relativeFilePath = Path.Combine(projectDirectory, "Resources", fileName);

            return relativeFilePath;
        }
    }
}