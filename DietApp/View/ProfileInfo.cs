//-----------------------------------------------------------------------
// <copyright file="ProfileInfo.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the form view for User's Profile info.</summary>
// <author>Kaleigh Kendrick</author>
// <author>Robert Carswell</author>
// <author>Kenji Okamoto</author>
//-----------------------------------------------------------------------

namespace DietApp.View
{
    using System;
    using System.Data.SqlClient;
    using System.Windows.Forms;
    using DietApp.Controller;
    using DietApp.Model;

    /// <summary>
    /// The view of user profile information.
    /// </summary>
    public partial class ProfileInfo : Form
    {
        /// <summary>The current user.</summary>
        private int theUserId;

        private Users user;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileInfo"/> class.
        /// </summary>
        public ProfileInfo()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Loads the user's information to the View Profile window.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        public void ProfileInfo_Load(object sender, EventArgs e)
        {
            if (View_Validator.Users(DietAppController.getUserData(this.theUserId)))
            {
                return;
            }
            else
            {
                //Reduced number of calls on the DB by getting the user information in a single object.
                this.user = DietAppController.getUserData(this.theUserId);
                this.firstNameBox.Text = this.user.firstName;
                this.lastNameBox.Text = this.user.lastName;
                this.emailBox.Text = this.user.email;
                this.nudInitialWeight.Value = this.user.initialWeight;
                this.usernameBox.Text = this.user.userName;
                this.nudGoalWeight.Value = this.user.goalWeight;
                this.nudFootBox.Value = this.user.heightInches / 12;
                this.nudInchesBox.Value = this.user.heightInches % 12;
                this.nudDailyCalorieGoal.Value = this.user.dailyCalorieGoal;

            }
        }

        /// <summary>
        /// Loads the user.
        /// </summary>
        /// <param name="newUserId">The current user id.</param>
        public void LoadUser(int newUserId)
        {
            // Updates Any Changes
            this.theUserId = newUserId;
        }

        /// <summary>
        /// Checks to see if profile data matches data in the DB.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CheckDBForProfile(object sender, System.EventArgs e)
        {
            //Builds a blank user profile.
            var userProfileUpdate = new Users
            {
                //Adds the current data to the user profile.
                userId = this.theUserId,
                userName = this.user.userName,
                firstName = this.firstNameBox.Text,
                lastName = this.lastNameBox.Text,
                email = this.emailBox.Text,
                initialWeight = (int)this.nudInitialWeight.Value,
                heightInches = ((int)this.nudFootBox.Value * 12) + (int)this.nudInchesBox.Value,
                dailyCalorieGoal = (int)this.nudDailyCalorieGoal.Value,
                goalWeight = (int)this.nudGoalWeight.Value
            };
            if (!View_Validator.UserMatch(userProfileUpdate))
            {
                //Updates Profile Info
                this.updateConfirm(sender, e);
            }
        }

        // Helper Methods //

        /// <summary>
        /// Prompts the user if they try to navigate to a different tab with unsaved changes.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateConfirm(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("You have not saved changes for this user. " +
                "Do you wish to update your data?", "Update Entry",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.UpdateButton_Click(sender, e);
            }
        }

        /// <summary>
        /// Saves new information on the user.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (!View_Validator.Name(this.firstNameBox))
                {
                    // Checks for valid first.
                    this.firstNameBox.Text = DietAppController.getUserData(this.theUserId).firstName;
                }
                else if (!View_Validator.Name(this.lastNameBox))
                {
                    // Checks for valid last email.
                    this.lastNameBox.Text = DietAppController.getUserData(this.theUserId).lastName;
                }
                else if (!View_Validator.Email(this.emailBox.Text))
                {
                    // Checks for valid email.
                    this.emailBox.Text = DietAppController.getUserData(this.theUserId).email;
                }
                else
                {
                    // Gets the user information for the user just added to the DB based on the newly created userID.
                    var originalUser = DietAppController.getUserData(this.theUserId);

                    // Builds a blank user profile.
                    var userProfileUpdate = new Users
                    {
                        // Adds the current userName to the blank user profile.
                        userId = this.theUserId,
                        userName = DietAppController.getUserData(this.theUserId).userName,
                        firstName = this.firstNameBox.Text,
                        lastName = this.lastNameBox.Text,
                        email = this.emailBox.Text,
                        initialWeight = (int)this.nudInitialWeight.Value,
                        heightInches = ((int)this.nudFootBox.Value * 12) + (int)this.nudInchesBox.Value,
                        dailyCalorieGoal = (int)this.nudDailyCalorieGoal.Value,
                        goalWeight = (int)this.nudGoalWeight.Value,
                    };
                    // Set max height to 999 feet
                    if (userProfileUpdate.heightInches > 11988)
                    {
                        userProfileUpdate.heightInches = 11988;
                    }
                    if (View_Validator.UserMatch(userProfileUpdate))
                    {
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("No profile information changed.", "Update User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Updates the user.
                        DietAppController.updateUsers(originalUser, userProfileUpdate);
                        this.theUserId = userProfileUpdate.userId;
                        Cursor.Current = Cursors.Default;
                    }

                    Cursor.Current = Cursors.Default;

                    // Refreshes this form.
                    this.Refresh();
                }
            }
            catch (SqlException ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.updateButton.Enabled = false;
        }

        /// <summary>
        /// Checks to see if info has been entered on the page.  If so, enables save button.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void EnableUpdateButton(object sender, System.EventArgs e)
        {
            var userProfileUpdate = new Users()
            {
                userId = this.theUserId,
                userName = DietAppController.getUserData(this.theUserId).userName,
                firstName = this.firstNameBox.Text,
                lastName = this.lastNameBox.Text,
                email = this.emailBox.Text,
                initialWeight = (int)this.nudInitialWeight.Value,
                heightInches = ((int)this.nudFootBox.Value * 12) + (int)this.nudInchesBox.Value,
                dailyCalorieGoal = (int)this.nudDailyCalorieGoal.Value,
                goalWeight = (int)this.nudGoalWeight.Value,
            };
            if (!View_Validator.UserMatch(userProfileUpdate))
            {
                this.updateButton.Enabled = true;
            }
            else
            {
                this.updateButton.Enabled = false;
            }
        }
    }
}