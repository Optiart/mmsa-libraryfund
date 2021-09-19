using CityLibraryFund.Common;
using CityLibraryFund.Events;
using CityLibraryFund.Filters;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityLibraryFund
{
    using static FilterControlConstants;

    public partial class LibraryFilterUserControl : UserControl, IFilterUserControl
    {
        public EventHandler<LibraryStateChangedEventArgs> FilterChanged { get; set; }

        private MenuFilterLoader _filterLoader;

        public LibraryFilterUserControl()
        {
            InitializeComponent();
        }

        public void AddDependencies(MenuFilterLoader filterLoader)
        {
            _filterLoader = filterLoader;
        }

        public string CurrentCity => cmbCities.SelectedItem?.ToString();

        public string CurrentLibrary => cmbLibraries.SelectedItem?.ToString();

        private bool _blockEvents;

        protected override void OnLoad(EventArgs e)
        {
            ReloadComboBox(cmbCities, Array.Empty<string>());
            ReloadComboBox(cmbLibraries, Array.Empty<string>());

            this.cmbCities.SelectedValueChanged += new System.EventHandler(this.cmbCities_SelectedValueChanged);
            this.cmbLibraries.SelectedIndexChanged += new System.EventHandler(this.cmbLibraries_SelectedValueChanged);
        }

        public async Task LoadFilters()
        {
            if (CurrentCity != All)
            {
                await LoadLibraries(CurrentCity);
                return;
            }

            var (cities, libraries) = await _filterLoader.GetAll(default);

            _blockEvents = true;
            ReloadComboBox(cmbCities, cities.ToArray());
            ReloadComboBox(cmbLibraries, libraries.ToArray());
            _blockEvents = false;
            RaiseFilterChanged();
        }

        public async void cmbCities_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_blockEvents)
            {
                return;
            }

            _blockEvents = true;
            await LoadLibraries(CurrentCity);
            _blockEvents = false;
            RaiseFilterChanged();
        }

        public void cmbLibraries_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_blockEvents)
            {
                return;
            }

            RaiseFilterChanged();
        }

        private async Task LoadLibraries(string city)
        {
            ICollection<string> libraries;
            if (city == All)
            {
                (_, libraries) = await _filterLoader.GetAll(default);
            }
            else
            {
                libraries = await _filterLoader.GetLibraries(city, default);
            }

            ReloadComboBox(cmbLibraries, libraries.ToArray());
        }

        private void RaiseFilterChanged()
        {
            var libraryFilterState = new LibraryFilterState
            {
                CurrentCity = CurrentCity,
                CurrentLibrary = CurrentLibrary
            };
            var eventArgs = new LibraryStateChangedEventArgs(libraryFilterState);
            FilterChanged?.Invoke(this, eventArgs);
        }

        private static void ReloadComboBox(ComboBox comboBox, string[] items)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add(All);
            comboBox.Items.AddRange(items);
            comboBox.SelectedItem = comboBox.Items[0];
        }

        public void MakeInvisible() => Visible = false;
        public void MakeVisible() => Visible = true;
    }
}
