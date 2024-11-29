using Advanced_Task_1.Steps;
using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.AssertHelpers;
using AdvancedtaskSprint1.Model;
using AdvancedtaskSprint1.Pages.Components;
using AdvancedtaskSprint1.Test_Model;
using AdvancedtaskSprint1.Utilities;


namespace AdvancedtaskSprint1.Steps
{
    public class UserProfileSteps : BaseSetup
    {
        ProfileDataComponents UserNameComponents;
        HomePageSteps HomePageStepsObj;
        ProfileDataAssertion ProfileDataAssertionsObj;
        public UserProfileSteps()
        {
            UserNameComponents = new ProfileDataComponents();
            HomePageStepsObj = new HomePageSteps();
            ProfileDataAssertionsObj = new ProfileDataAssertion();
        }
        public void AddUserName()
        {

            List<Profiledata> UserNameModel = LoadJson.Read<Profiledata>("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Data\\ProfileData.json");
            foreach (var username in UserNameModel)
            {
                HomePageStepsObj.clickProfileUserNameIcon();
                UserNameComponents.AddFirstLastName(username);
                ProfileDataAssertionsObj.FirstNameAssertion(username);
            }
        }
        public void AddAvailability()
        {
            List<Profiledata> AvailabilityModel = LoadJson.Read<Profiledata>("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Data\\ProfileData.json");
            foreach (var availability in AvailabilityModel)
            {
                HomePageStepsObj.clickAvailabilityPencilIcon();
                UserNameComponents.AddAvailability(availability);
                string actualmessage = UserNameComponents.getSuccessMessage();
                Console.WriteLine(actualmessage);
                ProfileDataAssertionsObj.AvailabilityAssertion(availability);
            }
        }
        public void AddHours()
        {
            List<Profiledata> HoursModel = LoadJson.Read<Profiledata>("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Data\\ProfileData.json");
            foreach (var hours in HoursModel)
            {
                HomePageStepsObj.clickHoursPencilIcon();
                UserNameComponents.AddHours(hours);
                string actualmessage = UserNameComponents.getSuccessMessage();
                Console.WriteLine(actualmessage);
                ProfileDataAssertionsObj.HoursAssertion(hours);
            }
        }
        public void AddEarnTarget()
        {
            List<Profiledata> TargetModel = LoadJson.Read<Profiledata>("C:\\Users\\reshm\\source\\repos\\second\\AdvancedtaskSprint1\\AdvancedtaskSprint1\\Data\\ProfileData.json");
            foreach (var target in TargetModel)
            {
                Thread.Sleep(3000);
                HomePageStepsObj.clickEarnTargetPencilIcon();
                UserNameComponents.AddEarnTarget(target);
                string actualmessage = UserNameComponents.getSuccessMessage();
                Console.WriteLine(actualmessage);
                ProfileDataAssertionsObj.EarnTargetAssertion(target);
            }

        }
    }

}