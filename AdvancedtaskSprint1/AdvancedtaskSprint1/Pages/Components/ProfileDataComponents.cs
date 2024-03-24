using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Test_Model;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using AdvancedtaskSprint1.Utilities;
using AdvancedtaskSprint1.Model;


namespace AdvancedtaskSprint1.Pages.Components
{

    public class ProfileDataComponents : BaseSetup
    {
        private IWebElement AddFirstName;
        private IWebElement AddLastName;
        private IWebElement SaveButton;
        private IWebElement availabilityDropdown;
        private IWebElement availabilityHours;
        private IWebElement EarnTarget;
        private IWebElement messageWindow;

        public void renderAddComponents()
        {
            try
            {
                AddFirstName = driver.FindElement(By.Name("firstName"));
                AddLastName = driver.FindElement(By.Name("lastName"));
                SaveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));
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

        public void renderAvailability()
        {
            try
            {
                availabilityDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void renderEarnTarget()
        {
            try
            {
                EarnTarget = driver.FindElement(By.Name("availabiltyTarget"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void renderHours()
        {
            try
            {
                availabilityHours = driver.FindElement(By.Name("availabiltyHour"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void AddFirstLastName(Profiledata username)
        {
            renderAddComponents();
            AddFirstName.Clear();
            AddFirstName.SendKeys(username.firstName);
            AddLastName.Clear();
            AddLastName.SendKeys(username.lastName);
            SaveButton.Click();
           
        }
        public void AddAvailability(Profiledata availabilityupdate)
        {
            renderAvailability();
            availabilityDropdown.Click();
            availabilityDropdown.SendKeys(availabilityupdate.availability);
            availabilityDropdown.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//div[@class='ns-box-inner']", 4);
           

        }
        public void AddHours(Profiledata updatehours)
        {
            renderHours();
            availabilityHours.Click();
            availabilityHours.SendKeys(updatehours.Hours);
            availabilityHours.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//div[@class='ns-box-inner']", 4);

        }
        public void AddEarnTarget(Profiledata updatetarget)
        {
            renderEarnTarget();
            EarnTarget.Click();
            EarnTarget.SendKeys(updatetarget.EarnTarget);
            EarnTarget.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//div[@class='ns-box-inner']", 4);
        }
        public string getSuccessMessage()
        {
            //Saving error or success message
            renderAddMessage();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement messageBox = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='ns-box-inner']")));
            //get the text of the message element
            string Message = messageWindow.Text;
            return Message;
        }

      
    }
}