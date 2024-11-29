using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Test_Model;
using AdvancedtaskSprint1.Utilities;
using OpenQA.Selenium;


namespace AdvancedtaskSprint1.Pages.Components
{
    public class ShareSkillComponent : BaseSetup
    {
        private IWebElement TitleTextbox;
        private IWebElement DescriptionTextbox;
        private IWebElement CategoryDropdown;
        private IWebElement SubcategoryDropdown;
        private IWebElement TagsTextbox;
        private IWebElement HourlyBasis;
        private IWebElement ClickOneOff;
        private IWebElement messageWindow;
        private IWebElement ClickOnsite;
        private IWebElement ClickOnline;
        private IWebElement StartDate;
        private IWebElement EndDate;
        private IWebElement SelectDay;
        private IWebElement StartTime;
        private IWebElement EndTime;
        private IWebElement ClickCredit;
        private IWebElement EnterCharge;
        private IWebElement ClearTag;
        private IWebElement SaveButton;


        public void renderTitle()
        {
            try
            {
                TitleTextbox = driver.FindElement(By.Name("title"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderDescription()
        {
            try
            {
                DescriptionTextbox = driver.FindElement(By.Name("description"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderCategory()
        {
            try
            {
                CategoryDropdown = driver.FindElement(By.Name("categoryId"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderSubCategory()
        {
            try
            {
                SubcategoryDropdown = driver.FindElement(By.Name("subcategoryId"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderTags()
        {
            try
            {
                TagsTextbox = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderServiceType()
        {
            try
            {
                HourlyBasis = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
                ClickOneOff = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderLocationType()
        {
            try
            {
                ClickOnsite = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));
                ClickOnline = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderAvailableDays()
        {
            try
            {
                StartDate = driver.FindElement(By.Name("startDate"));
                EndDate = driver.FindElement(By.Name("endDate"));
                SelectDay = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));
                StartTime = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input"));
                EndTime = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderSkillTrade()
        {
            try
            {
                ClickCredit = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void renderCredit()
        {
            try
            {
                EnterCharge = driver.FindElement(By.Name("charge"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void renderClearTag()
        {
            try
            {
                ClearTag = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/span[2]/a[last()]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void renderSaveButton()
        {
            try
            {
                SaveButton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void AddSkill(ShareSkillModel addShareSkill)
        {
            renderTitle();
            TitleTextbox.SendKeys(addShareSkill.title);
            renderDescription();
            DescriptionTextbox.SendKeys(addShareSkill.description);
            renderCategory();
            CategoryDropdown.Click();
            CategoryDropdown.SendKeys(addShareSkill.category);
            CategoryDropdown.Click();
            renderSubCategory();
            SubcategoryDropdown.Click();
            SubcategoryDropdown.SendKeys(addShareSkill.subcategory);
            SubcategoryDropdown.Click();
            renderTags();
            TagsTextbox.Click();
            TagsTextbox.SendKeys(addShareSkill.tagone);
            TagsTextbox.SendKeys(Keys.Enter);
            renderServiceType();
            ClickOneOff.Click();
            renderLocationType();
            ClickOnsite.Click();
            renderAvailableDays();
            StartDate.Click();
            StartDate.SendKeys(addShareSkill.startDate);
            EndDate.Click();
            EndDate.SendKeys(addShareSkill.endDate);
            SelectDay.Click();
            StartTime.Click();
            StartTime.SendKeys(addShareSkill.startTime);
            EndTime.Click();
            EndTime.SendKeys(addShareSkill.endTime);
            renderSkillTrade();
            ClickCredit.Click();
            renderCredit();
            EnterCharge.Click();
            EnterCharge.SendKeys(addShareSkill.charge);
            renderSaveButton();
            SaveButton.Click();
            Thread.Sleep(6000);
        }
        public void renderAddMessage()
        {
            try
            {
                Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 4);
                messageWindow = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public string GetMessageBoxText()
        {
            //Saving error or success message
            renderAddMessage();
            //get the text of the message element
            string Message = messageWindow.Text;
            return Message;
        }

    }
}