using CityLibraryFund.Events;
using System;

namespace CityLibraryFund
{
    public class MenuSelector
    {
        public EventHandler<MenuSelectionChangedEventArgs> MenuSelectionChanged { get; set; }

        private string _selectedMenu;
        public string SelectedMenu
        {
            get => _selectedMenu;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(SelectedMenu));
                }

                if (string.Equals(value, _selectedMenu))
                {
                    return;
                }

                var previousSelection = _selectedMenu;
                _selectedMenu = value;
                RaiseEvent(previousSelection, value);
            }
        }

        private void RaiseEvent(string previousMenu, string currentMenu)
        {
            var eventArgs = new MenuSelectionChangedEventArgs
            {
                ChangedFrom = previousMenu,
                ChangedTo = currentMenu
            };

            MenuSelectionChanged?.Invoke(this, eventArgs);
        }
    }
}