using NUnit.Framework;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Interactions;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework.Interfaces;
using AdvancedtaskSprint1.Pages;
using OpenQA.Selenium.Support.UI;
using System.Drawing.Imaging;
using Newtonsoft.Json;


namespace Advanced_Task_1.Utilities
{
    
    public class BaseSetup
    {
        public static IWebDriver driver;
        private ExtentReports extent;
        private ExtentTest test;

        [OneTimeSetUp]
        public void ExtentReportsSetup()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Extent Report\\"); 
            htmlReporter.Config.ReportName = "AUTOMATION STATUS REPORT";
            htmlReporter.Config.DocumentTitle = "AUTOMATION STATUS REPORT";
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Application", "Project Mars");
            extent.AddSystemInfo("Browser", "Chrome");
            extent.AddSystemInfo("OS", "Windows");
        }

        [SetUp]
        public void SetupActions()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            //test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }

        [TearDown]
        public void TearDownActions()
        {

           driver.Quit();
        }

        [OneTimeTearDown]
        public void ExtentReportsCleanup()
        {
            extent.Flush();
        }


    }
}
