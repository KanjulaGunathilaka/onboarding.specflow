using System.IO;
using System.Reflection;

namespace MarsQA.Helpers
{
    public class ConstantHelpers
    {
        //Base Url
        public static string baseUrl = "http://localhost:5000";
        //Base Project Path
        public static string baseProjectPath = @"C:\AAAindustryConnect\internship\onboarding.specflow\MarsQA-1\";
        //ScreenshotPath
        public static string ScreenshotPath = baseProjectPath + @"TestReports\Screenshots\";
        //ExtentReportsPath
        public static string ReportsPath = baseProjectPath + @"TestReports\Test_files\";
        //ReportXML Path
        public static string ReportXMLPath = baseProjectPath + @"TestReports\Test_files\";

        public static string GetRelativeFilePath(string fileName)
        {
            string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            string projectDirectory = Path.GetDirectoryName(assemblyLocation);
            string relativeFilePath = Path.Combine(projectDirectory, "Resources", fileName);

            return relativeFilePath;
        }
    }
}