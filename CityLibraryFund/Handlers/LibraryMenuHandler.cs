using CityLibraryFund.Common;
using System.Windows.Forms;

namespace CityLibraryFund.Handlers
{
    using static MenuConstants;
    
    public class LibraryMenuHandler : MenuHandler
    {
        public override string Name => LibraryMenu;

        protected override void HandleDeselection()
        {
            SetInactive(MenuButton);
        }

        protected override void HandleSelection()
        {
            base.HandleSelection();
            SetActive(MenuButton);

            ListView.Columns.Add("Address");
            ListView.Columns.Add("Floor");

            var items = new[] { "foo", "foo" };
            var item = new ListViewItem(items);
            ListView.Items.Add(item);
        }
    }
}
