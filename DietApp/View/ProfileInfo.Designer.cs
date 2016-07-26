namespace DietApp.View
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
            this.inchesLabel = new System.Windows.Forms.Label();
            this.feetLabel = new System.Windows.Forms.Label();
            this.lbLabel = new System.Windows.Forms.Label();
            this.heightLable = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.goalLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudInitialWeight = new System.Windows.Forms.NumericUpDown();
            this.nudGoalWeight = new System.Windows.Forms.NumericUpDown();
            this.nudFootBox = new System.Windows.Forms.NumericUpDown();
            this.nudInchesBox = new System.Windows.Forms.NumericUpDown();
            this.nudDailyCalorieGoal = new System.Windows.Forms.NumericUpDown();
            this.dailyCalorieGoalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGoalWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFootBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInchesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDailyCalorieGoal)).BeginInit();
            this.SuspendLayout();
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(144, 175);
            this.emailBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(601, 35);
            this.emailBox.TabIndex = 6;
            this.emailBox.Tag = "Email Address";
            this.emailBox.TextChanged += new System.EventHandler(this.EnableUpdateButton);
            // 
            // lastNameBox
            // 
            this.lastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameBox.Location = new System.Drawing.Point(456, 92);
            this.lastNameBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(289, 35);
            this.lastNameBox.TabIndex = 4;
            this.lastNameBox.Tag = "Last Name";
            this.lastNameBox.TextChanged += new System.EventHandler(this.EnableUpdateButton);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(450, 57);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(128, 29);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(140, 142);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(169, 29);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email Address";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameBox.Location = new System.Drawing.Point(144, 92);
            this.firstNameBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(289, 35);
            this.firstNameBox.TabIndex = 2;
            this.firstNameBox.Tag = "First Name";
            this.firstNameBox.TextChanged += new System.EventHandler(this.EnableUpdateButton);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(138, 57);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(131, 29);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // inchesLabel
            // 
            this.inchesLabel.AutoSize = true;
            this.inchesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchesLabel.Location = new System.Drawing.Point(710, 388);
            this.inchesLabel.Name = "inchesLabel";
            this.inchesLabel.Size = new System.Drawing.Size(38, 29);
            this.inchesLabel.TabIndex = 19;
            this.inchesLabel.Text = "in.";
            // 
            // feetLabel
            // 
            this.feetLabel.AutoSize = true;
            this.feetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feetLabel.Location = new System.Drawing.Point(564, 388);
            this.feetLabel.Name = "feetLabel";
            this.feetLabel.Size = new System.Drawing.Size(31, 29);
            this.feetLabel.TabIndex = 17;
            this.feetLabel.Text = "ft.";
            // 
            // lbLabel
            // 
            this.lbLabel.AutoSize = true;
            this.lbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLabel.Location = new System.Drawing.Point(340, 278);
            this.lbLabel.Name = "lbLabel";
            this.lbLabel.Size = new System.Drawing.Size(39, 29);
            this.lbLabel.TabIndex = 9;
            this.lbLabel.Text = "lb.";
            // 
            // heightLable
            // 
            this.heightLable.AutoSize = true;
            this.heightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLable.Location = new System.Drawing.Point(-154, 449);
            this.heightLable.Name = "heightLable";
            this.heightLable.Size = new System.Drawing.Size(83, 29);
            this.heightLable.TabIndex = 50;
            this.heightLable.Text = "Height";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(450, 245);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(135, 29);
            this.usernameLabel.TabIndex = 10;
            this.usernameLabel.Text = "User Name";
            // 
            // usernameBox
            // 
            this.usernameBox.Enabled = false;
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(456, 275);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.ReadOnly = true;
            this.usernameBox.Size = new System.Drawing.Size(289, 35);
            this.usernameBox.TabIndex = 11;
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(570, 458);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(134, 46);
            this.updateButton.TabIndex = 22;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(138, 245);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(150, 29);
            this.weightLabel.TabIndex = 7;
            this.weightLabel.Text = "Initial Weight";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(452, 349);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(83, 29);
            this.heightLabel.TabIndex = 15;
            this.heightLabel.Text = "Height";
            // 
            // goalLabel
            // 
            this.goalLabel.AutoSize = true;
            this.goalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalLabel.Location = new System.Drawing.Point(140, 352);
            this.goalLabel.Name = "goalLabel";
            this.goalLabel.Size = new System.Drawing.Size(145, 29);
            this.goalLabel.TabIndex = 12;
            this.goalLabel.Text = "Goal Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "lb.";
            // 
            // nudInitialWeight
            // 
            this.nudInitialWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInitialWeight.Location = new System.Drawing.Point(146, 275);
            this.nudInitialWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudInitialWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInitialWeight.Name = "nudInitialWeight";
            this.nudInitialWeight.Size = new System.Drawing.Size(196, 35);
            this.nudInitialWeight.TabIndex = 8;
            this.nudInitialWeight.Tag = "Weight";
            this.nudInitialWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInitialWeight.TextChanged += new System.EventHandler(this.EnableUpdateButton);
            this.nudInitialWeight.ValueChanged += new System.EventHandler(this.EnableUpdateButton);
            // 
            // nudGoalWeight
            // 
            this.nudGoalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGoalWeight.Location = new System.Drawing.Point(146, 385);
            this.nudGoalWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGoalWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGoalWeight.Name = "nudGoalWeight";
            this.nudGoalWeight.Size = new System.Drawing.Size(196, 35);
            this.nudGoalWeight.TabIndex = 13;
            this.nudGoalWeight.Tag = "GoalWeight";
            this.nudGoalWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGoalWeight.TextChanged += new System.EventHandler(this.EnableUpdateButton);
            this.nudGoalWeight.ValueChanged += new System.EventHandler(this.EnableUpdateButton);
            // 
            // nudFootBox
            // 
            this.nudFootBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFootBox.Location = new System.Drawing.Point(454, 385);
            this.nudFootBox.Maximum = new decimal(new int[] {
            999,
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
            this.nudFootBox.TabIndex = 16;
            this.nudFootBox.Tag = "Height (ft.)";
            this.nudFootBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFootBox.TextChanged += new System.EventHandler(this.EnableUpdateButton);
            this.nudFootBox.ValueChanged += new System.EventHandler(this.EnableUpdateButton);
            // 
            // nudInchesBox
            // 
            this.nudInchesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInchesBox.Location = new System.Drawing.Point(602, 385);
            this.nudInchesBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudInchesBox.Name = "nudInchesBox";
            this.nudInchesBox.Size = new System.Drawing.Size(104, 35);
            this.nudInchesBox.TabIndex = 18;
            this.nudInchesBox.Tag = "Height (in.)";
            this.nudInchesBox.TextChanged += new System.EventHandler(this.EnableUpdateButton);
            this.nudInchesBox.ValueChanged += new System.EventHandler(this.EnableUpdateButton);
            // 
            // nudDailyCalorieGoal
            // 
            this.nudDailyCalorieGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDailyCalorieGoal.Location = new System.Drawing.Point(144, 491);
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
            this.nudDailyCalorieGoal.Size = new System.Drawing.Size(196, 35);
            this.nudDailyCalorieGoal.TabIndex = 21;
            this.nudDailyCalorieGoal.Tag = "DailyCalorieGoal";
            this.nudDailyCalorieGoal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDailyCalorieGoal.TextChanged += new System.EventHandler(this.EnableUpdateButton);
            this.nudDailyCalorieGoal.ValueChanged += new System.EventHandler(this.EnableUpdateButton);
            // 
            // dailyCalorieGoalLabel
            // 
            this.dailyCalorieGoalLabel.AutoSize = true;
            this.dailyCalorieGoalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyCalorieGoalLabel.Location = new System.Drawing.Point(138, 458);
            this.dailyCalorieGoalLabel.Name = "dailyCalorieGoalLabel";
            this.dailyCalorieGoalLabel.Size = new System.Drawing.Size(207, 29);
            this.dailyCalorieGoalLabel.TabIndex = 20;
            this.dailyCalorieGoalLabel.Text = "Daily Calorie Goal";
            // 
            // ProfileInfo
            // 
            this.AcceptButton = this.updateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 574);
            this.Controls.Add(this.nudDailyCalorieGoal);
            this.Controls.Add(this.dailyCalorieGoalLabel);
            this.Controls.Add(this.nudInchesBox);
            this.Controls.Add(this.nudFootBox);
            this.Controls.Add(this.nudGoalWeight);
            this.Controls.Add(this.nudInitialWeight);
            this.Controls.Add(this.goalLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.inchesLabel);
            this.Controls.Add(this.feetLabel);
            this.Controls.Add(this.lbLabel);
            this.Controls.Add(this.heightLable);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "ProfileInfo";
            this.Text = "My Profile";
            this.Load += new System.EventHandler(this.ProfileInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGoalWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFootBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInchesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDailyCalorieGoal)).EndInit();
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
        private System.Windows.Forms.Label inchesLabel;
        private System.Windows.Forms.Label feetLabel;
        private System.Windows.Forms.Label lbLabel;
        private System.Windows.Forms.Label heightLable;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label goalLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudInitialWeight;
        private System.Windows.Forms.NumericUpDown nudGoalWeight;
        private System.Windows.Forms.NumericUpDown nudFootBox;
        private System.Windows.Forms.NumericUpDown nudInchesBox;
        private System.Windows.Forms.NumericUpDown nudDailyCalorieGoal;
        private System.Windows.Forms.Label dailyCalorieGoalLabel;
    }
}