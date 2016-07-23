﻿namespace DietApp
{
    partial class NewUser
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
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.confirmBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lsatNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.lbLabel = new System.Windows.Forms.Label();
            this.feetLabel = new System.Windows.Forms.Label();
            this.inchesLabel = new System.Windows.Forms.Label();
            this.lbLabel2 = new System.Windows.Forms.Label();
            this.goalWeightLabel = new System.Windows.Forms.Label();
            this.nudInchesBox = new System.Windows.Forms.NumericUpDown();
            this.nudFootBox = new System.Windows.Forms.NumericUpDown();
            this.nudGoalWeightBox = new System.Windows.Forms.NumericUpDown();
            this.nudWeightBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudInchesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFootBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGoalWeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeightBox)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(383, 58);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(78, 20);
            this.passwordLabel.TabIndex = 16;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(383, 25);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(89, 20);
            this.usernameLabel.TabIndex = 14;
            this.usernameLabel.Text = "User Name";
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(531, 58);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(215, 26);
            this.passwordBox.TabIndex = 17;
            this.passwordBox.Tag = "Password";
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(531, 25);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(215, 26);
            this.usernameBox.TabIndex = 15;
            this.usernameBox.Tag = "User Name";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(599, 161);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(68, 30);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(499, 161);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(68, 30);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveUser_Click);
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmLabel.Location = new System.Drawing.Point(383, 95);
            this.confirmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(137, 20);
            this.confirmLabel.TabIndex = 18;
            this.confirmLabel.Text = "Confirm Password";
            // 
            // confirmBox
            // 
            this.confirmBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBox.Location = new System.Drawing.Point(531, 95);
            this.confirmBox.Margin = new System.Windows.Forms.Padding(2);
            this.confirmBox.Name = "confirmBox";
            this.confirmBox.PasswordChar = '*';
            this.confirmBox.Size = new System.Drawing.Size(215, 26);
            this.confirmBox.TabIndex = 19;
            this.confirmBox.Tag = "Confirm Password";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameBox.Location = new System.Drawing.Point(159, 25);
            this.firstNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(215, 26);
            this.firstNameBox.TabIndex = 1;
            this.firstNameBox.Tag = "First Name";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameBox.Location = new System.Drawing.Point(159, 64);
            this.lastNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(215, 26);
            this.lastNameBox.TabIndex = 3;
            this.lastNameBox.Tag = "Last Name";
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(159, 101);
            this.emailBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(215, 26);
            this.emailBox.TabIndex = 5;
            this.emailBox.Tag = "eMail";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(15, 25);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.firstNameLabel.TabIndex = 22;
            this.firstNameLabel.Text = "First Name";
            // 
            // lsatNameLabel
            // 
            this.lsatNameLabel.AutoSize = true;
            this.lsatNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsatNameLabel.Location = new System.Drawing.Point(11, 64);
            this.lsatNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lsatNameLabel.Name = "lsatNameLabel";
            this.lsatNameLabel.Size = new System.Drawing.Size(86, 20);
            this.lsatNameLabel.TabIndex = 2;
            this.lsatNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(15, 101);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(53, 20);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "E-Mail";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(15, 146);
            this.weightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(59, 20);
            this.weightLabel.TabIndex = 6;
            this.weightLabel.Text = "Weight";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(15, 222);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(56, 20);
            this.heightLabel.TabIndex = 9;
            this.heightLabel.Text = "Height";
            // 
            // lbLabel
            // 
            this.lbLabel.AutoSize = true;
            this.lbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLabel.Location = new System.Drawing.Point(346, 150);
            this.lbLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLabel.Name = "lbLabel";
            this.lbLabel.Size = new System.Drawing.Size(25, 20);
            this.lbLabel.TabIndex = 8;
            this.lbLabel.Text = "lb.";
            // 
            // feetLabel
            // 
            this.feetLabel.AutoSize = true;
            this.feetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feetLabel.Location = new System.Drawing.Point(231, 226);
            this.feetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.feetLabel.Name = "feetLabel";
            this.feetLabel.Size = new System.Drawing.Size(23, 20);
            this.feetLabel.TabIndex = 11;
            this.feetLabel.Text = "ft.";
            // 
            // inchesLabel
            // 
            this.inchesLabel.AutoSize = true;
            this.inchesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchesLabel.Location = new System.Drawing.Point(342, 226);
            this.inchesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inchesLabel.Name = "inchesLabel";
            this.inchesLabel.Size = new System.Drawing.Size(25, 20);
            this.inchesLabel.TabIndex = 13;
            this.inchesLabel.Text = "in.";
            // 
            // lbLabel2
            // 
            this.lbLabel2.AutoSize = true;
            this.lbLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLabel2.Location = new System.Drawing.Point(346, 188);
            this.lbLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLabel2.Name = "lbLabel2";
            this.lbLabel2.Size = new System.Drawing.Size(25, 20);
            this.lbLabel2.TabIndex = 25;
            this.lbLabel2.Text = "lb.";
            // 
            // goalWeightLabel
            // 
            this.goalWeightLabel.AutoSize = true;
            this.goalWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalWeightLabel.Location = new System.Drawing.Point(15, 184);
            this.goalWeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.goalWeightLabel.Name = "goalWeightLabel";
            this.goalWeightLabel.Size = new System.Drawing.Size(97, 20);
            this.goalWeightLabel.TabIndex = 23;
            this.goalWeightLabel.Text = "Goal Weight";
            // 
            // nudInchesBox
            // 
            this.nudInchesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInchesBox.Location = new System.Drawing.Point(270, 222);
            this.nudInchesBox.Margin = new System.Windows.Forms.Padding(2);
            this.nudInchesBox.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.nudInchesBox.Name = "nudInchesBox";
            this.nudInchesBox.Size = new System.Drawing.Size(69, 26);
            this.nudInchesBox.TabIndex = 12;
            this.nudInchesBox.Tag = "Height (in.)";
            // 
            // nudFootBox
            // 
            this.nudFootBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFootBox.Location = new System.Drawing.Point(159, 222);
            this.nudFootBox.Margin = new System.Windows.Forms.Padding(2);
            this.nudFootBox.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudFootBox.Name = "nudFootBox";
            this.nudFootBox.Size = new System.Drawing.Size(70, 26);
            this.nudFootBox.TabIndex = 10;
            this.nudFootBox.Tag = "Height (ft.)";
            // 
            // nudGoalWeightBox
            // 
            this.nudGoalWeightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGoalWeightBox.Location = new System.Drawing.Point(159, 184);
            this.nudGoalWeightBox.Margin = new System.Windows.Forms.Padding(2);
            this.nudGoalWeightBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGoalWeightBox.Name = "nudGoalWeightBox";
            this.nudGoalWeightBox.Size = new System.Drawing.Size(181, 26);
            this.nudGoalWeightBox.TabIndex = 24;
            this.nudGoalWeightBox.Tag = "Weight";
            // 
            // nudWeightBox
            // 
            this.nudWeightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWeightBox.Location = new System.Drawing.Point(159, 146);
            this.nudWeightBox.Margin = new System.Windows.Forms.Padding(2);
            this.nudWeightBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudWeightBox.Name = "nudWeightBox";
            this.nudWeightBox.Size = new System.Drawing.Size(181, 26);
            this.nudWeightBox.TabIndex = 7;
            this.nudWeightBox.Tag = "Weight";
            // 
            // NewUser
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(765, 281);
            this.Controls.Add(this.nudWeightBox);
            this.Controls.Add(this.nudGoalWeightBox);
            this.Controls.Add(this.nudFootBox);
            this.Controls.Add(this.nudInchesBox);
            this.Controls.Add(this.lbLabel2);
            this.Controls.Add(this.goalWeightLabel);
            this.Controls.Add(this.inchesLabel);
            this.Controls.Add(this.feetLabel);
            this.Controls.Add(this.lbLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lsatNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.confirmBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewUser";
            this.Text = "Health Trends : New User";
            ((System.ComponentModel.ISupportInitialize)(this.nudInchesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFootBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGoalWeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeightBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.TextBox confirmBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lsatNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label lbLabel;
        private System.Windows.Forms.Label feetLabel;
        private System.Windows.Forms.Label inchesLabel;
        private System.Windows.Forms.Label lbLabel2;
        private System.Windows.Forms.Label goalWeightLabel;
        private System.Windows.Forms.NumericUpDown nudInchesBox;
        private System.Windows.Forms.NumericUpDown nudFootBox;
        private System.Windows.Forms.NumericUpDown nudGoalWeightBox;
        private System.Windows.Forms.NumericUpDown nudWeightBox;
    }
}