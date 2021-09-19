using CityLibraryFund.Common;
using CityLibraryFund.Events;
using CityLibraryFund.Filters;
using CityLibraryFund.MenuHandlers;
using Domain;
using System.Windows.Forms;

namespace CityLibraryFund
{
    using static FilterControlConstants;

    public partial class MainForm : Form
    {
        public MainForm(
            MenuFilterLoader menuFilterLoader,
            LibraryFilterHandler libraryFilterHandler,
            FundFilterHandler fundFilterHandler)
        {
            InitializeComponent();
            libraryFilterHandler.SetListView(lstMain);
            fundFilterHandler.SetListView(lstMain);

            var menuSelectionHandler = new MenuSelectionHandler(libraryFilterUserControl, fundFilterUserControl1);
            libraryFilterUserControl.AddDependencies(menuFilterLoader);
            libraryFilterUserControl.FilterChanged += libraryFilterHandler.HandleFilterChanged;
            libraryFilterUserControl.FilterChanged += HandleFilterChanged;

            fundFilterUserControl1.FilterChanged += fundFilterHandler.HandleFilterChanged;

            menuUserControl1.MenuSelectionChanged += menuSelectionHandler.HandleMenuSelectionChanged;
            SetCityAndLibraryText(All, All);
        }

        public void HandleFilterChanged(object _, LibraryStateChangedEventArgs eventArgs) =>
            SetCityAndLibraryText(eventArgs.State.CurrentCity, eventArgs.State.CurrentLibrary);

        private void SetCityAndLibraryText(string city, string library) =>
            lblCityAndLibrary.Text = $"Місто: {city}. Бібліотека: {library}";
    }
}
