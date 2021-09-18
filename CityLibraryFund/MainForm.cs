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
    using static MessageBoxHelper;

    public partial class MainForm : Form
    {
        private readonly LibraryManager _libraryManager;

        public MainForm(LibraryManager libraryManager)
        {
            InitializeComponent();

            _libraryManager = libraryManager;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
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
            var libraries = await _libraryManager.GetAll(CancellationToken.None);
            var cities = libraries.Select(l => l.Location.City).Distinct().ToArray();

            if (!cities.Any())
            {
                EmptyCityListMessageBox();
                return;
            }

            cmbCities.Items.AddRange(cities);
            cmbCities.SelectedItem = cmbCities.Items[0];
        }
    }
}
