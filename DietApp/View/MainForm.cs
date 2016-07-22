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
    using System.Data.SqlClient;
    using System.IO;
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
            this.tabPageWellness.Leave += new System.EventHandler(this.wellnessForm.CheckDBForWellness);
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
        }

        /// <summary>
        /// Loads various functions (in order listed from top to bottom) when user navigates to a different tab.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        }

        /// <summary>
        /// Export menu button click handler.  Prompts user for a file to export to.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void exportEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Select a file to export wellness and food entries to.\n" +
                            "This file can then be used on another system to import the entries " +
                            "or can be used to import the entries to another user on this system",
                            "Export Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result != DialogResult.OK)
            {
                return;
            }

            Stream outStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Health Trend files (*.health)|*.health|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((outStream = saveFileDialog1.OpenFile()) != null)
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        DietAppController.exportData(this.theUser.userId, outStream);
                        Cursor.Current = Cursors.Default;
                    }
                    catch (SqlException ex)
                    {
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    outStream.Close();
                }
            }
        }

        /// <summary>
        /// Import menu item click handler.  Prompts user for file and imports entries.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void importEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream inStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Health Trend files (*.health)|*.health|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((inStream = openFileDialog1.OpenFile()) != null)
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        DietAppController.importData(this.theUser.userId, inStream);
                        Cursor.Current = Cursors.Default;
                    }
                    catch (DietAppImportExportException ex)
                    {
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (SqlException ex)
                    {
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    inStream.Close();
                }
            }
        }

        /// <summary>
        /// Wellness report dialog.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void WellnessReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WellnessReportForm wellnessReportForm = new WellnessReportForm(this.theUser.userId);
            wellnessReportForm.StartPosition = FormStartPosition.CenterScreen;
            wellnessReportForm.ShowDialog();
        }

        /// <summary>
        /// Nutrition report dialog.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void NutrientReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NutrientReportForm nutrientReportForm = new NutrientReportForm(this.theUser);
            nutrientReportForm.StartPosition = FormStartPosition.CenterScreen;
            nutrientReportForm.ShowDialog();
        }
    }
}