using Advanced_Task_1.TestModel;
using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Pages.Components;
using NUnit.Framework;
namespace Advanced_Task_1.AssertHelpers
{
    public class SkillAssertions : BaseSetup
    {
        AddUpdateDeleteSkillsComponent AddUpdateDeleteSkillComponentObj;

        public SkillAssertions() 
        {
            AddUpdateDeleteSkillComponentObj = new AddUpdateDeleteSkillsComponent();
        }
        public void AssertAddSkill(Skill data)
        {
            string actualmessage = AddUpdateDeleteSkillComponentObj.getSuccessMessage();
            Assert.That(actualmessage == data.ExpectedMessage, "Actual and expected message do not match");
        }

        public void AsserUpdateSkill(Skill updatedata)
        {
        string actualmessage = AddUpdateDeleteSkillComponentObj.getSuccessMessage();
        Assert.That(actualmessage == updatedata.ExpectedMessage, "Actual and expected message do not match");
        }

        public string DeleteSkillAssertion()
        {
            string actualmessage = AddUpdateDeleteSkillComponentObj.getSuccessMessage();
            return actualmessage;
        }

    }
    }


   
