using DietApp.Controller;
using DietApp.Model;
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
            int height, value, weight;
            
            userName = usernameBox.Text;
            firstName = firstNameBox.Text;
            lastName = lastNameBox.Text;
            email = emailBox.Text;
            Int32.TryParse(weightBox.Text, out value);
            weight = value;
            Int32.TryParse(footBox.Text, out value);
            height = value * 12;
            Int32.TryParse(inchesBox.Text, out value);
            height += value;

            try
            {
                //Gets the user information for the user just added to the DB based on the newly created userID.
                var originalUser = DietAppController.getUserData(this.theUser.userId);
                //Builds a blank user profile.
                var newUser = new Users
                {
                    //Adds the current userName to the blank user profile.
                    firstName = firstName,
                    lastName = lastName,
                    email = email,
                    initialWeight = weight,
                    heightInches = height

                };
                if (originalUser.firstName.Equals(newUser.firstName) && originalUser.lastName.Equals(newUser.lastName) &&
                    originalUser.email.Equals(newUser.email) && originalUser.initialWeight.Equals(newUser.initialWeight) &&
                    originalUser.heightInches.Equals(newUser.heightInches))
                {
                    MessageBox.Show("No profile information changed.",  "Update User");
                }
                else
                {
                    //Updates the user.
                    DietAppController.updateUsers(originalUser, newUser);
                    this.theUser = newUser;
                    MessageBox.Show("User ID: " + originalUser.userName + " updated.", "Update User");
                }
                //Refreshes this form.
                this.Refresh();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

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