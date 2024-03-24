using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Pages.SignIn;
using AdvancedtaskSprint1.Steps;
using NUnit.Framework;


namespace AdvancedtaskSprint1.Tests
{
    [TestFixture]
    public class UserProfileTest : BaseSetup
    {
       
        UserProfileSteps UserNameStepsObj;
        public UserProfileTest()
        {
           
            UserNameStepsObj = new UserProfileSteps();
        }
     
        
        [Test, Order(1), Description("Verify that user first and Last name can be updated.")]
        public void AddUserName()
        {
            UserNameStepsObj.AddUserName();
        }

        [Test, Order(2), Description("Verify that user Availability Status can be changed.")]
        public void AddAvailability()
        {
            UserNameStepsObj.AddAvailability();
        }

        [Test, Order(3), Description("Verify that user Hours Status can be changed.")]
        public void AddHours()
        {
            UserNameStepsObj.AddHours();
        }

        [Test, Order(4), Description("Verify that user $Earn Target Status can be changed.")]
        public void AddEarnTarget()
        {
            UserNameStepsObj.AddEarnTarget();
        }

      
    }
}