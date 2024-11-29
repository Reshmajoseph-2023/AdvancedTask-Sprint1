using Advanced_Task_1.Steps;
using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.AssertHelpers;
using AdvancedtaskSprint1.Pages.Components;
using AdvancedtaskSprint1.Test_Model;
using AdvancedtaskSprint1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Advanced_Task_1.Utilities.BaseSetup;

namespace AdvancedtaskSprint1.Steps
{
    public class SearchSkillSteps : BaseSetup
    {
        HomePageSteps HomePageStepsObj;
        SearchSkillsComponent SearchSkillsComponentObj;
        SearchSkillAssertions AssertionsSearchSkillObj;


        public SearchSkillSteps()
        {
            HomePageStepsObj = new HomePageSteps();
            SearchSkillsComponentObj = new SearchSkillsComponent();
            AssertionsSearchSkillObj = new SearchSkillAssertions();
        }
        public void SearchSkillsByCategory()
        {
            List<SearchSkillModel> SearchSkillModel = LoadJson.Read<SearchSkillModel>("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Data\\CategoryData.json");
            foreach (var data in SearchSkillModel)
            {
                HomePageStepsObj.clickSearchSkillIcon();
                SearchSkillsComponentObj.SearchByCategory(data);
                AssertionsSearchSkillObj.AssertionSearchCategory(data);
            }
        }
        public void SearchByFilter()
        {
            List<SearchSkillModel> SearchSkillModel = LoadJson.Read<SearchSkillModel>("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Data\\FilterData.json");
            foreach (var data in SearchSkillModel)
            {
                HomePageStepsObj.clickSearchSkillIcon();
                SearchSkillsComponentObj.SearchByFilter(data);
                AssertionsSearchSkillObj.AssertionSearchFilter(data);
            }
        }
        public void SearchBySkills()
        {
            List<SearchSkillModel> SearchSkillModel = LoadJson.Read<SearchSkillModel>("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Data\\SearchSkill.json");
            foreach (var data in SearchSkillModel)
            {
              
                SearchSkillsComponentObj.SkillToBeSearched(data);
                AssertionsSearchSkillObj.AssertionSearchSkill(data);
            }
        }
      
    }
}
