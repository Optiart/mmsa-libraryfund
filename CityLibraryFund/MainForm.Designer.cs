
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.pnlMenuButtons = new System.Windows.Forms.Panel();
            this.btnVisits = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnFunds = new System.Windows.Forms.Button();
            this.btnLibraries = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.cmbLibraries = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCities = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlElementControls = new System.Windows.Forms.Panel();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstMain = new System.Windows.Forms.ListView();
            this.pnlMenuButtons.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlElementControls.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Location = new System.Drawing.Point(1060, 25);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(198, 49);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Завантажити";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // pnlMenuButtons
            // 
            this.pnlMenuButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenuButtons.Controls.Add(this.btnVisits);
            this.pnlMenuButtons.Controls.Add(this.btnUsers);
            this.pnlMenuButtons.Controls.Add(this.btnFunds);
            this.pnlMenuButtons.Controls.Add(this.btnLibraries);
            this.pnlMenuButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuButtons.Margin = new System.Windows.Forms.Padding(5);
            this.pnlMenuButtons.Name = "pnlMenuButtons";
            this.pnlMenuButtons.Size = new System.Drawing.Size(237, 715);
            this.pnlMenuButtons.TabIndex = 5;
            // 
            // btnVisits
            // 
            this.btnVisits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisits.Location = new System.Drawing.Point(13, 331);
            this.btnVisits.Margin = new System.Windows.Forms.Padding(5);
            this.btnVisits.Name = "btnVisits";
            this.btnVisits.Size = new System.Drawing.Size(198, 49);
            this.btnVisits.TabIndex = 10;
            this.btnVisits.Text = "Відвідування";
            this.btnVisits.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.Location = new System.Drawing.Point(13, 222);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(5);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(198, 49);
            this.btnUsers.TabIndex = 9;
            this.btnUsers.Text = "Користувачі";
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnFunds
            // 
            this.btnFunds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFunds.Location = new System.Drawing.Point(13, 120);
            this.btnFunds.Margin = new System.Windows.Forms.Padding(5);
            this.btnFunds.Name = "btnFunds";
            this.btnFunds.Size = new System.Drawing.Size(198, 49);
            this.btnFunds.TabIndex = 8;
            this.btnFunds.Text = "Фонд";
            this.btnFunds.UseVisualStyleBackColor = true;
            this.btnFunds.Click += new System.EventHandler(this.btnFunds_Click);
            // 
            // btnLibraries
            // 
            this.btnLibraries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibraries.Location = new System.Drawing.Point(13, 25);
            this.btnLibraries.Margin = new System.Windows.Forms.Padding(5);
            this.btnLibraries.Name = "btnLibraries";
            this.btnLibraries.Size = new System.Drawing.Size(198, 49);
            this.btnLibraries.TabIndex = 7;
            this.btnLibraries.Text = "Бібліотеки";
            this.btnLibraries.UseVisualStyleBackColor = true;
            this.btnLibraries.Click += new System.EventHandler(this.btnLibraries_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.cmbLibraries);
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Controls.Add(this.btnLoad);
            this.pnlTop.Controls.Add(this.cmbCities);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(237, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1284, 121);
            this.pnlTop.TabIndex = 6;
            // 
            // cmbLibraries
            // 
            this.cmbLibraries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbLibraries.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbLibraries.FormattingEnabled = true;
            this.cmbLibraries.Location = new System.Drawing.Point(611, 35);
            this.cmbLibraries.Margin = new System.Windows.Forms.Padding(5);
            this.cmbLibraries.Name = "cmbLibraries";
            this.cmbLibraries.Size = new System.Drawing.Size(439, 31);
            this.cmbLibraries.TabIndex = 9;
            this.cmbLibraries.SelectedValueChanged += new System.EventHandler(this.cmbLibraries_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Оберіть бібліотеку";
            // 
            // cmbCities
            // 
            this.cmbCities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCities.FormattingEnabled = true;
            this.cmbCities.Location = new System.Drawing.Point(201, 33);
            this.cmbCities.Margin = new System.Windows.Forms.Padding(5);
            this.cmbCities.Name = "cmbCities";
            this.cmbCities.Size = new System.Drawing.Size(205, 34);
            this.cmbCities.TabIndex = 4;
            this.cmbCities.SelectedValueChanged += new System.EventHandler(this.cmbCities_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Оберіть місто";
            // 
            // pnlElementControls
            // 
            this.pnlElementControls.Controls.Add(this.lblTotalCount);
            this.pnlElementControls.Controls.Add(this.label2);
            this.pnlElementControls.Controls.Add(this.btnEdit);
            this.pnlElementControls.Controls.Add(this.btnDelete);
            this.pnlElementControls.Controls.Add(this.btnAdd);
            this.pnlElementControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlElementControls.Location = new System.Drawing.Point(237, 121);
            this.pnlElementControls.Margin = new System.Windows.Forms.Padding(5);
            this.pnlElementControls.Name = "pnlElementControls";
            this.pnlElementControls.Size = new System.Drawing.Size(1284, 128);
            this.pnlElementControls.TabIndex = 7;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(986, 47);
            this.lblTotalCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(24, 26);
            this.lblTotalCount.TabIndex = 9;
            this.lblTotalCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(765, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Всього елементів";
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(286, 36);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(198, 49);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Редагувати";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(28, 36);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(198, 49);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(546, 36);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(198, 49);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(237, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 466);
            this.panel1.TabIndex = 8;
            // 
            // lstMain
            // 
            this.lstMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMain.FullRowSelect = true;
            this.lstMain.GridLines = true;
            this.lstMain.HideSelection = false;
            this.lstMain.Location = new System.Drawing.Point(0, 0);
            this.lstMain.Margin = new System.Windows.Forms.Padding(5);
            this.lstMain.Name = "lstMain";
            this.lstMain.Size = new System.Drawing.Size(1284, 466);
            this.lstMain.TabIndex = 4;
            this.lstMain.UseCompatibleStateImageBehavior = false;
            this.lstMain.View = System.Windows.Forms.View.Details;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 715);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlElementControls);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMenuButtons);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бібліотечний фонд міста";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlMenuButtons.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlElementControls.ResumeLayout(false);
            this.pnlElementControls.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel pnlMenuButtons;
        private System.Windows.Forms.Button btnVisits;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnFunds;
        private System.Windows.Forms.Button btnLibraries;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.ComboBox cmbLibraries;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlElementControls;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lstMain;
    }
}

