using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Pages.Components;
using AdvancedtaskSprint1.Test_Model;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AdvancedtaskSprint1.AssertHelpers
{
    public class SearchSkillAssertions : BaseSetup
    {
        SearchSkillsComponent SearchSkillsComponentsObj;

        public SearchSkillAssertions()
        {
            SearchSkillsComponentsObj = new SearchSkillsComponent();
        }
        public void AssertionSearchSkill(SearchSkillModel searchskill)
        {
            

            IWebElement ActualSkill = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[1]/div[1]/a[2]/p"));
            Thread.Sleep(5000);
            string actualskill = ActualSkill.Text;
            string expectedSkill = searchskill.skill;
            Assert.That(actualskill==expectedSkill, "The skill you are searching has not been found");
            Console.WriteLine(" The skill"  + searchskill.skill + " you are searching has been found");

    }
        
        public void AssertionSearchCategory(SearchSkillModel inputcategory)
        {
            IWebElement FirstSkill = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[1]/a/img"));
            FirstSkill.Click();
            Thread.Sleep(4000);
            IWebElement actualCategory = driver.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[1]/div/div[2]")); 
            string expectedCategory = inputcategory.category;
            Assert.That(actualCategory.Text == expectedCategory, "The skills under the category you are searching has not been found");
            

        }
        public void AssertionSearchFilter(SearchSkillModel inputfilter)
        {
            IWebElement FirstSkill = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[1]/a/img"));
            FirstSkill.Click();
            Thread.Sleep(5000);
            IWebElement actualFilter = driver.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[3]/div/div[3]/div/div[2]"));
            string expectedFilter = inputfilter.filteroption;
            Assert.That(actualFilter.Text == expectedFilter, "The skills under " + inputfilter.filteroption + "has not been found");
                     
        }
                
    }
}

