
using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Utilities;
using OpenQA.Selenium;



namespace AdvancedtaskSprint1.Pages.Components
{
    public class LanguageComponent : BaseSetup
    {
        private IWebElement AddNew;
        private IWebElement PencilIcon;

        public void renderComponents()
        {
            try
            {
                AddNew = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
                PencilIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void clickAddLanguage()
        {
            renderComponents();
            AddNew.Click();
        }
        public void clickUpdateLanguage()
        {
            renderComponents();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i", 4);
            PencilIcon.Click();
        }
    }
}