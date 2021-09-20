using CityLibraryFund.Common;
using CityLibraryFund.ControlForms;
using CityLibraryFund.Events;
using Domain;
using Domain.Builders;
using System;
using System.Windows.Forms;

namespace CityLibraryFund
{
    using static FilterControlConstants;
    using static MenuConstants;

    public partial class ControlPanelUserControl : UserControl
    {
        public EventHandler<EntityUpdatedEventArgs> EntityUpdated { get; set; }

        private string _currentMenu;
        private LibraryManager _libraryManager;
        private LibraryBuilder _libraryBuilder;
        private ListView _listView;

        public ControlPanelUserControl()
        {
            InitializeComponent();
        }

        public void AddDependencies(
            LibraryManager libraryManager,
            LibraryBuilder libraryBuilderListView,
            ListView listView)
        {
            _libraryManager = libraryManager;
            _libraryBuilder = libraryBuilderListView;
            _listView = listView;
        }

        public void HandleMenuSelectionChanged(object _, MenuSelectionChangedEventArgs eventArgs)
        {
            _currentMenu = eventArgs.ChangedTo;
            this.Enabled = !string.IsNullOrEmpty(_currentMenu);
        }

        private IControlForm GetControlForm()
        {
            return _currentMenu switch
            {
                LibraryMenu => new frmLibrary(_libraryManager, _libraryBuilder),

                _ => throw new NotSupportedException($"menu {_currentMenu} is not supported")
            };
        }

        private EntityUpdatedEventArgs GetEventArgs()
        {
            return _currentMenu switch
            {
                LibraryMenu => new LibraryEntityUpdatedEventArgs(LibraryFilter),

                _ => throw new NotSupportedException($"menu {_currentMenu} is not supported")
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = GetControlForm();
            var result = form.ShowDialog();
   
            if (result == DialogResult.OK)
            {
                var eventArgs = GetEventArgs();
                RaiseEvent(eventArgs);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_listView.SelectedItems.Count == 0)
            {
                return;
            }

            var selectedItem = _listView.SelectedItems[0].SubItems[0];
            if (!uint.TryParse(selectedItem.Text, out var id))
            {
                return;
            }

            var form = GetControlForm();
            form.LoadEntity(id);
            var result = form.ShowDialog();
 
            if (result == DialogResult.OK)
            {
                var eventArgs = GetEventArgs();
                RaiseEvent(eventArgs);
            }
        }

        private void RaiseEvent(EntityUpdatedEventArgs eventArgs)
        {
            EntityUpdated?.Invoke(this, eventArgs);
        }
    }
}
