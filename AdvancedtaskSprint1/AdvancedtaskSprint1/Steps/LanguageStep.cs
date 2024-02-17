using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.AssertHelpers;
using AdvancedtaskSprint1.Components;
using AdvancedtaskSprint1.Test_Model;
using AdvancedtaskSprint1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AdvancedtaskSprint1.Steps
{
    public class LanguageStep : BaseSetup
    {
        LanguageComponent languageComponentObj;
        AddUpdateDeleteLanguageComponent addUpdateDeleteLanguageComponentObj;
        LanguageAssertion LanguageassertionsObj;
        public LanguageStep()
        {
            languageComponentObj = new LanguageComponent();
            addUpdateDeleteLanguageComponentObj = new AddUpdateDeleteLanguageComponent();
            LanguageassertionsObj = new LanguageAssertion();
        }


        public void AddLanguage()
        {

            List<Language> LanguageModel = LoadJson.Read<Language>("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Data\\AddLanguage.json");

            foreach (var data in LanguageModel)
            {

                languageComponentObj.clickAddLanguage();




                addUpdateDeleteLanguageComponentObj.addNewLanguage(data);
                string actualmessage = addUpdateDeleteLanguageComponentObj.GetMessageBoxText();
                Console.WriteLine(actualmessage);
                LanguageassertionsObj.AssertAddLanguageSuccessMessage(data);


            }
        }
        public void updateLanguage()
        {
            List<Language> LanguageModel = LoadJson.Read<Language>("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Data\\UpdateLanguage.json");
            foreach (var updatedata in LanguageModel)
            {
                languageComponentObj.clickUpdateLanguage();

                addUpdateDeleteLanguageComponentObj.updateLanguage(updatedata);
                string actualmessage = addUpdateDeleteLanguageComponentObj.GetMessageBoxText();
                Console.WriteLine(actualmessage);
                LanguageassertionsObj.AssertUpdateLanguageSuccessMessage(updatedata);
            }
        }
        public void deleteLanguage()
        {
            List<Language> LanguageModel = LoadJson.Read<Language>("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Data\\DeleteLanguage.json");
            foreach (var deletelanguage in LanguageModel)
            {
                
                addUpdateDeleteLanguageComponentObj.DeleteLanguage(deletelanguage);
                LanguageassertionsObj.DeleteAssertion();
            }
        }
    }
}

