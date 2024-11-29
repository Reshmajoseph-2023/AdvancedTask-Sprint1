using Advanced_Task_1.TestModel;
using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Utilities;
using OpenQA.Selenium;



namespace AdvancedtaskSprint1.Pages.Components
{
    public class AddUpdateDeleteSkillsComponent : BaseSetup
    {
        private IWebElement AddSkillTextBox;
        private IWebElement ChooseSkillLevel;
        private IWebElement AddButton;
        private IWebElement messageWindow;
        private IWebElement UpdateSkill;
        private IWebElement UpdateSkillLevel;
        private IWebElement UpdateButton;
        private IWebElement ElementToDelete;
        private IWebElement deletebutton;
        public void renderAddComponents()
        {
            try
            {
                AddSkillTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
                ChooseSkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
                AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderupdateComponents()
        {
            try
            {
                UpdateSkill = driver.FindElement(By.Name("name"));
                UpdateSkillLevel = driver.FindElement(By.Name("level"));
                UpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderDeleteComponents()
        {
            try
            {
                ElementToDelete = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
                deletebutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderAddMessage()
        {
            try
            {
                messageWindow = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void AddSkills(Skill data)
        {
            renderAddComponents();
            //Enter the skills
            AddSkillTextBox.SendKeys(data.skill);
            //Choose the skill level
            ChooseSkillLevel.Click();
            ChooseSkillLevel.SendKeys(data.skillLevel);
            //Click on Add button
            AddButton.Click();
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 4);
        }

        public void UpdateSkills(Skill updatedata)
        {
            renderupdateComponents();
            UpdateSkill.SendKeys(Keys.Control + "A");
            UpdateSkill.SendKeys(Keys.Backspace);
            //Click and update skill text box
            UpdateSkill.SendKeys(updatedata.skill);
            //Choose the skill level from the drop down
            UpdateSkillLevel.Click();
            UpdateSkillLevel.SendKeys(updatedata.skillLevel);
            //Click on update button
            UpdateButton.Click();
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 4);

        }
        public void deleteSkill(Skill deleteSkill)
        {

            renderDeleteComponents();
            Thread.Sleep(2000);
            try
            {

                if (ElementToDelete.Text == deleteSkill.skill)
                {

                    deletebutton.Click();
                    Thread.Sleep(3000);
                }
            }
            catch (NoSuchElementException)
            {

                Console.WriteLine("Element to delete not found");
            }

        }
        public string getSuccessMessage()
        {
            //Saving error or success message
            renderAddMessage();
            //get the text of the message element
            string Message = messageWindow.Text;
            return Message;
        }
    }
}