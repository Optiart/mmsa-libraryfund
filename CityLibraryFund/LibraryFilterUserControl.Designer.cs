
namespace CityLibraryFund
{
    partial class LibraryFilterUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbLibraries = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCities = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbLibraries
            // 
            this.cmbLibraries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbLibraries.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbLibraries.FormattingEnabled = true;
            this.cmbLibraries.Location = new System.Drawing.Point(526, 32);
            this.cmbLibraries.Margin = new System.Windows.Forms.Padding(9);
            this.cmbLibraries.Name = "cmbLibraries";
            this.cmbLibraries.Size = new System.Drawing.Size(378, 31);
            this.cmbLibraries.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Оберіть бібліотеку";
            // 
            // cmbCities
            // 
            this.cmbCities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCities.FormattingEnabled = true;
            this.cmbCities.Location = new System.Drawing.Point(147, 29);
            this.cmbCities.Margin = new System.Windows.Forms.Padding(9);
            this.cmbCities.Name = "cmbCities";
            this.cmbCities.Size = new System.Drawing.Size(169, 34);
            this.cmbCities.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Оберіть місто";
            // 
            // LibraryFilterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbLibraries);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCities);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LibraryFilterUserControl";
            this.Size = new System.Drawing.Size(921, 96);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLibraries;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCities;
        private System.Windows.Forms.Label label1;
    }
}
