using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdvancedtaskSprint1.Pages.SignIn

{
    public class SignIn : BaseSetup
    {
        private IWebElement signInButton;
        public void renderSignInComponent()
        {
            try
            {
                signInButton = driver.FindElement(By.XPath("//a[text()='Sign In']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void ClickSignIn()
        {
            renderSignInComponent();
            Wait.WaitToBeClickable(driver, "XPath", "//a[text()='Sign In']", 4);
            signInButton.Click();
            Thread.Sleep(2000);
        }
    }
}
