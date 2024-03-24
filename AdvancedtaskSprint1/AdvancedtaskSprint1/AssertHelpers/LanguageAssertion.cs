using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Pages.Components;
using AdvancedtaskSprint1.Test_Model;
using NUnit.Framework;

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
            string actualmessage = addUpdateDeleteLanguageComponentObj.getSuccessMessage();
            Assert.That(actualmessage==data.ExpectedMessage, "Actual and expected message do not match");
            
        }
        public void AssertUpdateLanguageSuccessMessage(Language updatedata)
        {
            string actualmessage = addUpdateDeleteLanguageComponentObj.getSuccessMessage();
            Assert.That(actualmessage == updatedata.ExpectedMessage, "Actual and expected message do not match");
        }
        public void DeleteAssertion()
        {
            string actualmessage = addUpdateDeleteLanguageComponentObj.getSuccessMessage();
            Console.WriteLine(actualmessage);
            
        }
    }
}
