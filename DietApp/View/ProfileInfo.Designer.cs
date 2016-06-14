namespace DietApp
{
    partial class ProfileInfo
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
            this.emailBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(19, 83);
            this.emailBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.emailBox.Name = "emailBox";
            this.emailBox.ReadOnly = true;
            this.emailBox.Size = new System.Drawing.Size(402, 26);
            this.emailBox.TabIndex = 46;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameBox.Location = new System.Drawing.Point(227, 29);
            this.lastNameBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.ReadOnly = true;
            this.lastNameBox.Size = new System.Drawing.Size(194, 26);
            this.lastNameBox.TabIndex = 44;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(223, 6);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.lastNameLabel.TabIndex = 43;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(16, 61);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(111, 20);
            this.emailLabel.TabIndex = 42;
            this.emailLabel.Text = "Email Address";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameBox.Location = new System.Drawing.Point(19, 29);
            this.firstNameBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.ReadOnly = true;
            this.firstNameBox.Size = new System.Drawing.Size(194, 26);
            this.firstNameBox.TabIndex = 40;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(15, 6);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.firstNameLabel.TabIndex = 39;
            this.firstNameLabel.Text = "First Name";
            // 
            // ProfileInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 133);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.firstNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProfileInfo";
            this.Text = "My Profile";
            this.Load += new System.EventHandler(this.ProfileInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label firstNameLabel;
    }
}