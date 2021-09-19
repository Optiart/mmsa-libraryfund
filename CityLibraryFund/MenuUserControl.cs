using CityLibraryFund.Common;
using CityLibraryFund.Events;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CityLibraryFund
{
    using static MenuConstants;

    public partial class MenuUserControl : UserControl
    {
        public EventHandler<MenuSelectionChangedEventArgs> MenuSelectionChanged { get; set; }

        public MenuUserControl()
        {
            InitializeComponent();
        }

        protected Button PreviousButton { get; private set; }

        protected virtual void SetActive(Button menuButton)
        {
            menuButton.ForeColor = Color.Red;
        }

        protected virtual void SetInactive(Button menuButton)
        {
            if (menuButton == null)
            {
                return;
            }

            menuButton.ForeColor = DefaultForeColor;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            var currentButton = (Button)sender;
            var previousMenu = GetMenuSection(PreviousButton);
            SetInactive(PreviousButton);

            SetActive(currentButton);
            PreviousButton = currentButton;
            var currentMenu = GetMenuSection(currentButton);
           
            RaiseEvent(previousMenu, currentMenu);
        }

        private string GetMenuSection(Button button)
        {
            if (button == null)
            {
                return string.Empty;
            }

            return button.Name switch
            {
                "btnLibraries" => LibraryMenu,
                "btnFunds" => FundMenu,

                _ => throw new NotSupportedException($"button {button.Name} is not supported")
            };
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
