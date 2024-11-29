using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Test_Model;
using AdvancedtaskSprint1.Utilities;
using OpenQA.Selenium;


namespace AdvancedtaskSprint1.Pages.Components
{
    public class SearchSkillsComponent : BaseSetup
    {
        private IWebElement skillsSearch;
        private IWebElement clickSearch;
       

        public void renderAddComponents()
        {
            try
            {
                skillsSearch = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[1]/input"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderClicksearchComponents()
        {
            try
            {

                clickSearch = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[1]/i"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
  
        public void SearchByCategory(SearchSkillModel categoryData)
        {
            string mainCategoryToSelect = categoryData.category;
            IWebElement selectCategory = driver.FindElement(By.LinkText(mainCategoryToSelect));
            selectCategory.Click();
            Thread.Sleep(2000);
            string SubcategoryToSelect = categoryData.subcategory;
            IWebElement selectsubcategoryElement = driver.FindElement(By.LinkText(SubcategoryToSelect));
            selectsubcategoryElement.Click();
            Thread.Sleep(2000);
        }

        public void SearchByFilter(SearchSkillModel filterData)
        {
            string OnlineButton = filterData.filteroption;
            IWebElement buttonElement = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[5]/button[1]"));
            buttonElement.Click();
            Thread.Sleep(2000);

        }

        public void SkillToBeSearched(SearchSkillModel searchskill)
        {
            renderAddComponents();
            skillsSearch.Click();
            skillsSearch.SendKeys(searchskill.skill);
            renderClicksearchComponents();
            clickSearch.Click();
            Thread.Sleep(2000);

        }

    }
}