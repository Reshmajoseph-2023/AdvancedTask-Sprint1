using Advanced_Task_1.Utilities;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using AdvancedtaskSprint1.Utilities;

namespace AdvancedtaskSprint1.Pages.Components
{
    public class NotificationComponent : BaseSetup
    {

        private IWebElement ClickLoadMore;
        private IWebElement ClickSeeLess;
        private IWebElement ClickSelectAll;
        private IWebElement ClickUnselectAll;
        private IWebElement ClickMarkAsRead;
        private IWebElement messageWindow;
        private IWebElement SelectNotification;
        private IWebElement ClickDeletetNotification;

        public void renderLoadMoreCompnents()
        {
            try
            {

               
                ClickLoadMore = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderSeeLessComponents()
        {
            try
            {
            
                ClickSeeLess = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[7]/div[1]/center/a"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderSelectAllComponents()
        {
            try
            {
             
                ClickSelectAll = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[1]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void renderUnselectAllComponents()
        {
            try
            {
               
                ClickUnselectAll = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[2]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void renderMarkAsReadComponents()
        {
            try
            {
                
                ClickMarkAsRead = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[4]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public void renderSelectNotificationsComponents()
        {
            try
            {
                
                SelectNotification = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[3]/input"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public void renderDeleteComponents()
        {
            try
            {
                ClickDeletetNotification = driver.FindElement(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[3]"));
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


        public bool VerifyClickLoadMore()
        {
            try
            {
                renderLoadMoreCompnents();
                ClickLoadMore.Click();
                Thread.Sleep(3000);
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool VerifyClickShowLess()
        {
            try
            {
                renderLoadMoreCompnents();
                ClickLoadMore.Click();
                renderSeeLessComponents();
                ClickSeeLess.Click();
                Thread.Sleep(3000);
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool VerifyClickSelectAll()
        {
            try
            {
                renderSelectAllComponents();
                Thread.Sleep(3000);
                ClickSelectAll.Click();
                Thread.Sleep(3000);
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
        public bool VerifyClickUnselectAll()
        {
            try
            {
                renderSelectAllComponents();
                ClickSelectAll.Click();
                renderUnselectAllComponents();
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"notification-section\"]/div[2]/div/div/div[3]/div[1]/div[2]")));
                ClickUnselectAll.Click();
                Thread.Sleep(3000);
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
        public bool VerifyMarkSelectionAsRead()
        {
            try
            {
                renderSelectAllComponents();
               
                ClickSelectAll.Click();
                Thread.Sleep(3000);
                renderMarkAsReadComponents();
                ClickMarkAsRead.Click();
                Thread.Sleep(3000);
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool VerifyDeleteSelectionButton()
        {
            try
            {
                renderSelectNotificationsComponents();
                SelectNotification.Click();
                renderDeleteComponents();
                Thread.Sleep(3000);
                ClickDeletetNotification.Click();
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
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
