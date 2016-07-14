//-----------------------------------------------------------------------
// <copyright file="MainForm.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the display of the main form for the diet app.</summary>
// <author>Kaleigh Kendrick</author>
// <author>Kenji Okamoto</author>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

namespace DietApp
{
    using System;
    using System.Windows.Forms;
    using DietApp.Controller;
    using DietApp.Model;
    using DietApp.View;

    /// <summary>
    /// Main form of Diet Application.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>The active user.</summary>
        private Users theUser;

        /// <summary>The profile information form.</summary>
        private ProfileInfo profileInfoForm;

        /// <summary>The wellness tracking form.</summary>
        private WellnessTrackingForm wellnessForm;

        /// <summary>The food entry form.</summary>
        private FoodEntryForm foodForm;

        /// <summary>The list food form.</summary>
        private ListFoodForm foodListForm;

        /// <summary>The progress form.</summary>
        private ProgressForm progressForm;

        /// <summary>The nutrient report form.</summary>
        private NutrientReportForm nutrientForm;

        /// <summary>The wellness report form.</summary>
        private WellnessReportForm wellnessReportForm;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Loads the user.
        /// </summary>
        /// <param name="newUser">The current User.</param>
        public void LoadUser(Users newUser)
        {
            this.theUser = newUser;
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <param name="e">Closing of the form.</param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        /// <summary>
        /// Loads current user information and updates.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Updates Any Changes
            this.theUser = DietAppController.getUserData(this.theUser.userId);
            this.UpdateTitle();
            this.LoadTabs();
        }

        /// <summary>
        /// Updates the title bar with an appropriate greeting.
        /// If user is defined, userName is displayed as a part of that greeting.
        /// Else, the user is directed to the profile form and a generic greeting is displayed.
        /// </summary>
        private void UpdateTitle()
        {
            if (this.theUser.getFullName() == " ")
            {
                this.Text = "Welcome to Health Trends.";
            }
            else
            {
                this.Text = "Welcome to Health Trends, " + this.theUser.getFullName() + ".";
            }
        }

        /// <summary>
        /// Restarts the application.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Loads content into the tab pages
        /// </summary>
        private void LoadTabs()
        {
            this.profileInfoForm = new ProfileInfo();
            this.profileInfoForm.loadUser(this.theUser);
            this.profileInfoForm.TopLevel = false;
            this.profileInfoForm.Visible = true;
            this.profileInfoForm.FormBorderStyle = FormBorderStyle.None;
            this.profileInfoForm.Dock = DockStyle.Fill;
            tabPageProfile.Controls.Add(this.profileInfoForm);

            this.wellnessForm = new WellnessTrackingForm();
            this.wellnessForm.loadUser(this.theUser);
            this.wellnessForm.TopLevel = false;
            this.wellnessForm.Visible = true;
            this.wellnessForm.FormBorderStyle = FormBorderStyle.None;
            this.wellnessForm.Dock = DockStyle.Fill;
            tabPageWellness.Controls.Add(this.wellnessForm);

            this.foodForm = new FoodEntryForm(this.theUser);
            this.foodForm.TopLevel = false;
            this.foodForm.Visible = true;
            this.foodForm.FormBorderStyle = FormBorderStyle.None;
            this.foodForm.Dock = DockStyle.Fill;
            tabPageFoodEntries.Controls.Add(this.foodForm);

            this.foodListForm = new ListFoodForm(this.theUser);
            this.foodListForm.TopLevel = false;
            this.foodListForm.Visible = true;
            this.foodListForm.FormBorderStyle = FormBorderStyle.None;
            this.foodListForm.Dock = DockStyle.Fill;
            tabPageFoodList.Controls.Add(this.foodListForm);

            this.progressForm = new ProgressForm();
            this.progressForm.loadUser(this.theUser);
            this.progressForm.TopLevel = false;
            this.progressForm.Visible = true;
            this.progressForm.FormBorderStyle = FormBorderStyle.None;
            this.progressForm.Dock = DockStyle.Fill;
            tabPageProgressForm.Controls.Add(this.progressForm);

            this.wellnessReportForm = new WellnessReportForm();
            this.wellnessReportForm.loadUser(this.theUser);
            this.wellnessReportForm.TopLevel = false;
            this.wellnessReportForm.Visible = true;
            this.wellnessReportForm.FormBorderStyle = FormBorderStyle.None;
            this.wellnessReportForm.Dock = DockStyle.Fill;
            tabPageWellnessReport.Controls.Add(this.wellnessReportForm);

            this.nutrientForm = new NutrientReportForm(this.theUser);
            this.nutrientForm.TopLevel = false;
            this.nutrientForm.Visible = true;
            this.nutrientForm.FormBorderStyle = FormBorderStyle.None;
            this.nutrientForm.Dock = DockStyle.Fill;
            tabPageNutrientReport.Controls.Add(this.nutrientForm);
        }

        /// <summary>
        /// Loads various functions (in order listed from top to bottom) when user navigates to a different tab.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.wellnessForm.CheckDBForWellness(sender, e);
            if (tabControl1.SelectedTab == this.tabPageProfile)
            {
                this.profileInfoForm.ProfileInfo_Load(sender, e);
            }
            else if (tabControl1.SelectedTab == this.tabPageProgressForm)
            {
                this.progressForm.ProgressForm_Load(sender, e);
            }
            else if (tabControl1.SelectedTab == this.tabPageFoodList)
            {
                this.foodListForm.refreshData();
            }
            else if (tabControl1.SelectedTab == this.tabPageNutrientReport)
            {
                this.nutrientForm.runReport();
            }
            else if (tabControl1.SelectedTab == this.tabPageWellnessReport)
            {
                this.wellnessReportForm.WellnessReportForm_Load(sender, e);
            }
        }

        /// <summary>
        /// Wellness report.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void WellnessReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Nutrition report.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void NutrientReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}