
namespace CityLibraryFund.ControlForms
{
    partial class frmLibrary
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstReadingRooms = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeleteReadingRoom = new System.Windows.Forms.Button();
            this.btnAddReadingRoom = new System.Windows.Forms.Button();
            this.btnRemoveStorageRoom = new System.Windows.Forms.Button();
            this.btnAddStorageRoom = new System.Windows.Forms.Button();
            this.lstStorageRooms = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(141, 30);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(236, 30);
            this.txtId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ідентифікатор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Назва";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(141, 80);
            this.txtName.MaxLength = 128;
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 76);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Місто";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Адреса";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(141, 177);
            this.txtCity.MaxLength = 32;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(236, 30);
            this.txtCity.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(141, 229);
            this.txtAddress.MaxLength = 255;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(236, 76);
            this.txtAddress.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(386, 349);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 44);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstReadingRooms
            // 
            this.lstReadingRooms.FormattingEnabled = true;
            this.lstReadingRooms.ItemHeight = 23;
            this.lstReadingRooms.Location = new System.Drawing.Point(454, 59);
            this.lstReadingRooms.Name = "lstReadingRooms";
            this.lstReadingRooms.Size = new System.Drawing.Size(326, 96);
            this.lstReadingRooms.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "Кімнати сховища";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Читальні зали";
            // 
            // btnDeleteReadingRoom
            // 
            this.btnDeleteReadingRoom.Location = new System.Drawing.Point(786, 118);
            this.btnDeleteReadingRoom.Name = "btnDeleteReadingRoom";
            this.btnDeleteReadingRoom.Size = new System.Drawing.Size(101, 37);
            this.btnDeleteReadingRoom.TabIndex = 31;
            this.btnDeleteReadingRoom.Text = "Видалити";
            this.btnDeleteReadingRoom.UseVisualStyleBackColor = true;
            // 
            // btnAddReadingRoom
            // 
            this.btnAddReadingRoom.Location = new System.Drawing.Point(786, 59);
            this.btnAddReadingRoom.Name = "btnAddReadingRoom";
            this.btnAddReadingRoom.Size = new System.Drawing.Size(101, 37);
            this.btnAddReadingRoom.TabIndex = 30;
            this.btnAddReadingRoom.Text = "Додати";
            this.btnAddReadingRoom.UseVisualStyleBackColor = true;
            // 
            // btnRemoveStorageRoom
            // 
            this.btnRemoveStorageRoom.Location = new System.Drawing.Point(786, 268);
            this.btnRemoveStorageRoom.Name = "btnRemoveStorageRoom";
            this.btnRemoveStorageRoom.Size = new System.Drawing.Size(101, 37);
            this.btnRemoveStorageRoom.TabIndex = 34;
            this.btnRemoveStorageRoom.Text = "Видалити";
            this.btnRemoveStorageRoom.UseVisualStyleBackColor = true;
            // 
            // btnAddStorageRoom
            // 
            this.btnAddStorageRoom.Location = new System.Drawing.Point(786, 209);
            this.btnAddStorageRoom.Name = "btnAddStorageRoom";
            this.btnAddStorageRoom.Size = new System.Drawing.Size(101, 37);
            this.btnAddStorageRoom.TabIndex = 33;
            this.btnAddStorageRoom.Text = "Додати";
            this.btnAddStorageRoom.UseVisualStyleBackColor = true;
            // 
            // lstStorageRooms
            // 
            this.lstStorageRooms.FormattingEnabled = true;
            this.lstStorageRooms.ItemHeight = 23;
            this.lstStorageRooms.Location = new System.Drawing.Point(454, 209);
            this.lstStorageRooms.Name = "lstStorageRooms";
            this.lstStorageRooms.Size = new System.Drawing.Size(326, 96);
            this.lstStorageRooms.TabIndex = 32;
            // 
            // frmLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 405);
            this.Controls.Add(this.btnRemoveStorageRoom);
            this.Controls.Add(this.btnAddStorageRoom);
            this.Controls.Add(this.lstStorageRooms);
            this.Controls.Add(this.btnDeleteReadingRoom);
            this.Controls.Add(this.btnAddReadingRoom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstReadingRooms);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Бібліотека";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lstReadingRooms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeleteReadingRoom;
        private System.Windows.Forms.Button btnAddReadingRoom;
        private System.Windows.Forms.Button btnRemoveStorageRoom;
        private System.Windows.Forms.Button btnAddStorageRoom;
        private System.Windows.Forms.ListBox lstStorageRooms;
    }
}