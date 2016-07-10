﻿namespace DietApp
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.tabPageProgressForm = new System.Windows.Forms.TabPage();
            this.tabPageWellness = new System.Windows.Forms.TabPage();
            this.tabPageFoodList = new System.Windows.Forms.TabPage();
            this.tabPageFoodEntries = new System.Windows.Forms.TabPage();
            this.tabPageNutrientReport = new System.Windows.Forms.TabPage();
            this.tabPageWellnessReport = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Log Off";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPageProfile);
            this.tabControl1.Controls.Add(this.tabPageProgressForm);
            this.tabControl1.Controls.Add(this.tabPageWellness);
            this.tabControl1.Controls.Add(this.tabPageFoodList);
            this.tabControl1.Controls.Add(this.tabPageFoodEntries);
            this.tabControl1.Controls.Add(this.tabPageWellnessReport);
            this.tabControl1.Controls.Add(this.tabPageNutrientReport);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 587);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.Location = new System.Drawing.Point(4, 27);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageProfile.Size = new System.Drawing.Size(926, 556);
            this.tabPageProfile.TabIndex = 0;
            this.tabPageProfile.Text = "Profile";
            this.tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // tabPageProgressForm
            // 
            this.tabPageProgressForm.Location = new System.Drawing.Point(4, 27);
            this.tabPageProgressForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageProgressForm.Name = "tabPageProgressForm";
            this.tabPageProgressForm.Size = new System.Drawing.Size(926, 556);
            this.tabPageProgressForm.TabIndex = 4;
            this.tabPageProgressForm.Text = "Progress";
            this.tabPageProgressForm.UseVisualStyleBackColor = true;
            // 
            // tabPageWellness
            // 
            this.tabPageWellness.Location = new System.Drawing.Point(4, 27);
            this.tabPageWellness.Name = "tabPageWellness";
            this.tabPageWellness.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageWellness.Size = new System.Drawing.Size(926, 556);
            this.tabPageWellness.TabIndex = 1;
            this.tabPageWellness.Text = "Wellness Info";
            this.tabPageWellness.UseVisualStyleBackColor = true;
            // 
            // tabPageFoodList
            // 
            this.tabPageFoodList.Location = new System.Drawing.Point(4, 27);
            this.tabPageFoodList.Name = "tabPageFoodList";
            this.tabPageFoodList.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageFoodList.Size = new System.Drawing.Size(926, 556);
            this.tabPageFoodList.TabIndex = 3;
            this.tabPageFoodList.Text = "Food Entries";
            this.tabPageFoodList.UseVisualStyleBackColor = true;
            // 
            // tabPageFoodEntries
            // 
            this.tabPageFoodEntries.Location = new System.Drawing.Point(4, 27);
            this.tabPageFoodEntries.Name = "tabPageFoodEntries";
            this.tabPageFoodEntries.Size = new System.Drawing.Size(926, 556);
            this.tabPageFoodEntries.TabIndex = 2;
            this.tabPageFoodEntries.Text = "New Food Entry";
            this.tabPageFoodEntries.UseVisualStyleBackColor = true;
            // 
            // tabPageUserReport
            // tabPageWellnessReport
            // 
            this.tabPageWellnessReport.Location = new System.Drawing.Point(4, 27);
            this.tabPageWellnessReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageWellnessReport.Name = "tabPageWellnessReport";
            this.tabPageWellnessReport.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageWellnessReport.Size = new System.Drawing.Size(926, 556);
            this.tabPageWellnessReport.TabIndex = 4;
            this.tabPageWellnessReport.Text = "Wellness Report";
            this.tabPageWellnessReport.UseVisualStyleBackColor = true;
            // 
            // tabPageNutrientReport
            // 
            this.tabPageNutrientReport.Location = new System.Drawing.Point(4, 27);
            this.tabPageNutrientReport.Name = "tabPageNutrientReport";
            this.tabPageNutrientReport.Size = new System.Drawing.Size(926, 556);
            this.tabPageNutrientReport.TabIndex = 5;
            this.tabPageNutrientReport.Text = "Nutrient Report";
            this.tabPageNutrientReport.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Welcome to Health Trends.";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.TabPage tabPageWellness;
        private System.Windows.Forms.TabPage tabPageFoodEntries;
        private System.Windows.Forms.TabPage tabPageFoodList;
        private System.Windows.Forms.TabPage tabPageWellnessReport;
        private System.Windows.Forms.TabPage tabPageProgressForm;
        private System.Windows.Forms.TabPage tabPageNutrientReport;
    }
}