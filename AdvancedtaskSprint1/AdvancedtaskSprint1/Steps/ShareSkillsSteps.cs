using Advanced_Task_1.Steps;
using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.AssertHelpers;
using AdvancedtaskSprint1.Pages.Components;
using AdvancedtaskSprint1.Test_Model;
using AdvancedtaskSprint1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace AdvancedtaskSprint1.Steps
{
    public class ShareSkillsSteps : BaseSetup
    {
        
        HomePageSteps HomePageStepsObj;
        ShareSkillComponent ShareSkillComponentObj;
        ShareSkillAssertions ShareSkillAssertionsObj;

        public ShareSkillsSteps()
        {
            ShareSkillComponentObj = new ShareSkillComponent();
            HomePageStepsObj = new HomePageSteps();
            ShareSkillAssertionsObj = new ShareSkillAssertions();
        }
               
        public void DeleteExistingSkills()
        {


            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                while (true)
                {
                    var deleteButtons = driver.FindElements(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody[last()]/tr/td[8]/div/button[3]/i"));


                    if (deleteButtons.Count == 0)
                    {
                        break;
                    }
                    foreach (var button in deleteButtons)
                    {
                        try
                        {
                            wait.Until(ExpectedConditions.ElementToBeClickable(button)).Click();
                            Thread.Sleep(5000);
                            var yesButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
                            yesButton.Click();
                            Thread.Sleep(5000);
                        }
                        catch (StaleElementReferenceException)
                        {
                            // Handle the exception by re-checking the element 
                        }
                    }
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("No items to delete");
            }

        } 
        public void AddShareSkill()
        {
            List<ShareSkillModel> ShareSkillModel = LoadJson.Read<ShareSkillModel>("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Data\\AddShareSkill.json");
            foreach (var addShareSkill in ShareSkillModel)
            {
                HomePageStepsObj.clickShareSkill();
                ShareSkillComponentObj.AddSkill(addShareSkill);
                ShareSkillAssertionsObj.AssertShareSkill(addShareSkill);
            }
        }
        

    }
}