using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Model;
using AdvancedtaskSprint1.Pages.Components;
using AdvancedtaskSprint1.Test_Model;
using NUnit.Framework;
using OpenQA.Selenium;


namespace AdvancedtaskSprint1.AssertHelpers
{
    public class ProfileDataAssertion : BaseSetup
    {
        ProfileDataComponents UserNameComponentsObj;

        public  ProfileDataAssertion()
        {
            UserNameComponentsObj=new ProfileDataComponents();
        }
        public void FirstNameAssertion(Profiledata username)
        {
            IWebElement FirstName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span")); 
            string actualFirstName = FirstName.Text;
            Assert.That(actualFirstName== username.ExpectedName ,"Actual and expected name does not match");
            Console.WriteLine(actualFirstName);
        }
        public void AvailabilityAssertion(Profiledata availability)
        {
            string actualmessage = UserNameComponentsObj.getSuccessMessage();
            Assert.That(actualmessage == availability.ExpectedMessage, "Actual message and expected message do not match");
        }
        public void HoursAssertion(Profiledata hours)
        {
            string actualmessage = UserNameComponentsObj.getSuccessMessage();
            Assert.That(actualmessage == hours.ExpectedMessage, "Actual message and expected message do not match");
        }
        public void EarnTargetAssertion(Profiledata target)
        {
            string actualmessage = UserNameComponentsObj.getSuccessMessage();
            Assert.That(actualmessage == target.ExpectedMessage, "Actual message and expected message do not match");
        }
    }
}