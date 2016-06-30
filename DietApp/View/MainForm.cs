﻿using DietApp.Controller;
using DietApp.Model;
using DietApp.View;
using System;
using System.Windows.Forms;

namespace DietApp
{
    public partial class MainForm : Form
    {
        private Users theUser;

        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Updates Any Changes
            this.theUser = DietAppController.getUserData(this.theUser.userId); 
            updateTitle();
            loadTabs();
        }

        /// <summary>
        /// Updates the title bar with an appropriate greeting.
        /// If user is defined, userName is displayed as a part of that greeting.
        /// Else, the user is directed to the profile form and a generic greeting is displayed.
        /// </summary>
        private void updateTitle()
        {
            if (this.theUser.getFullName() == " ")
            {
                this.Text = "Welcome to Health Trends.";
            }
            else
            {
                this.Text = "Welcome to Health Trends, " + theUser.getFullName() + ".";
            }
        }

        /// <summary>
        /// Loads the user.
        /// </summary>
        /// <param name="newUser"></param>
        public void loadUser(Users newUser)
        {
            this.theUser = newUser;
        }

        /// <summary>
        /// Restarts the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Loads content into the tab pages
        /// </summary>
        private void loadTabs()
        {
            ProfileInfo profileInfoForm = new ProfileInfo();
            profileInfoForm.loadUser(this.theUser);
            profileInfoForm.TopLevel = false;
            profileInfoForm.Visible = true;
            profileInfoForm.FormBorderStyle = FormBorderStyle.None;
            profileInfoForm.Dock = DockStyle.Fill;
            tabPageProfile.Controls.Add(profileInfoForm);

            WellnessTrackingForm wellnessForm = new WellnessTrackingForm();
            wellnessForm.loadUser(this.theUser);
            wellnessForm.TopLevel = false;
            wellnessForm.Visible = true;
            wellnessForm.FormBorderStyle = FormBorderStyle.None;
            wellnessForm.Dock = DockStyle.Fill;
            tabPageWellness.Controls.Add(wellnessForm);

            FoodEntryForm foodForm = new FoodEntryForm(this.theUser);
            foodForm.TopLevel = false;
            foodForm.Visible = true;
            foodForm.FormBorderStyle = FormBorderStyle.None;
            foodForm.Dock = DockStyle.Fill;
            tabPageFoodEntries.Controls.Add(foodForm);
        }

    }
}