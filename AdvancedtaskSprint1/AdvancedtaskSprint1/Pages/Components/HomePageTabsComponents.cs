using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Utilities;
using OpenQA.Selenium;


namespace AdvancedtaskSprint1.Pages.Components
{
    public class HomePageTabsComponents : BaseSetup
    {

        private IWebElement languagesTab;
        private IWebElement skillsTab;
        private IWebElement clickOnDashboard;
        private IWebElement clickNotificationMenu;
        private IWebElement shareSkillButton;
        private IWebElement UpdateshareSkillIcon;
        private IWebElement userNameButton;
        private IWebElement availabilityPencilIcon;
        private IWebElement HoursPencilIcon;
        private IWebElement earnTargetPencilIcon;
        private IWebElement clickSearchIcon;
        private IWebElement ClickonManageListings;
        public void renderComponents()
        {
            try
            {
                languagesTab = driver.FindElement(By.XPath("//a[text()='Languages']"));
                skillsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
                userNameButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
                availabilityPencilIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
                HoursPencilIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
                earnTargetPencilIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderClickNotificationMenu()
        {
            try
            {

                clickNotificationMenu = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/div"));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void renderClickOnDashboard()
        {
            try
            {

                clickOnDashboard = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[1]")); 
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderShareskill()
        {
            try
            {
                shareSkillButton = driver.FindElement(By.XPath("//a[@class='ui basic green button']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void renderUpdateShareSkillIcon()
        {
            try
            {
                UpdateshareSkillIcon = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[2]/td[8]/div/button[2]/i"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderClickSearchIcon()
        {
            try
            {

                clickSearchIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[1]/i"));

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderClickonManageListing()
        {
            try
            {

                ClickonManageListings = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]"));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


        }
        public void clickLanguagesTab()
        {
            renderComponents();
            languagesTab.Click();
        }
        public void clickSkillsTab()
        {
            renderComponents();
            skillsTab.Click();
        }
        public void clickOnNotificationMenu()
        {
            renderClickNotificationMenu();
            clickNotificationMenu.Click();
            Thread.Sleep(3000);
        }
        public void clickOnDashboardTab()
        {
            renderClickOnDashboard();
            clickOnDashboard.Click();
            Thread.Sleep(3000);

        }
        public void clickShareSkillButton()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//a[@class='ui basic green button']", 4);
            renderShareskill();
            shareSkillButton.Click();
            
        }
      
        public void clickUserNameButton()
        {
            renderComponents();
            userNameButton.Click();
            Thread.Sleep(1000);
        }
        public void clickAvailabilityPencilIcon()
        {
            renderComponents();
            availabilityPencilIcon.Click();

        }
        public void clickHoursPencilIcon()
        {
            renderComponents();
            HoursPencilIcon.Click();
        }
        public void clickEarnTargetPencilIcon()
        {
            renderComponents();
            earnTargetPencilIcon.Click();
        }
        public void clickOnSearchIcon()
        {
            renderClickSearchIcon();
            clickSearchIcon.Click();
            Thread.Sleep(1000);
        }
        public void clickOnManageListings()
        {
            renderClickonManageListing();
            ClickonManageListings.Click();
           
            
        }

    }
}
