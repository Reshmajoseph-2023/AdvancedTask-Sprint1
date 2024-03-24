using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Pages.SignIn;
using AdvancedtaskSprint1.Steps;
using NUnit.Framework;


namespace AdvancedtaskSprint1.Tests
{
    [TestFixture]
    public class SearchSkillTest : BaseSetup
    {
        SignIn signInObj;
        Login loginPageObj;
        SearchSkillSteps SearchSkillsStepsObj;
       
        public SearchSkillTest()
        {
           SearchSkillsStepsObj = new SearchSkillSteps();

        }
    
        [Test, Order(1), Description("Verify user able to search skills by category and sub category")]
        public void TestSearchCategory()
        {
            SearchSkillsStepsObj.SearchSkillsByCategory();
        }

        [Test, Order(2), Description("Verify user able to search skills by using filter option")]
        public void TestSearchFilter()
        {
             SearchSkillsStepsObj.SearchByFilter();
        }
        [Test, Order(3), Description("Verify user able to search by skill")]
        public void TestVerifySearchSkill()
        {
            SearchSkillsStepsObj.SearchBySkills();
        }
        
    }
}