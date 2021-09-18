using CityLibraryFund.Events;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CityLibraryFund.Handlers
{
    public abstract class MenuHandler
    {
        public abstract string Name { get; }
        protected Button MenuButton { get; private set; }
        protected ListView ListView { get; private set; }

        protected Color _initialMenuButtonColor;

        protected abstract void HandleDeselection();

        protected virtual void HandleSelection()
        {
            ListView.Clear();
        }

        public void Init(
            Button menuButton,
            ListView listView)
        {
            MenuButton = menuButton ?? throw new ArgumentNullException(nameof(menuButton));
            ListView = listView ?? throw new ArgumentNullException(nameof(listView));
            _initialMenuButtonColor = menuButton.ForeColor;
        }

        protected virtual void SetActive(Button menuButton)
        {
            menuButton.ForeColor = Color.Red;
        }

        protected virtual void SetInactive(Button menuButton)
        {
            menuButton.ForeColor = _initialMenuButtonColor;
        }

        public void HandleMenuSelectionChanged(object _, MenuSelectionChangedEventArgs eventArgs)
        {
            if (eventArgs.ChangedFrom == Name)
            {
                HandleDeselection();
                return;
            }

            if (eventArgs.ChangedTo == Name)
            {
                HandleSelection();
                return;
            }
        }

        public void HandleFilterChanged(object _, FilterChangedEventArgs eventArgs)
        {

        }
    }
}
