using CityLibraryFund.Common;
using CityLibraryFund.Handlers;
using CityLibraryFund.Helpers;
using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityLibraryFund
{
    using static FormExtensions;
    using static MenuConstants;
    using static MessageBoxHelper;

    public partial class MainForm : Form
    {
        private readonly LibraryManager _libraryManager;
        private readonly MenuSelector _menuSelector;
        private LibraryMenuHandler _libraryMenuHandler;
        private FundMenuHandler _fundMenuHandler;
        private Filter _filter;

        public MainForm(
            LibraryManager libraryManager,
            MenuSelector menuSelector,
            LibraryMenuHandler libraryMenuHandler,
            FundMenuHandler fundMenuHandler)
        {
            InitializeComponent();
            InitHandlers(libraryMenuHandler, fundMenuHandler);
            InitFilter();

            _libraryManager = libraryManager;
            _menuSelector = menuSelector;
        }

        private void InitHandlers(
            LibraryMenuHandler libraryMenuHandler,
            FundMenuHandler fundMenuHandler)
        {
            _libraryMenuHandler = libraryMenuHandler;
            _fundMenuHandler = fundMenuHandler;

            _libraryMenuHandler.Init(btnLibraries, lstMain);
            _fundMenuHandler.Init(btnFunds, lstMain);
        }

        private void InitFilter()
        {
            _filter = new Filter(cmbCities, cmbLibraries);
            _filter.FilterChanged += _libraryMenuHandler.HandleFilterChanged;
            _filter.FilterChanged += _fundMenuHandler.HandleFilterChanged;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                _menuSelector.SelectedMenu = LibraryMenu;
                await Init();
            }
            catch (Exception ex)
            {
                InitErrorMessageBox(ex.Message);
                return;
            }
        }

        private async Task Init()
        {
            var libraries = await this.WrapWithWaitingCursor(async () => await _libraryManager.GetAll(CancellationToken.None));
            var cities = libraries.Select(l => l.Location.City).Distinct().ToArray();

            if (!cities.Any())
            {
                EmptyCityListMessageBox();
                return;
            }


        }

        private void cmbCities_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLibraries_Click(object sender, EventArgs e)
        {
            _menuSelector.SelectedMenu = LibraryMenu;
        }

        private void btnFunds_Click(object sender, EventArgs e)
        {
            _menuSelector.SelectedMenu = FundMenu;
        }

        private void cmbLibraries_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
