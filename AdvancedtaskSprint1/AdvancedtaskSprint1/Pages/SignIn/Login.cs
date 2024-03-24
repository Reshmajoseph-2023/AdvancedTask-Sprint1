
using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Model;
using AdvancedtaskSprint1.Utilities;
using OpenQA.Selenium;



namespace AdvancedtaskSprint1.Pages.SignIn
{
    public class Login : BaseSetup
    {

        private IWebElement email;
        private IWebElement password;
        private IWebElement loginButton;
        public void renderLoginComponents()
        {
            try
            {

                email = driver.FindElement(By.Name("email"));
                password = driver.FindElement(By.Name("password"));
                loginButton = driver.FindElement(By.XPath("//button[text()='Login']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void LoginSteps()
        {

            List<LoginCredentials> credentialsList = LoadJson.Read<LoginCredentials>("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Data\\LoginData.json");
            foreach (var logincredentials in credentialsList)
            {
                renderLoginComponents();
                email.SendKeys(logincredentials.email);
                password.SendKeys(logincredentials.password);
                loginButton.Click();
                Thread.Sleep(3000);
            }
        }
    }
}
