using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Test_Model;
using AdvancedtaskSprint1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;


namespace AdvancedtaskSprint1.Components
{
    public class AddUpdateDeleteLanguageComponent : BaseSetup
    {
        //private IWebElement AddNew;
        //private IWebElement PencilIcon;
        private static IWebElement AddLanguageTextBox;
        private IWebElement ChooseLanguageLevel;
        private IWebElement AddButton;
        private IWebElement UpdateLangauge;
        private IWebElement UpdateLevel;
        private IWebElement UpdateButton;
        private IWebElement messageBox;
        private string Message = "";
        private IWebElement ElementToDelete;
        private IWebElement deletedLanguage;
        private IWebElement closeMessageIcon;
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
                messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
                closeMessageIcon = driver.FindElement(By.XPath("//*[@class='ns-close']"));
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
                UpdateLangauge = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
                UpdateLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select"));
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
                deletedLanguage= driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
                ElementToDelete = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
                deletebutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void addNewLanguage(Language languagedata)
        {

            renderAddComponents();
            AddLanguageTextBox.SendKeys(languagedata.language);
            Thread.Sleep(3000);
            //Choose the language level
            ChooseLanguageLevel.Click();
            Thread.Sleep(2000);
            ChooseLanguageLevel.SendKeys(languagedata.level);
            //Click on Add button
            AddButton.Click();
            Thread.Sleep(5000);
        }
        public void updateLanguage(Language languageupdatedata)
        {
            renderUpdateLanguage();
            //Edit the language
            UpdateLangauge.Clear();
            UpdateLangauge.SendKeys(languageupdatedata.language);
            Thread.Sleep(1000);
            //Choose the level from the drop down
            UpdateLevel.Click();
            Thread.Sleep(1000);
            UpdateLevel.SendKeys(languageupdatedata.level);
            //Click on Update button
            UpdateButton.Click();
            Thread.Sleep(2000);
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
        public string GetMessageBoxText()
        {
            renderAddMessage();
            //get the text of the message element
            string Message = messageBox.Text;

            //If any message visible close it
            //Wait.WaitToBeClickable(driver, "XPath", "//*[@class='ns-close']", 5);
            //closeMessageIcon.Click();
            return Message;
        }
        
    }
}
