﻿using DietApp.Model;
using System;
using System.Windows.Forms;

namespace DietApp
{
    public partial class ProfileInfo : Form
    {
        private Users theUser;

        public ProfileInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the user's information to the View Profile window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProfileInfo_Load(object sender, EventArgs e)
        {
            if (this.theUser != null)
            {
                firstNameBox.Text = this.theUser.firstName;
                lastNameBox.Text = this.theUser.lastName;
                emailBox.Text = this.theUser.email;
                weightBox.Text = this.theUser.initialWeight.ToString();
                usernameBox.Text = this.theUser.userName;
                footBox.Text = (this.theUser.heightInches / 12).ToString();
                inchesBox.Text = (this.theUser.heightInches % 12).ToString();
            }
            else
            {
                MessageBox.Show("User does not exist.");
                MessageBox.Show("No user is currently logged on.");
                return;
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
        /// Closes the form if the user decides to "cancel" what (s)he is doing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}