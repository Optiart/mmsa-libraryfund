
namespace CityLibraryFund
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuUserControl1 = new CityLibraryFund.MenuUserControl();
            this.lblCityAndLibrary = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.fundFilterUserControl1 = new CityLibraryFund.FundFilterUserControl();
            this.libraryFilterUserControl = new CityLibraryFund.LibraryFilterUserControl();
            this.pnlElementControls = new System.Windows.Forms.Panel();
            this.controlPanelUserControl1 = new CityLibraryFund.ControlPanelUserControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstMain = new System.Windows.Forms.ListView();
            this.panel2.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.pnlElementControls.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuUserControl1
            // 
            this.menuUserControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuUserControl1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuUserControl1.Location = new System.Drawing.Point(0, 55);
            this.menuUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.menuUserControl1.MenuSelectionChanged = null;
            this.menuUserControl1.Name = "menuUserControl1";
            this.menuUserControl1.Size = new System.Drawing.Size(215, 732);
            this.menuUserControl1.TabIndex = 10;
            // 
            // lblCityAndLibrary
            // 
            this.lblCityAndLibrary.Location = new System.Drawing.Point(3, 9);
            this.lblCityAndLibrary.Name = "lblCityAndLibrary";
            this.lblCityAndLibrary.Size = new System.Drawing.Size(1430, 36);
            this.lblCityAndLibrary.TabIndex = 1;
            this.lblCityAndLibrary.Text = "Обрана бібліотка та місто";
            this.lblCityAndLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCityAndLibrary);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1436, 55);
            this.panel2.TabIndex = 9;
            // 
            // pnlFilters
            // 
            this.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilters.Controls.Add(this.fundFilterUserControl1);
            this.pnlFilters.Controls.Add(this.libraryFilterUserControl);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Location = new System.Drawing.Point(215, 55);
            this.pnlFilters.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1221, 107);
            this.pnlFilters.TabIndex = 12;
            // 
            // fundFilterUserControl1
            // 
            this.fundFilterUserControl1.FilterChanged = null;
            this.fundFilterUserControl1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fundFilterUserControl1.Location = new System.Drawing.Point(0, 16);
            this.fundFilterUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.fundFilterUserControl1.Name = "fundFilterUserControl1";
            this.fundFilterUserControl1.Size = new System.Drawing.Size(1006, 67);
            this.fundFilterUserControl1.TabIndex = 2;
            this.fundFilterUserControl1.Visible = false;
            // 
            // libraryFilterUserControl
            // 
            this.libraryFilterUserControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.libraryFilterUserControl.FilterChanged = null;
            this.libraryFilterUserControl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.libraryFilterUserControl.Location = new System.Drawing.Point(0, 0);
            this.libraryFilterUserControl.Margin = new System.Windows.Forms.Padding(4);
            this.libraryFilterUserControl.Name = "libraryFilterUserControl";
            this.libraryFilterUserControl.Size = new System.Drawing.Size(934, 105);
            this.libraryFilterUserControl.TabIndex = 0;
            this.libraryFilterUserControl.Visible = false;
            // 
            // pnlElementControls
            // 
            this.pnlElementControls.Controls.Add(this.controlPanelUserControl1);
            this.pnlElementControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlElementControls.Location = new System.Drawing.Point(215, 162);
            this.pnlElementControls.Margin = new System.Windows.Forms.Padding(4);
            this.pnlElementControls.Name = "pnlElementControls";
            this.pnlElementControls.Size = new System.Drawing.Size(1221, 76);
            this.pnlElementControls.TabIndex = 13;
            // 
            // controlPanelUserControl1
            // 
            this.controlPanelUserControl1.Enabled = false;
            this.controlPanelUserControl1.EntityUpdated = null;
            this.controlPanelUserControl1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.controlPanelUserControl1.Location = new System.Drawing.Point(75, 9);
            this.controlPanelUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.controlPanelUserControl1.Name = "controlPanelUserControl1";
            this.controlPanelUserControl1.Size = new System.Drawing.Size(1065, 63);
            this.controlPanelUserControl1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(215, 238);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 549);
            this.panel1.TabIndex = 14;
            // 
            // lstMain
            // 
            this.lstMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMain.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstMain.FullRowSelect = true;
            this.lstMain.GridLines = true;
            this.lstMain.HideSelection = false;
            this.lstMain.Location = new System.Drawing.Point(0, 0);
            this.lstMain.Margin = new System.Windows.Forms.Padding(4);
            this.lstMain.Name = "lstMain";
            this.lstMain.Size = new System.Drawing.Size(1221, 549);
            this.lstMain.TabIndex = 4;
            this.lstMain.UseCompatibleStateImageBehavior = false;
            this.lstMain.View = System.Windows.Forms.View.Details;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 787);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlElementControls);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.menuUserControl1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бібліотечний фонд міста";
            this.panel2.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false);
            this.pnlElementControls.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MenuUserControl menuUserControl1;
        private System.Windows.Forms.Label lblCityAndLibrary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlFilters;
        private LibraryFilterUserControl libraryFilterUserControl;
        private System.Windows.Forms.Panel pnlElementControls;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lstMain;
        private FundFilterUserControl fundFilterUserControl1;
        private ControlPanelUserControl controlPanelUserControl1;
    }
}

