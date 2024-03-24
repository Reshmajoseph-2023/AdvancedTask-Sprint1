using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Pages.SignIn;
using AdvancedtaskSprint1.Steps;
using NUnit.Framework;


namespace AdvancedtaskSprint1.Tests
{
    [TestFixture]
    public class NotificationTest : BaseSetup
    {
      
        NotificationSteps NotificationStepsObj;
        public NotificationTest()
        {
          
            NotificationStepsObj = new NotificationSteps();
        }
        

        [Test, Order(1), Description("This test verify that all requests or notifications are loaded.")]
        public void VerifyLoadMore()
        {

            NotificationStepsObj.VerifyLoadMoreOption();
        }

        [Test, Order(2), Description("This test verify that user can shrink notifications lists")]
        public void VerifyShowLess()
        {
          
            NotificationStepsObj.VerifyShowLessOption();
        }

        [Test, Order(3), Description("This test verify that user can select All notifications")]
        public void VerifySelectAll()
        {
            NotificationStepsObj.VerifySelectAllOption();
        }

        [Test, Order(4), Description("This test verify that notifications can be unselected")]
        public void VerifyUnSelectAll()
        {
            NotificationStepsObj.VerifyUnselectAllOption();
        }

        [Test, Order(5), Description("This test verify that notifications can be Mark As Read")]
        public void VerifyMarkAsRead()
        {
            NotificationStepsObj.VerifyMarkAsReadOption();
        }

        [Test, Order(6), Description("This test verify that notifications selected can be deleted")]
        public void VerifyDelete()
        {
            NotificationStepsObj.VerifyDeleteOption();
        }

        
    }
}