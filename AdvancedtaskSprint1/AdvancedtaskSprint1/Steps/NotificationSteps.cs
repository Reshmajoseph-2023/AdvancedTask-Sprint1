using Advanced_Task_1.Steps;
using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.AssertHelpers;
using AdvancedtaskSprint1.Pages.Components;
namespace AdvancedtaskSprint1.Steps
{
    public class NotificationSteps : BaseSetup
    {

        NotificationComponent NotificationComponentsObj;
        HomePageSteps HomePageStepsObj;
        NotificationAssertion NotificationAssertionObj;
        public NotificationSteps()
        {
           
            HomePageStepsObj = new HomePageSteps();
            NotificationAssertionObj = new NotificationAssertion();
        }
    
        public void VerifyLoadMoreOption()
        {
            HomePageStepsObj.clickonDashboard();
            bool clickLoadMore = NotificationComponentsObj.VerifyClickLoadMore();
            NotificationAssertionObj.AssertLoadMore(clickLoadMore);
            Console.WriteLine("All notifications loaded successfully");
        }
        public void VerifyShowLessOption()
        {

            HomePageStepsObj.clickonDashboard();
            bool clickShowLess= NotificationComponentsObj.VerifyClickShowLess();
            NotificationAssertionObj.AssertShowLess(clickShowLess);
            Console.WriteLine("Able to click on show less option");

        }
        public void VerifySelectAllOption()
        {
            HomePageStepsObj.clickonDashboard();
            bool clickSelectAll = NotificationComponentsObj.VerifyClickSelectAll();
            NotificationAssertionObj.AssertSelectAll(clickSelectAll);
            Console.WriteLine("Able to select all notifications");
        }
        public void VerifyUnselectAllOption()
        {
            HomePageStepsObj.clickonDashboard();
            bool ClickUnselectAll = NotificationComponentsObj.VerifyClickUnselectAll();
            NotificationAssertionObj.AssertUnselectAll(ClickUnselectAll);
            Console.WriteLine("Able to select and unselect the notifications");
        }
        public void VerifyMarkAsReadOption()
        {
            HomePageStepsObj.clickonDashboard();
            bool markSelectionAsRead = NotificationComponentsObj.VerifyMarkSelectionAsRead();
            string actualmessage = NotificationComponentsObj.getSuccessMessage();
            Console.WriteLine(actualmessage);
            NotificationAssertionObj.AssertMarkAsread(markSelectionAsRead);

        }
        public void VerifyDeleteOption()
        {
            HomePageStepsObj.clickonDashboard();
            bool isSelectDeleted = NotificationComponentsObj.VerifyDeleteSelectionButton();
            string actualmessage = NotificationComponentsObj.getSuccessMessage();
            Console.WriteLine(actualmessage);
            NotificationAssertionObj.AssertDeleteSelection(isSelectDeleted);

        }
      
    }
}
