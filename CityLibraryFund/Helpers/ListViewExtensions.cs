using System.Linq;
using System.Windows.Forms;

namespace CityLibraryFund.Helpers
{
    public static class ListViewExtensions
    {
        public static void AddColumns(this ListView listView, params string[] columnNames)
        {
            listView.Columns.Clear();
            var columnHeaders = columnNames.Select((c, i) => new ColumnHeader
            {
                Name = "clmHeader" + i,
                Text = c
            }).ToArray();

            listView.Columns.AddRange(columnHeaders);
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        public static void AddRow(this ListView listView, params string[] columnContent)
        {
            var item = new ListViewItem(columnContent);
            listView.Items.Add(item);
        }
    }
}
