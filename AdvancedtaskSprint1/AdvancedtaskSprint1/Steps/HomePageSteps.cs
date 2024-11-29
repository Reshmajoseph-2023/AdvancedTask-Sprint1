using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AdvancedtaskSprint1.Pages.Components;

namespace Advanced_Task_1.Steps
{
    public class HomePageSteps
    {
       
        private HomePageTabsComponents homePageTabsComponents;

        public HomePageSteps()
        {

            homePageTabsComponents = new HomePageTabsComponents();
        }

        public void clickLanguagesTab()
        {
            homePageTabsComponents.clickLanguagesTab();
        }
        public void clickSkillsTab()
        {
            homePageTabsComponents.clickSkillsTab();
        }
        public void clickNotificationmenu()
        {
            homePageTabsComponents.clickOnNotificationMenu();
        }
        public void clickonDashboard()
        {
            homePageTabsComponents.clickOnDashboardTab();

        }
        public void clickShareSkill()
        {
            homePageTabsComponents.clickShareSkillButton();
        }
       
        public void clickProfileUserNameIcon()

        {
            homePageTabsComponents.clickUserNameButton();
        }

        public void clickAvailabilityPencilIcon()
        {
            homePageTabsComponents.clickAvailabilityPencilIcon();
        }
        public void clickHoursPencilIcon()
        {
            homePageTabsComponents.clickHoursPencilIcon();
        }
        public void clickEarnTargetPencilIcon()
        {
            homePageTabsComponents.clickEarnTargetPencilIcon();
        }
        public void clickSearchSkillIcon()
        {
            homePageTabsComponents.clickOnSearchIcon();
        }
        public void clickManageListings()
        {
            homePageTabsComponents.clickOnManageListings();
        }

    }
}
