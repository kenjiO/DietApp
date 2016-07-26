namespace DietApp
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
            this.nudDailyCalorieGoal = new System.Windows.Forms.NumericUpDown();
            this.dailyCalorieGoalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudInchesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFootBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGoalWeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDailyCalorieGoal)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(574, 89);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(120, 29);
            this.passwordLabel.TabIndex = 16;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(574, 38);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(135, 29);
            this.usernameLabel.TabIndex = 14;
            this.usernameLabel.Text = "User Name";
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(796, 89);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(320, 35);
            this.passwordBox.TabIndex = 17;
            this.passwordBox.Tag = "Password";
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(796, 38);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(320, 35);
            this.usernameBox.TabIndex = 15;
            this.usernameBox.Tag = "User Name";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(904, 289);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(102, 46);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(754, 289);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(102, 46);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveUser_Click);
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmLabel.Location = new System.Drawing.Point(574, 146);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(210, 29);
            this.confirmLabel.TabIndex = 18;
            this.confirmLabel.Text = "Confirm Password";
            // 
            // confirmBox
            // 
            this.confirmBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBox.Location = new System.Drawing.Point(796, 146);
            this.confirmBox.Name = "confirmBox";
            this.confirmBox.PasswordChar = '*';
            this.confirmBox.Size = new System.Drawing.Size(320, 35);
            this.confirmBox.TabIndex = 19;
            this.confirmBox.Tag = "Confirm Password";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameBox.Location = new System.Drawing.Point(238, 38);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(320, 35);
            this.firstNameBox.TabIndex = 1;
            this.firstNameBox.Tag = "First Name";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameBox.Location = new System.Drawing.Point(238, 98);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(320, 35);
            this.lastNameBox.TabIndex = 3;
            this.lastNameBox.Tag = "Last Name";
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(238, 155);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(320, 35);
            this.emailBox.TabIndex = 5;
            this.emailBox.Tag = "eMail";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(22, 38);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(131, 29);
            this.firstNameLabel.TabIndex = 22;
            this.firstNameLabel.Text = "First Name";
            // 
            // lsatNameLabel
            // 
            this.lsatNameLabel.AutoSize = true;
            this.lsatNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsatNameLabel.Location = new System.Drawing.Point(16, 98);
            this.lsatNameLabel.Name = "lsatNameLabel";
            this.lsatNameLabel.Size = new System.Drawing.Size(128, 29);
            this.lsatNameLabel.TabIndex = 2;
            this.lsatNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(22, 155);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(82, 29);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "E-Mail";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(22, 225);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(88, 29);
            this.weightLabel.TabIndex = 6;
            this.weightLabel.Text = "Weight";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(22, 342);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(83, 29);
            this.heightLabel.TabIndex = 9;
            this.heightLabel.Text = "Height";
            // 
            // lbLabel
            // 
            this.lbLabel.AutoSize = true;
            this.lbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLabel.Location = new System.Drawing.Point(519, 231);
            this.lbLabel.Name = "lbLabel";
            this.lbLabel.Size = new System.Drawing.Size(39, 29);
            this.lbLabel.TabIndex = 8;
            this.lbLabel.Text = "lb.";
            // 
            // feetLabel
            // 
            this.feetLabel.AutoSize = true;
            this.feetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feetLabel.Location = new System.Drawing.Point(346, 348);
            this.feetLabel.Name = "feetLabel";
            this.feetLabel.Size = new System.Drawing.Size(31, 29);
            this.feetLabel.TabIndex = 11;
            this.feetLabel.Text = "ft.";
            // 
            // inchesLabel
            // 
            this.inchesLabel.AutoSize = true;
            this.inchesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchesLabel.Location = new System.Drawing.Point(513, 348);
            this.inchesLabel.Name = "inchesLabel";
            this.inchesLabel.Size = new System.Drawing.Size(38, 29);
            this.inchesLabel.TabIndex = 13;
            this.inchesLabel.Text = "in.";
            // 
            // lbLabel2
            // 
            this.lbLabel2.AutoSize = true;
            this.lbLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLabel2.Location = new System.Drawing.Point(519, 289);
            this.lbLabel2.Name = "lbLabel2";
            this.lbLabel2.Size = new System.Drawing.Size(39, 29);
            this.lbLabel2.TabIndex = 25;
            this.lbLabel2.Text = "lb.";
            // 
            // goalWeightLabel
            // 
            this.goalWeightLabel.AutoSize = true;
            this.goalWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalWeightLabel.Location = new System.Drawing.Point(22, 283);
            this.goalWeightLabel.Name = "goalWeightLabel";
            this.goalWeightLabel.Size = new System.Drawing.Size(145, 29);
            this.goalWeightLabel.TabIndex = 23;
            this.goalWeightLabel.Text = "Goal Weight";
            // 
            // nudInchesBox
            // 
            this.nudInchesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInchesBox.Location = new System.Drawing.Point(405, 342);
            this.nudInchesBox.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.nudInchesBox.Name = "nudInchesBox";
            this.nudInchesBox.Size = new System.Drawing.Size(104, 35);
            this.nudInchesBox.TabIndex = 12;
            this.nudInchesBox.Tag = "Height (in.)";
            // 
            // nudFootBox
            // 
            this.nudFootBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFootBox.Location = new System.Drawing.Point(238, 342);
            this.nudFootBox.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudFootBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFootBox.Name = "nudFootBox";
            this.nudFootBox.Size = new System.Drawing.Size(105, 35);
            this.nudFootBox.TabIndex = 10;
            this.nudFootBox.Tag = "Height (ft.)";
            this.nudFootBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudGoalWeightBox
            // 
            this.nudGoalWeightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGoalWeightBox.Location = new System.Drawing.Point(238, 283);
            this.nudGoalWeightBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGoalWeightBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGoalWeightBox.Name = "nudGoalWeightBox";
            this.nudGoalWeightBox.Size = new System.Drawing.Size(272, 35);
            this.nudGoalWeightBox.TabIndex = 24;
            this.nudGoalWeightBox.Tag = "Weight";
            this.nudGoalWeightBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudWeightBox
            // 
            this.nudWeightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWeightBox.Location = new System.Drawing.Point(238, 225);
            this.nudWeightBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudWeightBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWeightBox.Name = "nudWeightBox";
            this.nudWeightBox.Size = new System.Drawing.Size(272, 35);
            this.nudWeightBox.TabIndex = 7;
            this.nudWeightBox.Tag = "Weight";
            this.nudWeightBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDailyCalorieGoal
            // 
            this.nudDailyCalorieGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDailyCalorieGoal.Location = new System.Drawing.Point(796, 219);
            this.nudDailyCalorieGoal.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDailyCalorieGoal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDailyCalorieGoal.Name = "nudDailyCalorieGoal";
            this.nudDailyCalorieGoal.Size = new System.Drawing.Size(272, 35);
            this.nudDailyCalorieGoal.TabIndex = 27;
            this.nudDailyCalorieGoal.Tag = "DailyCalorieGoal";
            this.nudDailyCalorieGoal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dailyCalorieGoalLabel
            // 
            this.dailyCalorieGoalLabel.AutoSize = true;
            this.dailyCalorieGoalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyCalorieGoalLabel.Location = new System.Drawing.Point(580, 219);
            this.dailyCalorieGoalLabel.Name = "dailyCalorieGoalLabel";
            this.dailyCalorieGoalLabel.Size = new System.Drawing.Size(207, 29);
            this.dailyCalorieGoalLabel.TabIndex = 26;
            this.dailyCalorieGoalLabel.Text = "Daily Calorie Goal";
            // 
            // NewUser
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1148, 432);
            this.Controls.Add(this.nudDailyCalorieGoal);
            this.Controls.Add(this.dailyCalorieGoalLabel);
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
            this.Name = "NewUser";
            this.Text = "Health Trends : New User";
            ((System.ComponentModel.ISupportInitialize)(this.nudInchesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFootBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGoalWeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDailyCalorieGoal)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nudDailyCalorieGoal;
        private System.Windows.Forms.Label dailyCalorieGoalLabel;
    }
}