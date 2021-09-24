
namespace CityLibraryFund.ControlForms
{
    partial class frmReadingRoom
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rdButtonExisting = new System.Windows.Forms.RadioButton();
            this.rdButtonNew = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(341, 31);
            this.comboBox1.TabIndex = 1;
            // 
            // rdButtonExisting
            // 
            this.rdButtonExisting.AutoSize = true;
            this.rdButtonExisting.Location = new System.Drawing.Point(24, 102);
            this.rdButtonExisting.Name = "rdButtonExisting";
            this.rdButtonExisting.Size = new System.Drawing.Size(106, 27);
            this.rdButtonExisting.TabIndex = 2;
            this.rdButtonExisting.Text = "Існуючий";
            this.rdButtonExisting.UseVisualStyleBackColor = true;
            // 
            // rdButtonNew
            // 
            this.rdButtonNew.AutoSize = true;
            this.rdButtonNew.Checked = true;
            this.rdButtonNew.Location = new System.Drawing.Point(24, 29);
            this.rdButtonNew.Name = "rdButtonNew";
            this.rdButtonNew.Size = new System.Drawing.Size(77, 27);
            this.rdButtonNew.TabIndex = 3;
            this.rdButtonNew.TabStop = true;
            this.rdButtonNew.Text = "Новий";
            this.rdButtonNew.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(189, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 44);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 30);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Назва";
            // 
            // frmReadingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rdButtonNew);
            this.Controls.Add(this.rdButtonExisting);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReadingRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Читальний зал";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rdButtonExisting;
        private System.Windows.Forms.RadioButton rdButtonNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}