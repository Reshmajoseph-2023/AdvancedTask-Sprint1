using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedtaskSprint1.Components
{
    public class HomePageTabsComponents : BaseSetup
    {

        private IWebElement languagesTab;
       
        public void renderComponents()
        {
            try
            {
                languagesTab = driver.FindElement(By.XPath("//a[text()='Languages']"));
               
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
        

    }
}
