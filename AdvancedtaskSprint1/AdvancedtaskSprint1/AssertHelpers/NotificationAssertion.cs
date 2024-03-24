using Advanced_Task_1.Utilities;
using AdvancedtaskSprint1.Pages.Components;
using NUnit.Framework;
namespace AdvancedtaskSprint1.AssertHelpers
{

    public class NotificationAssertion : BaseSetup
    {
        NotificationComponent NotificationsComponentsObj;

        public NotificationAssertion()
        {
            NotificationsComponentsObj = new NotificationComponent();

        }
     
        public void AssertLoadMore(bool LoadMoreClicked)
        {
            Assert.That(LoadMoreClicked, "Failed to click 'Load More'.");
        }
        public void AssertShowLess(bool ShowLessClicked)
        {
            Assert.That(ShowLessClicked, "Failed to click 'Show Less'");
        }
        public void AssertSelectAll(bool SelectAllClicked)
        {
            Assert.That(SelectAllClicked, "Failed to click 'Select All'.");
        }
        public void AssertUnselectAll(bool Notificationunselected)
        {
            Assert.That(Notificationunselected, "Failed to click 'Unselect All' ");
        }

        public void AssertMarkAsread(bool MarkAsreadClicked)
        {
            Assert.That(MarkAsreadClicked, "Failed to click the 'Mark As Read' option");
        }

        public void AssertDeleteSelection(bool SelectionDeleted)
        {
            Assert.That(SelectionDeleted, "Failed to click  'Delete Selection'");
        }

    }
}