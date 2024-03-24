using Advanced_Task_1.AssertHelpers;
using Advanced_Task_1.Steps;
using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Pages.SignIn;
using NUnit.Framework;


namespace Advanced_Task_1.Tests
{
    [TestFixture]
    public class SkillsTest : BaseSetup
    {
        SignIn signInObj;
        Login loginPageObj;
        HomePageSteps homePageStepsObj;
        SkillSteps skillStepObj;
      
        public SkillsTest()
        {
          
            homePageStepsObj = new HomePageSteps();
            skillStepObj = new SkillSteps();        
        }
       

        
        [Test, Order(1), Description("This test is adding skill in the skill list")]
        public void AddSkillTest()
        {

            homePageStepsObj.clickSkillsTab();
            skillStepObj.DeleteExistingSkills();
            skillStepObj.AddSkill();
        }
        [Test, Order(2), Description("This test is adding more than 100 chars in the skill field")]
        public void AddMorethan100charsSkillTest()
        {

            homePageStepsObj.clickSkillsTab();
            skillStepObj.DeleteExistingSkills();
            skillStepObj.AddInvalidSkill();
        }

        [Test, Order(3), Description("This test is updating an existing skill in the skill list")]
        public void UpdateSkillTest()
        {

            homePageStepsObj.clickSkillsTab();
            skillStepObj.UpdateSkill();
        }

        [Test, Order(4), Description("This test is deleting an existing skill in the skill list")]
        public void DeleteSkillTest()
        {

            homePageStepsObj.clickSkillsTab();
            skillStepObj.DeleteSkill();
        }
    
       
    }
}