using CityLibraryFund.Common;

namespace CityLibraryFund.Handlers
{
    using System.Windows.Forms;
    using static MenuConstants;

    public class FundMenuHandler : MenuHandler
    {
        public override string Name => FundMenu;

        protected override void HandleDeselection()
        {
            SetInactive(MenuButton);
        }

        protected override void HandleSelection()
        {
            base.HandleSelection();
            SetActive(MenuButton);

            ListView.Columns.Add("Name");
            ListView.Columns.Add("Category");

            var items = new[] { "abz", "123" };
            var item = new ListViewItem(items);
            ListView.Items.Add(item);
        }
    }
}
