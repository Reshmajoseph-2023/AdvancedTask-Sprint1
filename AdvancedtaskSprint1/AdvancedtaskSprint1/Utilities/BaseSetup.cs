using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework.Interfaces;
using System.Drawing.Imaging;
using AdvancedtaskSprint1.Pages.SignIn;

namespace Advanced_Task_1.Utilities
{

    public class BaseSetup
    {
        public static IWebDriver driver;
        private ExtentReports extent;
        private ExtentTest test;
        private string errorMessage;


        [OneTimeSetUp]
        public void ExtentReportsSetup()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Extent Report\\");
            extent.AttachReporter(htmlReporter);
            htmlReporter.Config.ReportName = "AUTOMATION STATUS REPORT";
            htmlReporter.Config.DocumentTitle = "AUTOMATION STATUS REPORT";
            extent.AddSystemInfo("Application", "Project Mars");
            extent.AddSystemInfo("Browser", "Chrome");
            extent.AddSystemInfo("OS", "Windows");
            // Get test name using TestContext
            string testName = TestContext.CurrentContext.Test.FullName;
            test = extent.CreateTest(testName);
        }
        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            SignIn signInObj = new SignIn();
            Login loginPageObj = new Login();
            signInObj.ClickSignIn();
            loginPageObj.LoginSteps();
            test = extent.CreateTest(TestContext.CurrentContext.Test.FullName);
        }
       
        [TearDown]
        public void TearDownActions()
        {

            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed)
            {
                // Capture screenshot when test passes
                CaptureScreenshot(TestContext.CurrentContext.Test.Name + "_Pass");
                test.Log(Status.Pass, "Test Passed");
            }

            else
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {

                // Capture screenshot when test fail
                CaptureScreenshot(TestContext.CurrentContext.Test.Name + "_Failed");
                errorMessage = TestContext.CurrentContext.Result.Message;
                //Log status and error message into extent reports
                test.Log(Status.Fail, "Test Failed");
                test.Log(Status.Fail, errorMessage);
                //Display error message in console
                TestContext.Error.WriteLine("Test failed: " + errorMessage);

            }
            driver.Quit();
        }

        [OneTimeTearDown]
        public void ExtentReportsClose()
        {
            extent.Flush();
        }
        public void CaptureScreenshot(string ScreenShotFileName)
        {
            //To take screenshot
            ITakesScreenshot screenshotDriver = (ITakesScreenshot)driver;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            string screenshotTitle = Path.Combine($"{ScreenShotFileName}" + DateTime.Now.ToString("_yyyy_MM_dd_HH_mm_ss"));
            string screenshotFolderLocation = Path.Combine(@"C:\Users\reshm\source\repos\second\AdvancedtaskSprint1\AdvancedtaskSprint1\Screenshots", screenshotTitle);
            //To save screenshot
            screenshot.SaveAsFile(screenshotFolderLocation + ImageFormat.Png);

        }
    }
}
