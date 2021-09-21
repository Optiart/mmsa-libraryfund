using CityLibraryFund.Helpers;
using CityLibraryFund.ViewModels;
using Domain;
using Domain.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityLibraryFund.ControlForms
{
    using static MessageBoxHelper;

    public partial class frmLibrary : Form, IControlForm
    {
        private LibraryManager _libraryManager;
        private LibraryBuilder _libraryBuilder;
        private bool _isCreation;

        public frmLibrary(
            LibraryManager libraryManager,
            LibraryBuilder libraryBuilder)
        {
            _libraryManager = libraryManager;
            _libraryBuilder = libraryBuilder;
            InitializeComponent();
            SetComponents(null);
            _isCreation = true;
        }

        public async Task LoadEntity(uint id)
        {
            var library = await _libraryManager.Get(id, default);

            var libraryViewModel = new Library
            {
                Id = library.Id,
                Name = library.Name,
                City = library.Location.City,
                Address = library.Location.Address
            };

            SetComponents(libraryViewModel);
            _isCreation = false;
        }

        public async Task<bool> DeleteEntiy(uint id)
        {
            var library = await _libraryManager.Get(id, default);

            if (DeleteConfirmationMessageBox(library.Name) != DialogResult.Yes)
            {
                return false;
            }

            await _libraryManager.Delete(id, default);
            return true;
        }

        private void SetComponents(Library library)
        {
            txtId.Text = library?.Id.ToString() ?? string.Empty;
            txtName.Text = library?.Name ?? string.Empty;
            txtCity.Text = library?.City ?? string.Empty;
            txtAddress.Text = library?.Address ?? string.Empty;
        }

        private async void btnSave_Click(object sender, System.EventArgs e)
        {
            Validate(out var validationErrors);

            if (validationErrors.Any())
            {
                EnteredInvalidData(string.Join(",", validationErrors));
                return;
            }
            var id = string.IsNullOrEmpty(txtId.Text) ? 0 : uint.Parse(txtId.Text);

            var domainLibrary = _libraryBuilder
                .New()
                .WithBasicInfo(
                    id,
                    txtName.Text,
                    txtCity.Text,
                    txtAddress.Text)
                .Build();

            try
            {
                if (_isCreation)
                {
                    await _libraryManager.Add(domainLibrary, default);
                }
                else
                {
                    await _libraryManager.Update(domainLibrary, default);
                }
                DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                GeneralErrorMessageBox(ex.Message);
            }
        }

        private void Validate(out ICollection<string> validationErrors)
        {
            validationErrors = new List<string>();

            if (string.IsNullOrEmpty(txtName.Text))
            {
                validationErrors.Add("Name is empty");
            }

            if (string.IsNullOrEmpty(txtCity.Text))
            {
                validationErrors.Add("City is empty");
            }


            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                validationErrors.Add("Address is empty");
            }
        }
    }
}
