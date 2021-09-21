using CityLibraryFund.Common;
using CityLibraryFund.ControlForms;
using CityLibraryFund.Events;
using CityLibraryFund.Helpers;
using Data.Exceptions;
using Domain;
using Domain.Builders;
using System;
using System.Windows.Forms;

namespace CityLibraryFund
{
    using static MenuConstants;
    using static MessageBoxHelper;

    public partial class ControlPanelUserControl : UserControl
    {
        public EventHandler<EntityEventArgs> EntityUpdated { get; set; }

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = GetControlForm();
            var result = form.ShowDialog();
   
            if (result == DialogResult.OK)
            {
                var eventArgs = GetCreatedEventArgs();
                RaiseEvent(eventArgs);
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (!TryGetId(out var id))
            {
                return;
            }

            var form = GetControlForm();

            try
            {
                await form.LoadEntity(id);
            }
            catch (EntityNotFoundException)
            {
                EntityNotFoundMessageBox();
            }

            var result = form.ShowDialog();
 
            if (result == DialogResult.OK)
            {
                var eventArgs = GetUpdatedEventArgs();
                RaiseEvent(eventArgs);
            }
        }

        private void RaiseEvent(EntityEventArgs eventArgs)
        {
            EntityUpdated?.Invoke(this, eventArgs);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (!TryGetId(out var id))
            {
                return;
            }

            var form = GetControlForm();

            bool deleted;
            try
            {
                deleted = await form.DeleteEntiy(id);
            }
            catch (EntityNotFoundException)
            {
                EntityAlreadyDeletedMessageBox();
                return;
            }

            if (!deleted)
            {
                return;
            }

            var eventArgs = GetDeletedEventArgs();
            RaiseEvent(eventArgs);
        }

        private bool TryGetId(out uint id)
        {
            id = default;
            if (_listView.SelectedItems.Count == 0)
            {
                return false;
            }

            var selectedItem = _listView.SelectedItems[0].SubItems[0];
            if (!uint.TryParse(selectedItem.Text, out id))
            {
                return false;
            }

            return true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var eventArgs = GetEntityUpdateRequestedEventArgs();
            RaiseEvent(eventArgs);
        }

        private EntityEventArgs GetCreatedEventArgs() => new EntityCreatedEventArgs(_currentMenu);

        private EntityEventArgs GetUpdatedEventArgs() => new EntityUpdatedEventArgs(_currentMenu);

        private EntityEventArgs GetDeletedEventArgs() => new EntityDeletedEventArgs(_currentMenu);

        private EntityEventArgs GetEntityUpdateRequestedEventArgs() => new EntityReloadRequestedEventArgs(_currentMenu);
    }
}
