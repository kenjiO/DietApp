//-----------------------------------------------------------------------
// <copyright file="NewUser.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the form to create a new user.</summary>
// <author>Kaleigh Kendrick</author>
// <author>Robert Carswell</author>
// <author>Kenji Okamoto</author>
//-----------------------------------------------------------------------

namespace DietApp
{
    using System;
    using System.Data.SqlClient;
    using System.Windows.Forms;
    using DietApp.Controller;
    using DietApp.Model;
    using DietApp.View;

    /// <summary>
    /// The create new user form.
    /// </summary>
    public partial class NewUser : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewUser"/> class.
        /// </summary>
        public NewUser()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Creates the user's login credentials and loads to database.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        public void SaveUser_Click(object sender, System.EventArgs e)
        {
            string userName, password, confirm, firstName, lastName, email;
            int height, weight, goalWeight, dailyCalorieGoal;

            userName = usernameBox.Text;
            password = passwordBox.Text;
            confirm = confirmBox.Text;
            firstName = firstNameBox.Text;
            lastName = lastNameBox.Text;
            email = emailBox.Text;
            weight = (int)this.nudWeightBox.Value;
            goalWeight = (int)this.nudGoalWeightBox.Value;
            dailyCalorieGoal = (int)this.nudDailyCalorieGoal.Value;
            height = ((int)this.nudFootBox.Value * 12) + (int)this.nudInchesBox.Value;

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (!View_Validator.Name(this.usernameBox) || View_Validator.Blank(this.passwordBox) || View_Validator.Blank(this.confirmBox) ||
                    !View_Validator.Name(this.firstNameBox) || !View_Validator.Name(this.lastNameBox) || !View_Validator.Email(this.emailBox.Text))
                {
                    // Checks for valid Boxes
                    /*MessageBox.Show(View_Validator.Name(this.usernameBox).ToString() + View_Validator.Blank(this.passwordBox).ToString() +
                        View_Validator.Blank(this.confirmBox).ToString() + View_Validator.Name(this.firstNameBox).ToString() +
                        View_Validator.Name(this.lastNameBox).ToString() + View_Validator.Email(this.emailBox.Text).ToString(),"Error");*/
                }
                else if (View_Validator.NotMatch(this.passwordBox, this.confirmBox))
                {
                    // Checks if boxes match
                    this.passwordBox.Text = string.Empty;
                    this.confirmBox.Text = string.Empty;
                }
                else if (Model_Validator.verifyUserName(userName))
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("The user name provided is already in use. Please try a different user name.", "Invalid Login Credentials");
                    this.usernameBox.Text = string.Empty;
                    this.passwordBox.Text = string.Empty;
                    this.confirmBox.Text = string.Empty;
                }
                else
                {
                    // Adds the userName and password to the User Table.
                    var userID = DietAppController.addNewUser(userName, password);

                    // Gets the user information for the user just added to the DB based on the newly created userID.
                    var justAdded = DietAppController.getUserData(userID);

                    // Builds a blank user profile.
                    var newUser = new Users
                    {
                        // Adds the current userName to the blank user profile.
                        userName = userName,
                        firstName = firstName,
                        lastName = lastName,
                        email = email,
                        initialWeight = weight,
                        goalWeight = goalWeight,
                        dailyCalorieGoal = dailyCalorieGoal,
                        heightInches = height
                    };

                    // Updates the user.
                    DietAppController.updateUsers(justAdded, newUser);

                    // Opens the main form.
                    var mainForm = new MainForm();

                    // Loads the user.
                    mainForm.LoadUser(DietAppController.getUserData(justAdded.userId));

                    // Shows the main form.
                    mainForm.Show();

                    // Hides the current form.
                    this.Hide();
                }

                Cursor.Current = Cursors.Default;
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
        }

        /// <summary>
        /// Closes the form if the user decides to "cancel" what (s)he is doing.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}