using Domain;
using Domain.Builders.Funds;
using Domain.Enum;
using Domain.Models.Funds;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityLibraryFund.ControlForms
{
    public partial class frmFund : Form, IControlForm
    {
        private readonly FundManager _fundManager;
        private readonly LibraryManager _libraryManager;
        
        private readonly BookBuilder _bookBuilder;
        private readonly JournalBuilder _journalBuilder;
        private readonly NewspaperBuilder _newspaperBuilder;
        private readonly OtherFundBuilder _otherFundBuilder;


        public frmFund(
            FundManager fundManager,
            BookBuilder bookBuilder,
            JournalBuilder journalBuilder,
            NewspaperBuilder newspaperBuilder,
            OtherFundBuilder otherFundBuilder,
            LibraryManager libraryManager)
        {
            InitializeComponent();
            _fundManager = fundManager;
            _bookBuilder = bookBuilder;
            _journalBuilder = journalBuilder;
            _newspaperBuilder = newspaperBuilder;
            _otherFundBuilder = otherFundBuilder;
            _libraryManager = libraryManager;
        }

        private void SetComponents(Fund fund)
        {
            txtId.Text = fund  == null ? string.Empty : fund.Id.ToString();
            txtName.Text = fund?.Name ?? string.Empty;
            txtUniqueNumber.Text = fund?.GetUniqueNumber() ?? string.Empty;
            lblUniqueNumber.Text = GetLblUniqueNumberText(fund?.Entity);
            txtIssueNumber.Text = GetIssueNumber(fund);
            txtIssueNumber.Enabled = HasIssueNumber(fund);
            dtPublished.Value = fund?.PublishDate ?? DateTime.Now;          

            if (fund?.Authors != null && fund.Authors.Any())
            {
                var authorsWrappers = fund.Authors.Select(a => new AuthorWrapper
                {
                    Id = a.Id,
                    FullName = $"{a.LastName} {a.MiddleName} {a.FirstName}"
                }).ToArray();
                lstAuthors.Items.AddRange(authorsWrappers);
            }
        }

        private string GetLblUniqueNumberText(FundEntityEnum? entity)
        {
            return entity switch
            {
                FundEntityEnum.Book => "ISBN",
                FundEntityEnum.Journal => "ISSN",
                FundEntityEnum.Newspaper => "ISSN",
                FundEntityEnum.Other => "Унікальний номер",

                _ => "Унікальний номер"
            };
        }

        private string GetIssueNumber(Fund fund)
        {
            if (fund == null)
            {
                return string.Empty;
            }

            return fund.Entity switch
            {
                FundEntityEnum.Book => string.Empty,
                FundEntityEnum.Journal => ((Journal)fund).IssueNumber.ToString(),
                FundEntityEnum.Newspaper => ((Newspaper)fund).IssueNumber.ToString(),
                FundEntityEnum.Other => string.Empty,

                _ => string.Empty
            };
        }

        private bool HasIssueNumber(Fund fund)
        {
            if (fund == null)
            {
                return false;
            }

            return fund is PeriodicalLiterature;
        }

        public Task<bool> DeleteEntiy(uint id)
        {
            throw new NotImplementedException();
        }

        public Task LoadEntity(uint id)
        {
            throw new NotImplementedException();
        }

        private async void frmFund_Load(object sender, EventArgs e)
        {


        }

        private async Task LoadLibraries()
        {
            var libraries = await _libraryManager.GetAll(default);
            var libraryWrappers = libraries.Select(l => new LibraryWrapper
            {
                Id = l.Id,
                Name = l.Name
            }).ToArray();

        }

        private class LibraryWrapper
        {
            public uint Id { get; set; }

            public string Name { get; set; }

            public override string ToString() => Name;
        }

        private class AuthorWrapper
        {
            public uint Id { get; set; }

            public string FullName { get; set; }

            public override string ToString() => FullName;
        }
    }
}
