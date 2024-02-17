using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Components;
using AdvancedtaskSprint1.Test_Model;
using AdvancedtaskSprint1.Utilities;
using AngleSharp.Dom;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;



namespace AdvancedtaskSprint1.AssertHelpers
{

    public class LanguageAssertion: BaseSetup
    {
        AddUpdateDeleteLanguageComponent addUpdateDeleteLanguageComponentObj;
        public LanguageAssertion()
        {
            addUpdateDeleteLanguageComponentObj = new AddUpdateDeleteLanguageComponent();
        }
        public void AssertAddLanguageSuccessMessage(Language data)
        {
            string actualmessage = addUpdateDeleteLanguageComponentObj.GetMessageBoxText();
            List<Language> LanguageModel = LoadJson.Read<Language>("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Data\\AddLanguage.json");
            string expectedMessage1 = data.language + " has been added to your languages";
            string expectedMessage2 = "This language is already exist in your language list.";
            string expectedMessage3 = "Please enter language and level";
            string expectedMessage4 = "Duplicated data";
            Assert.That(actualmessage, Is.EqualTo(expectedMessage1).Or.EqualTo(expectedMessage2).Or.EqualTo(expectedMessage3).Or.EqualTo(expectedMessage4), "succes message is correct for add language"); 
        }
        public void AssertUpdateLanguageSuccessMessage(Language updatedata)
        {
            string actualmessage = addUpdateDeleteLanguageComponentObj.GetMessageBoxText();
            List<Language> LanguageModel = LoadJson.Read<Language>("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Data\\UpdateLanguage.json");
            string expectedMessage1 = updatedata.language + " has been updated to your languages"; 
            string expectedMessage2 = "This language is already added to your language list.";
            string expectedMessage3 = "Please enter language and level";
            Assert.That(actualmessage, Is.EqualTo(expectedMessage1).Or.EqualTo(expectedMessage2).Or.EqualTo(expectedMessage3), "succes message is correct for update language");
        }
        public void DeleteAssertion()
        {
            string actualmessage = addUpdateDeleteLanguageComponentObj.GetMessageBoxText();
            Console.WriteLine(actualmessage);
            
        }


    }
}
