using Advanced_Task_1.Steps;
using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Pages.SignIn;
using AdvancedtaskSprint1.Steps;
using AventStack.ExtentReports;
using NUnit.Framework;
using NUnit.Framework.Interfaces;


namespace AdvancedtaskSprint1.Tests
{
    [TestFixture]
    public class LanguageTest : BaseSetup
    {
        
        HomePageSteps homePageStepsObj;
        LanguageSteps languageStepObj;
        SignIn signInObj;
        Login loginPageObj;
    
        public LanguageTest()
        {
            signInObj = new SignIn();
            loginPageObj = new Login();
            homePageStepsObj = new HomePageSteps();
            languageStepObj = new LanguageSteps();
                  
        }
        

        [Test, Order(1), Description("This test is adding language in the language list")]
        public void AddLanguageandLevel()
        {
            homePageStepsObj.clickLanguagesTab();
            languageStepObj.DeleteExistingLanguages();
            languageStepObj.AddLanguage();
        }
        [Test, Order(2), Description("This test is adding more than 100 chars in the language field")]
        public void AddInvalidLanguageandLevel()
        {
            homePageStepsObj.clickLanguagesTab();
            languageStepObj.DeleteExistingLanguages();
            languageStepObj.AddInvalidLanguage();
        }
        [Test, Order(3), Description("This test is updating an existing language in the language list")]
        public void UpdateLanguageandLevel()
        {
            homePageStepsObj.clickLanguagesTab();
            languageStepObj.updateLanguage();
        }

        [Test, Order(4), Description("This test is deleting an existing language in the language list")]
        public void DeleteLanguageLevel()
        {
            homePageStepsObj.clickLanguagesTab();
            languageStepObj.deleteLanguage();
        }
       
    }
}