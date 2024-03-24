using Advanced_Task_1.Steps;
using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Pages.SignIn;
using AdvancedtaskSprint1.Steps;
using NUnit.Framework;


namespace AdvancedtaskSprint1.Tests
{
    [TestFixture]
    public class ShareSkillTest : BaseSetup
    {
      
        ShareSkillsSteps ShareSkillsStepsObj;
        HomePageSteps homePageStepsObj;


        public ShareSkillTest()
        {
            homePageStepsObj = new HomePageSteps();
            ShareSkillsStepsObj = new ShareSkillsSteps();
           
        }
        
        [Test, Order(1), Description("This test is adding new skill in the skill list")]
        public void DeleteexistingsSkills()
        {
        homePageStepsObj.clickManageListings();
        ShareSkillsStepsObj.DeleteExistingSkills();
        }

        [Test, Order(2), Description("This test is adding new skill in the skill list")]
        public void AddShareSkillTest()
        {
            homePageStepsObj.clickManageListings();
            ShareSkillsStepsObj.AddShareSkill();
        }
        
    }
}