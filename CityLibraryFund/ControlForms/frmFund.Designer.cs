
namespace CityLibraryFund.ControlForms
{
    partial class frmFund
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUniqueNumber = new System.Windows.Forms.Label();
            this.txtUniqueNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtPublished = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lstAuthors = new System.Windows.Forms.ListBox();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbAuthors = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddLibrary = new System.Windows.Forms.Button();
            this.lstStorage = new System.Windows.Forms.ListBox();
            this.btnDeleteLibrary = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIssueNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ідентифікатор";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(171, 22);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(236, 30);
            this.txtId.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(171, 78);
            this.txtName.MaxLength = 128;
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 76);
            this.txtName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Назва";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Категорія";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(171, 175);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(236, 31);
            this.cmbCategory.TabIndex = 7;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(171, 230);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(236, 31);
            this.cmbType.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Тип";
            // 
            // lblUniqueNumber
            // 
            this.lblUniqueNumber.Location = new System.Drawing.Point(11, 283);
            this.lblUniqueNumber.Name = "lblUniqueNumber";
            this.lblUniqueNumber.Size = new System.Drawing.Size(154, 30);
            this.lblUniqueNumber.TabIndex = 10;
            this.lblUniqueNumber.Text = "Унікальний номер";
            this.lblUniqueNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtUniqueNumber
            // 
            this.txtUniqueNumber.Location = new System.Drawing.Point(171, 283);
            this.txtUniqueNumber.MaxLength = 32;
            this.txtUniqueNumber.Name = "txtUniqueNumber";
            this.txtUniqueNumber.Size = new System.Drawing.Size(236, 30);
            this.txtUniqueNumber.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дата публікації";
            // 
            // dtPublished
            // 
            this.dtPublished.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPublished.Location = new System.Drawing.Point(171, 379);
            this.dtPublished.Name = "dtPublished";
            this.dtPublished.Size = new System.Drawing.Size(236, 30);
            this.dtPublished.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Автори";
            // 
            // lstAuthors
            // 
            this.lstAuthors.FormattingEnabled = true;
            this.lstAuthors.ItemHeight = 23;
            this.lstAuthors.Location = new System.Drawing.Point(573, 78);
            this.lstAuthors.Name = "lstAuthors";
            this.lstAuthors.Size = new System.Drawing.Size(299, 96);
            this.lstAuthors.TabIndex = 15;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(878, 18);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(101, 37);
            this.btnAddAuthor.TabIndex = 16;
            this.btnAddAuthor.Text = "Додати";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(878, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 37);
            this.button2.TabIndex = 17;
            this.button2.Text = "Видалити";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmbAuthors
            // 
            this.cmbAuthors.FormattingEnabled = true;
            this.cmbAuthors.Location = new System.Drawing.Point(573, 19);
            this.cmbAuthors.Name = "cmbAuthors";
            this.cmbAuthors.Size = new System.Drawing.Size(299, 31);
            this.cmbAuthors.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(501, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Розташування";
            // 
            // btnAddLibrary
            // 
            this.btnAddLibrary.Location = new System.Drawing.Point(878, 247);
            this.btnAddLibrary.Name = "btnAddLibrary";
            this.btnAddLibrary.Size = new System.Drawing.Size(101, 37);
            this.btnAddLibrary.TabIndex = 24;
            this.btnAddLibrary.Text = "Додати";
            this.btnAddLibrary.UseVisualStyleBackColor = true;
            // 
            // lstStorage
            // 
            this.lstStorage.FormattingEnabled = true;
            this.lstStorage.ItemHeight = 23;
            this.lstStorage.Location = new System.Drawing.Point(501, 247);
            this.lstStorage.Name = "lstStorage";
            this.lstStorage.Size = new System.Drawing.Size(371, 165);
            this.lstStorage.TabIndex = 25;
            // 
            // btnDeleteLibrary
            // 
            this.btnDeleteLibrary.Location = new System.Drawing.Point(878, 305);
            this.btnDeleteLibrary.Name = "btnDeleteLibrary";
            this.btnDeleteLibrary.Size = new System.Drawing.Size(101, 37);
            this.btnDeleteLibrary.TabIndex = 26;
            this.btnDeleteLibrary.Text = "Видалити";
            this.btnDeleteLibrary.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(452, 477);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 37);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 30);
            this.label5.TabIndex = 28;
            this.label5.Text = "Випуск";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtIssueNumber
            // 
            this.txtIssueNumber.Location = new System.Drawing.Point(171, 331);
            this.txtIssueNumber.MaxLength = 32;
            this.txtIssueNumber.Name = "txtIssueNumber";
            this.txtIssueNumber.Size = new System.Drawing.Size(104, 30);
            this.txtIssueNumber.TabIndex = 29;
            // 
            // frmFund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 526);
            this.Controls.Add(this.txtIssueNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDeleteLibrary);
            this.Controls.Add(this.lstStorage);
            this.Controls.Add(this.btnAddLibrary);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbAuthors);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.lstAuthors);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtPublished);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUniqueNumber);
            this.Controls.Add(this.lblUniqueNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFund";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фонд";
            this.Load += new System.EventHandler(this.frmFund_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUniqueNumber;
        private System.Windows.Forms.TextBox txtUniqueNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtPublished;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstAuthors;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbAuthors;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddLibrary;
        private System.Windows.Forms.ListBox lstStorage;
        private System.Windows.Forms.Button btnDeleteLibrary;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIssueNumber;
    }
}