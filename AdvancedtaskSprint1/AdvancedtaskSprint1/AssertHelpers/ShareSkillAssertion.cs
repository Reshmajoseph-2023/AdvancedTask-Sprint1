using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Test_Model;
using NUnit.Framework;
using OpenQA.Selenium;


namespace AdvancedtaskSprint1.AssertHelpers
{

    public class ShareSkillAssertions : BaseSetup
    {
        public void AssertShareSkill(ShareSkillModel addShareSkill)
        {
            IWebElement SkillTitle = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
            string actualTitle = SkillTitle.Text;
            string expectedTitle = addShareSkill.title;
            Assert.That(actualTitle== expectedTitle, "Actual skill and expected skill do not match ");
            Console.WriteLine(actualTitle  +  "  has been added sucessfully");
        }
       
    }
}




