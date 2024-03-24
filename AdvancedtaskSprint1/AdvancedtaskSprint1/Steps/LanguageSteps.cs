using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.AssertHelpers;
using AdvancedtaskSprint1.Test_Model;
using AdvancedtaskSprint1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AventStack.ExtentReports;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;
using System.Drawing.Imaging;
using AdvancedtaskSprint1.Pages.Components;

namespace AdvancedtaskSprint1.Steps
{
    public class LanguageSteps : BaseSetup
    {
        public static ExtentTest test;
       // public static ExtentReports extent;

        LanguageComponent languageComponentObj;
        AddUpdateDeleteLanguageComponent addUpdateDeleteLanguageComponentObj;
        LanguageAssertion LanguageassertionsObj;
        public LanguageSteps()
        {
            languageComponentObj = new LanguageComponent();
            addUpdateDeleteLanguageComponentObj = new AddUpdateDeleteLanguageComponent();
            LanguageassertionsObj = new LanguageAssertion();
        }

        public void DeleteExistingLanguages()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                while (true)
                {
                    var deleteButtons = driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
                 

                    if (deleteButtons.Count == 0)
                    {
                        break;
                    }
                    foreach (var button in deleteButtons)
                    {
                        try
                        {
                            wait.Until(ExpectedConditions.ElementToBeClickable(button)).Click();
                            Thread.Sleep(5000);
                        }
                        catch (StaleElementReferenceException)
                        {
                            // Handle the exception by re-checking the element 
                        }
                    }
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("No items to delete");
            }

        }
        public void AddLanguage()
        {

            List<Language> LanguageModel = LoadJson.Read<Language>("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Data\\AddLanguage.json");

            foreach (var data in LanguageModel)
            {

                languageComponentObj.clickAddLanguage();
                addUpdateDeleteLanguageComponentObj.addNewLanguage(data);
                string actualmessage = addUpdateDeleteLanguageComponentObj.getSuccessMessage();
                Console.WriteLine(actualmessage);
                LanguageassertionsObj.AssertAddLanguageSuccessMessage(data);
                
            }
        }
                   
         public void AddInvalidLanguage()
         {
            
            List<Language> LanguageModel = LoadJson.Read<Language>("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Data\\100charsLanguage.json");

            foreach (var data in LanguageModel)
            {

                languageComponentObj.clickAddLanguage();
                addUpdateDeleteLanguageComponentObj.addNewLanguage(data);
                string actualmessage = addUpdateDeleteLanguageComponentObj.getSuccessMessage();
                Console.WriteLine(actualmessage);
                
                int l = data.language.Length;
                    
                if (l >= 100)
                {
                        Assert.Fail("More than 100 chars are not allowed");
                    
                }
                                
            }
            
         }
        
        public void updateLanguage()
        {
           
            List<Language> LanguageModel = LoadJson.Read<Language>("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Data\\UpdateLanguage.json");
            foreach (var updatedata in LanguageModel)
            {
                languageComponentObj.clickUpdateLanguage();
                addUpdateDeleteLanguageComponentObj.updateLanguage(updatedata);
                string actualmessage = addUpdateDeleteLanguageComponentObj.getSuccessMessage();
                Console.WriteLine(actualmessage);
                LanguageassertionsObj.AssertUpdateLanguageSuccessMessage(updatedata);
               
            }
        }
        public void deleteLanguage()
        {
            //test = extent.CreateTest("Delete_Language_Test").Info("Test2 Started- Delete Language ");
            List<Language> LanguageModel = LoadJson.Read<Language>("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Data\\DeleteLanguage.json");
            foreach (var deletelanguage in LanguageModel)
            {
                
                addUpdateDeleteLanguageComponentObj.DeleteLanguage(deletelanguage);
                LanguageassertionsObj.DeleteAssertion();
               
            }
        }
    }
}

