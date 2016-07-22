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
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGoalWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFootBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInchesBox)).BeginInit();
            this.SuspendLayout();
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(96, 114);
            this.emailBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(402, 26);
            this.emailBox.TabIndex = 6;
            this.emailBox.Tag = "Email Address";
            this.emailBox.TextChanged += new System.EventHandler(this.EnableUpdateButton);
            // 
            // lastNameBox
            // 
            this.lastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameBox.Location = new System.Drawing.Point(304, 60);
            this.lastNameBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(194, 26);
            this.lastNameBox.TabIndex = 4;
            this.lastNameBox.Tag = "Last Name";
            this.lastNameBox.TextChanged += new System.EventHandler(this.EnableUpdateButton);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(300, 37);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(93, 92);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(111, 20);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email Address";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameBox.Location = new System.Drawing.Point(96, 60);
            this.firstNameBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(194, 26);
            this.firstNameBox.TabIndex = 2;
            this.firstNameBox.Tag = "First Name";
            this.firstNameBox.TextChanged += new System.EventHandler(this.EnableUpdateButton);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(92, 37);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // inchesLabel
            // 
            this.inchesLabel.AutoSize = true;
            this.inchesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchesLabel.Location = new System.Drawing.Point(473, 252);
            this.inchesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inchesLabel.Name = "inchesLabel";
            this.inchesLabel.Size = new System.Drawing.Size(25, 20);
            this.inchesLabel.TabIndex = 19;
            this.inchesLabel.Text = "in.";
            // 
            // feetLabel
            // 
            this.feetLabel.AutoSize = true;
            this.feetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feetLabel.Location = new System.Drawing.Point(376, 252);
            this.feetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.feetLabel.Name = "feetLabel";
            this.feetLabel.Size = new System.Drawing.Size(23, 20);
            this.feetLabel.TabIndex = 17;
            this.feetLabel.Text = "ft.";
            // 
            // lbLabel
            // 
            this.lbLabel.AutoSize = true;
            this.lbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLabel.Location = new System.Drawing.Point(227, 181);
            this.lbLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLabel.Name = "lbLabel";
            this.lbLabel.Size = new System.Drawing.Size(25, 20);
            this.lbLabel.TabIndex = 9;
            this.lbLabel.Text = "lb.";
            // 
            // heightLable
            // 
            this.heightLable.AutoSize = true;
            this.heightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLable.Location = new System.Drawing.Point(-103, 292);
            this.heightLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heightLable.Name = "heightLable";
            this.heightLable.Size = new System.Drawing.Size(56, 20);
            this.heightLable.TabIndex = 50;
            this.heightLable.Text = "Height";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(300, 159);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(89, 20);
            this.usernameLabel.TabIndex = 10;
            this.usernameLabel.Text = "User Name";
            // 
            // usernameBox
            // 
            this.usernameBox.Enabled = false;
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(304, 179);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.ReadOnly = true;
            this.usernameBox.Size = new System.Drawing.Size(194, 26);
            this.usernameBox.TabIndex = 11;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(380, 298);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(89, 30);
            this.updateButton.TabIndex = 20;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(92, 159);
            this.weightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(100, 20);
            this.weightLabel.TabIndex = 7;
            this.weightLabel.Text = "Initial Weight";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(301, 227);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(56, 20);
            this.heightLabel.TabIndex = 15;
            this.heightLabel.Text = "Height";
            // 
            // goalLabel
            // 
            this.goalLabel.AutoSize = true;
            this.goalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalLabel.Location = new System.Drawing.Point(93, 229);
            this.goalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.goalLabel.Name = "goalLabel";
            this.goalLabel.Size = new System.Drawing.Size(97, 20);
            this.goalLabel.TabIndex = 12;
            this.goalLabel.Text = "Goal Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "lb.";
            // 
            // nudInitialWeight
            // 
            this.nudInitialWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInitialWeight.Location = new System.Drawing.Point(97, 179);
            this.nudInitialWeight.Margin = new System.Windows.Forms.Padding(2);
            this.nudInitialWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudInitialWeight.Name = "nudInitialWeight";
            this.nudInitialWeight.Size = new System.Drawing.Size(131, 26);
            this.nudInitialWeight.TabIndex = 8;
            this.nudInitialWeight.Tag = "Weight";
            this.nudInitialWeight.ValueChanged += new System.EventHandler(this.EnableUpdateButton);
            // 
            // nudGoalWeight
            // 
            this.nudGoalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGoalWeight.Location = new System.Drawing.Point(97, 250);
            this.nudGoalWeight.Margin = new System.Windows.Forms.Padding(2);
            this.nudGoalWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGoalWeight.Name = "nudGoalWeight";
            this.nudGoalWeight.Size = new System.Drawing.Size(131, 26);
            this.nudGoalWeight.TabIndex = 13;
            this.nudGoalWeight.Tag = "GoalWeight";
            this.nudGoalWeight.TextChanged += new System.EventHandler(this.EnableUpdateButton);
            // 
            // nudFootBox
            // 
            this.nudFootBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFootBox.Location = new System.Drawing.Point(303, 250);
            this.nudFootBox.Margin = new System.Windows.Forms.Padding(2);
            this.nudFootBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFootBox.Name = "nudFootBox";
            this.nudFootBox.Size = new System.Drawing.Size(70, 26);
            this.nudFootBox.TabIndex = 16;
            this.nudFootBox.Tag = "Height (ft.)";
            this.nudFootBox.TextChanged += new System.EventHandler(this.EnableUpdateButton);
            // 
            // nudInchesBox
            // 
            this.nudInchesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInchesBox.Location = new System.Drawing.Point(401, 250);
            this.nudInchesBox.Margin = new System.Windows.Forms.Padding(2);
            this.nudInchesBox.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.nudInchesBox.Name = "nudInchesBox";
            this.nudInchesBox.Size = new System.Drawing.Size(69, 26);
            this.nudInchesBox.TabIndex = 18;
            this.nudInchesBox.Tag = "Height (in.)";
            this.nudInchesBox.TextChanged += new System.EventHandler(this.EnableUpdateButton);
            // 
            // ProfileInfo
            // 
            this.AcceptButton = this.updateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 373);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProfileInfo";
            this.Text = "My Profile";
            this.Load += new System.EventHandler(this.ProfileInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGoalWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFootBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInchesBox)).EndInit();
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
    }
}