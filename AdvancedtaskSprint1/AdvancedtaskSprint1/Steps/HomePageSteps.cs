
using AdvancedtaskSprint1.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Advanced_Task_1.Steps
{
    public class HomePageSteps
    {
       
        private HomePageTabsComponents homeePageTabsComponents;

        public HomePageSteps()
        {

            homeePageTabsComponents = new HomePageTabsComponents();
        }

        public void clickLanguagesTab()
        {
            homeePageTabsComponents.clickLanguagesTab();
        }

        
    }
}
