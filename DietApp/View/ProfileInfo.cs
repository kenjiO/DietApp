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
                this.firstNameBox.Text = DietAppController.getUserData(this.theUserId).firstName;
                this.lastNameBox.Text = DietAppController.getUserData(this.theUserId).lastName;
                this.emailBox.Text = DietAppController.getUserData(this.theUserId).email;
                this.nudInitialWeight.Value = DietAppController.getUserData(this.theUserId).initialWeight;
                this.usernameBox.Text = DietAppController.getUserData(this.theUserId).userName;
                this.nudGoalWeight.Value = DietAppController.getUserData(this.theUserId).goalWeight;
                this.nudFootBox.Value = DietAppController.getUserData(this.theUserId).heightInches / 12;
                this.nudInchesBox.Value = DietAppController.getUserData(this.theUserId).heightInches % 12;
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
        /// Saves new information on the user.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string userName, firstName, lastName, email;
            int height, weight, goalWeight;

            userName = this.usernameBox.Text;
            firstName = this.firstNameBox.Text;
            lastName = this.lastNameBox.Text;
            email = this.emailBox.Text;
            weight = (int)this.nudInitialWeight.Value;
            goalWeight = (int)this.nudGoalWeight.Value;
            height = ((int)this.nudFootBox.Value * 12) + (int)this.nudInchesBox.Value;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (View_Validator.Blank(this.firstNameBox) || View_Validator.Blank(this.lastNameBox) || View_Validator.Blank(this.emailBox))
                {
                    // Checks for Blank Boxes
                }
                else
                {
                    // Gets the user information for the user just added to the DB based on the newly created userID.
                    var originalUser = DietAppController.getUserData(this.theUserId);

                    // Builds a blank user profile.
                    var newUser = new Users
                    {
                        // Adds the current userName to the blank user profile.
                        userId = originalUser.userId,
                        firstName = firstName,
                        lastName = lastName,
                        email = email,
                        initialWeight = weight,
                        goalWeight = goalWeight,
                        heightInches = height
                    };
                    if (originalUser.firstName.Equals(newUser.firstName) && originalUser.lastName.Equals(newUser.lastName) &&
                        originalUser.email.Equals(newUser.email) && originalUser.initialWeight.Equals(newUser.initialWeight)
                        && originalUser.goalWeight.Equals(newUser.goalWeight) && originalUser.heightInches.Equals(newUser.heightInches))
                    {
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("No profile information changed.", "Update User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Updates the user.
                        DietAppController.updateUsers(originalUser, newUser);
                        this.theUserId = newUser.userId;
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
            int height;
            bool change = false;

            // First Name
            if (!DietAppController.getUserData(this.theUserId).firstName.Equals(this.firstNameBox.Text))
            {
                change = true;
            }

            // Last Name
            if (!DietAppController.getUserData(this.theUserId).lastName.Equals(this.lastNameBox.Text))
            {
                change = true;
            }

            // eMail
            if (!DietAppController.getUserData(this.theUserId).email.Equals(this.emailBox.Text))
            {
                change = true;
            }

            // Initial Weight
            if (!DietAppController.getUserData(this.theUserId).initialWeight.Equals((int)this.nudInitialWeight.Value))
            {
                change = true;
            }

            // Goal Weight
            if (!DietAppController.getUserData(this.theUserId).goalWeight.Equals((int)this.nudGoalWeight.Value))
            {
                change = true;
            }

            // Height
            height = ((int)this.nudFootBox.Value * 12) + (int)this.nudInchesBox.Value;
            if (!DietAppController.getUserData(this.theUserId).heightInches.Equals(height))
            {
                change = true;
            }

            this.updateButton.Enabled = change;
        }
    }
}