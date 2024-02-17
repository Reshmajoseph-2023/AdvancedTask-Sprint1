using Advanced_Task_1.Steps;
using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Pages;
using AdvancedtaskSprint1.Steps;

using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel;
using OpenQA.Selenium.Chrome;
using AdvancedtaskSprint1.Utilities;

namespace AdvancedtaskSprint1.Tests
{
    [TestFixture]
    public class LanguageTest : BaseSetup
    {
      
        LoginPage loginPageObj;
        HomePageSteps homePageStepsObj;
        LanguageStep languageStepObj;
        ActualState ActualStateObj;
        public LanguageTest()
        {
           
            loginPageObj = new LoginPage();
            homePageStepsObj = new HomePageSteps();
            languageStepObj = new LanguageStep();
            ActualStateObj = new ActualState();
        }
     
        [Test, Order(1)]
        public void AddLanguageandLevel()
        {
            
            loginPageObj.LoginSteps();
            homePageStepsObj.clickLanguagesTab();
            ActualStateObj.TableState();
            languageStepObj.AddLanguage();
        }
        [Test, Order(2)]
        public void UpdateLanguageandLevel()
        {
           
            loginPageObj.LoginSteps();
            homePageStepsObj.clickLanguagesTab();
            ActualStateObj.TableState();
            languageStepObj.AddLanguage();
            languageStepObj.updateLanguage();
        }

        [Test, Order(3)]
        public void DeleteLanguageLevel()
        {
            
            loginPageObj.LoginSteps();
            homePageStepsObj.clickLanguagesTab();
            ActualStateObj.TableState();
            languageStepObj.AddLanguage();
            languageStepObj.deleteLanguage();
        }
        
    }
}