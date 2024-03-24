using Advanced_Task_1.AssertHelpers;
using Advanced_Task_1.TestModel;
using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Pages.Components;
using AdvancedtaskSprint1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;


namespace Advanced_Task_1.Steps
{
    public class SkillSteps : BaseSetup
    {
        SkillComponent skillComponentObj;
        AddUpdateDeleteSkillsComponent addUpdateDeleteSkillComponentObj;
        SkillAssertions SkillAssertionsObj;
        public SkillSteps()
        {
           
            skillComponentObj = new SkillComponent();
            addUpdateDeleteSkillComponentObj = new AddUpdateDeleteSkillsComponent();
            SkillAssertionsObj = new SkillAssertions();
        }

        public void DeleteExistingSkills()
        {

            try
            {

                var deleteButtons = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
                foreach (var button in deleteButtons)
                {
                    button.Click();
                }

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("no items to delete");
            }
        }
        public void AddSkill()
        {
           
            List<Skill> SkillModel = LoadJson.Read<Skill>("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Data\\AddSkill.json");
            foreach (Skill data in SkillModel)
            {
                skillComponentObj.clickAddSkill();
                addUpdateDeleteSkillComponentObj.AddSkills(data);
                Thread.Sleep(2000);
                string actualmessage = addUpdateDeleteSkillComponentObj.getSuccessMessage();
                Console.WriteLine(actualmessage);

                SkillAssertionsObj.AssertAddSkill(data);
            }
        }
        public void AddInvalidSkill()
        {

            List<Skill> SkillModel = LoadJson.Read<Skill>("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Data\\AddSkill.json");
            foreach (Skill data in SkillModel)
            {
                skillComponentObj.clickAddSkill();
                addUpdateDeleteSkillComponentObj.AddSkills(data);
                Thread.Sleep(2000);
                string actualmessage = addUpdateDeleteSkillComponentObj.getSuccessMessage();
                Console.WriteLine(actualmessage);
                int l = data.skill.Length;

                if (l >= 100)
                {
                    Assert.Fail("More than 100 chars are not allowed");

                }


            }
        }

        public void UpdateSkill()
        {

            List<Skill> SkillModel= LoadJson.Read<Skill>("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Data\\UpdateSkill.json");
            foreach (Skill updatedata in SkillModel)
            {
                skillComponentObj.clickUpdateSkill();
                addUpdateDeleteSkillComponentObj.UpdateSkills(updatedata);
                string actualmessage = addUpdateDeleteSkillComponentObj.getSuccessMessage();
                Console.WriteLine(actualmessage);
                SkillAssertionsObj.AsserUpdateSkill(updatedata);
            }
        }
        public void DeleteSkill()
        {
            List<Skill> SkillModel = LoadJson.Read<Skill>("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Data\\DeleteSkill.json");
            foreach (Skill skilldata in SkillModel)
            {
                addUpdateDeleteSkillComponentObj.deleteSkill(skilldata);
                string actualmessage = addUpdateDeleteSkillComponentObj.getSuccessMessage();
                Console.WriteLine(actualmessage);
                SkillAssertionsObj.DeleteSkillAssertion();
            }
        }
    }
}
