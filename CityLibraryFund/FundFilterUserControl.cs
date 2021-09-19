using CityLibraryFund.Events;
using CityLibraryFund.Filters;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityLibraryFund
{
    public partial class FundFilterUserControl : UserControl, IFilterUserControl
    {
        public EventHandler<FundStateChangedEventArgs> FilterChanged { get; set; }

        public string CurrentFundName => txtName.Text;

        public bool IsInUse => chkIsInUse.Checked;

        public FundFilterUserControl()
        {
            InitializeComponent();
        }

        private bool _blockEvents;

        protected override void OnLoad(EventArgs e)
        {
            txtName.Text = string.Empty;
            chkIsInUse.Checked = false;

            this.chkIsInUse.CheckedChanged += new System.EventHandler(this.chkIsInUse_CheckedChanged);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
        }

        public Task LoadFilters()
        {
            RaiseFilterChanged();
            return Task.CompletedTask;
        }

        private void RaiseFilterChanged()
        {
            var state = new FundFilterState
            {
                Name = CurrentFundName,
                IsInUse = IsInUse
            };
            var eventArgs = new FundStateChangedEventArgs(state);
            FilterChanged?.Invoke(this, eventArgs);
        }

        public void MakeInvisible() => Visible = false;
        public void MakeVisible() => Visible = true;

        private void txtName_Leave(object sender, EventArgs e)
        {
            RaiseFilterChanged();
        }

        private void chkIsInUse_CheckedChanged(object sender, EventArgs e)
        {
            RaiseFilterChanged();
        }
    }
}
