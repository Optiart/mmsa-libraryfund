
namespace CityLibraryFund.ControlForms
{
    partial class frmStorageRoom
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.rdButtonNew = new System.Windows.Forms.RadioButton();
            this.rdButtonExisting = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Назва";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 30);
            this.textBox1.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(195, 177);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 44);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // rdButtonNew
            // 
            this.rdButtonNew.AutoSize = true;
            this.rdButtonNew.Checked = true;
            this.rdButtonNew.Location = new System.Drawing.Point(30, 39);
            this.rdButtonNew.Name = "rdButtonNew";
            this.rdButtonNew.Size = new System.Drawing.Size(65, 27);
            this.rdButtonNew.TabIndex = 14;
            this.rdButtonNew.TabStop = true;
            this.rdButtonNew.Text = "Нова";
            this.rdButtonNew.UseVisualStyleBackColor = true;
            // 
            // rdButtonExisting
            // 
            this.rdButtonExisting.AutoSize = true;
            this.rdButtonExisting.Location = new System.Drawing.Point(30, 112);
            this.rdButtonExisting.Name = "rdButtonExisting";
            this.rdButtonExisting.Size = new System.Drawing.Size(94, 27);
            this.rdButtonExisting.TabIndex = 13;
            this.rdButtonExisting.Text = "Існуюча";
            this.rdButtonExisting.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(154, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(341, 31);
            this.comboBox1.TabIndex = 12;
            // 
            // frmStorageRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rdButtonNew);
            this.Controls.Add(this.rdButtonExisting);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmStorageRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кімната сховища";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdButtonNew;
        private System.Windows.Forms.RadioButton rdButtonExisting;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}