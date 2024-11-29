using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Test_Model;
using AdvancedtaskSprint1.Utilities;
using OpenQA.Selenium;

namespace AdvancedtaskSprint1.Pages.Components
{
    public class AddUpdateDeleteLanguageComponent : BaseSetup
    {

        private IWebElement AddLanguageTextBox;
        private IWebElement ChooseLanguageLevel;
        private IWebElement AddButton;
        private IWebElement UpdateLanguage;
        private IWebElement UpdateLanguageLevel;
        private IWebElement UpdateButton;
        private IWebElement messageWindow;
        private IWebElement ElementToDelete;
        private IWebElement deletebutton;
        public void renderAddComponents()
        {
            try
            {

                AddLanguageTextBox = driver.FindElement(By.Name("name"));
                ChooseLanguageLevel = driver.FindElement(By.Name("level"));
                AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
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
        public void renderUpdateLanguage()
        {
            try
            {
                UpdateLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
                UpdateLanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select"));
                UpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderDeleteLanguage()
        {
            try
            {
                ElementToDelete = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
                deletebutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void addNewLanguage(Language data)
        {

            renderAddComponents();
            AddLanguageTextBox.SendKeys(data.language);
            //Choose the language level
            ChooseLanguageLevel.Click();
            ChooseLanguageLevel.SendKeys(data.level);
            //Click on Add button
            AddButton.Click();
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 3);
        }
        public void updateLanguage(Language updatedata)
        {
            renderUpdateLanguage();
            //Edit the language
            UpdateLanguage.Clear();
            UpdateLanguage.SendKeys(updatedata.language);
            //Choose the level from the drop down
            UpdateLanguageLevel.Click();
            UpdateLanguageLevel.SendKeys(updatedata.level);
            //Click on Update button
            UpdateButton.Click();
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 6);

        }
        public void DeleteLanguage(Language deletelanguage)
        {
            renderDeleteLanguage();
            Thread.Sleep(2000);
            try
            {

                if (ElementToDelete.Text == deletelanguage.language)
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
        public string getLanguagetobedelete()
        {
            return ElementToDelete.Text;
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
