using CityLibraryFund.Events;
using System;
using System.Windows.Forms;

namespace CityLibraryFund
{
    public class Filter
    {
        public EventHandler<FilterChangedEventArgs> FilterChanged { get; set; }

        public string CurrentCity => CitySelector.SelectedItem.ToString();

        public string CurrentLibrary => LibrarySelector.SelectedItem.ToString();

        private ComboBox CitySelector { get; }

        private ComboBox LibrarySelector { get; }

        public Filter(ComboBox citySelector, ComboBox librarySelector)
        {
            CitySelector = citySelector ?? throw new ArgumentNullException(nameof(citySelector));
            LibrarySelector = librarySelector ?? throw new ArgumentNullException(nameof(librarySelector));

            citySelector.Items.Add("Всі");
            citySelector.SelectedItem = citySelector.Items[0];

            librarySelector.Items.Add("Всі");
            librarySelector.SelectedItem = librarySelector.Items[0];
        }

        public void RaiseFilterChanged()
        {
            var eventArgs = new FilterChangedEventArgs(CurrentCity, CurrentLibrary);
            FilterChanged?.Invoke(this, eventArgs);
        }
    }
}
