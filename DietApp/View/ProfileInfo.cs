using DietApp.Controller;
using DietApp.Model;
using DietApp.View;
using System;
using System.Data.SqlClient;
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
        public void ProfileInfo_Load(object sender, EventArgs e)
        {
            if (View_Validator.Users(this.theUser))
            {
                return;
            }
            else
            {
                firstNameBox.Text = this.theUser.firstName;
                lastNameBox.Text = this.theUser.lastName;
                emailBox.Text = this.theUser.email;
                weightBox.Text = this.theUser.initialWeight.ToString();
                usernameBox.Text = this.theUser.userName;
                goalWeightBox.Text = this.theUser.goalWeight.ToString();
                footBox.Text = (this.theUser.heightInches / 12).ToString();
                inchesBox.Text = (this.theUser.heightInches % 12).ToString();
            }
        }

        /// <summary>
        /// Loads the user.
        /// </summary>
        /// <param name="newUser"></param>
        public void loadUser(Users newUser)
        {
            //Updates Any Changes
            this.theUser = DietAppController.getUserData(newUser.userId);
        }

        /// <summary>
        /// Saves new information on the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            String userName, firstName, lastName, email;
            int height, value, weight, goalWeight;

            userName = usernameBox.Text;
            firstName = firstNameBox.Text;
            lastName = lastNameBox.Text;
            email = emailBox.Text;
            Int32.TryParse(weightBox.Text, out value);
            weight = value;
            Int32.TryParse(goalWeightBox.Text, out value);
            goalWeight = value;
            Int32.TryParse(footBox.Text, out value);
            height = value * 12;
            Int32.TryParse(inchesBox.Text, out value);
            height += value;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (View_Validator.Blank(firstNameBox) || View_Validator.Blank(lastNameBox) || View_Validator.Blank(emailBox) ||
                    View_Validator.Blank(weightBox) || View_Validator.Blank(footBox) || View_Validator.Blank(inchesBox)|| View_Validator.Blank(goalWeightBox))
                {
                    //Checks for Blank Boxes
                }
                else
                {
                    //Gets the user information for the user just added to the DB based on the newly created userID.
                    var originalUser = DietAppController.getUserData(this.theUser.userId);
                    //Builds a blank user profile.
                    var newUser = new Users
                    {
                        //Adds the current userName to the blank user profile.
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
                        //Updates the user.
                        DietAppController.updateUsers(originalUser, newUser);
                        this.theUser = newUser;
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("User ID: " + originalUser.userName + " updated.", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Cursor.Current = Cursors.Default;
                    //Refreshes this form.
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
        }
    }
}