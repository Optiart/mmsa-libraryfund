
namespace CityLibraryFund
{
    partial class MenuUserControl
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
            this.btnVisits = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnFunds = new System.Windows.Forms.Button();
            this.btnLibraries = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVisits
            // 
            this.btnVisits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisits.Location = new System.Drawing.Point(4, 410);
            this.btnVisits.Margin = new System.Windows.Forms.Padding(5);
            this.btnVisits.Name = "btnVisits";
            this.btnVisits.Size = new System.Drawing.Size(198, 49);
            this.btnVisits.TabIndex = 14;
            this.btnVisits.Text = "Відвідування";
            this.btnVisits.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.Location = new System.Drawing.Point(4, 309);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(5);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(198, 49);
            this.btnUsers.TabIndex = 13;
            this.btnUsers.Text = "Користувачі";
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnFunds
            // 
            this.btnFunds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFunds.Location = new System.Drawing.Point(5, 100);
            this.btnFunds.Margin = new System.Windows.Forms.Padding(5);
            this.btnFunds.Name = "btnFunds";
            this.btnFunds.Size = new System.Drawing.Size(198, 49);
            this.btnFunds.TabIndex = 12;
            this.btnFunds.Text = "Фонди";
            this.btnFunds.UseVisualStyleBackColor = true;
            this.btnFunds.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // btnLibraries
            // 
            this.btnLibraries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibraries.Location = new System.Drawing.Point(5, 5);
            this.btnLibraries.Margin = new System.Windows.Forms.Padding(5);
            this.btnLibraries.Name = "btnLibraries";
            this.btnLibraries.Size = new System.Drawing.Size(198, 49);
            this.btnLibraries.TabIndex = 11;
            this.btnLibraries.Text = "Бібліотеки";
            this.btnLibraries.UseVisualStyleBackColor = true;
            this.btnLibraries.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(5, 204);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 49);
            this.button1.TabIndex = 15;
            this.button1.Text = "Автори";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVisits);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnFunds);
            this.Controls.Add(this.btnLibraries);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MenuUserControl";
            this.Size = new System.Drawing.Size(207, 486);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVisits;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnFunds;
        private System.Windows.Forms.Button btnLibraries;
        private System.Windows.Forms.Button button1;
    }
}
