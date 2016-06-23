using DietApp.Controller;
using DietApp.Model;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DietApp
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates the user's login credentials and loads to database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void saveUser_Click(object sender, System.EventArgs e)
        {
            String userName, password, confirm, firstName, lastName, email;
            int height, value, weight;
           

            userName = usernameBox.Text;
            password = passwordBox.Text;
            confirm = confirmBox.Text;
            firstName = firstNameBox.Text;
            lastName = lastNameBox.Text;
            email = emailBox.Text;
            Int32.TryParse(weightBox.Text, out value);
            weight = value;
            Int32.TryParse(footBox.Text, out value);
            height = value*12;
            Int32.TryParse(inchesBox.Text, out value);
            height += value;

            try
            {
                if (password.Equals("") || confirm.Equals(""))
                {
                    MessageBox.Show("One of provided passwords is blank.  Please try again.",
                        "Invalid Login Credentials");
                }
                else if (!(password.Equals(confirm)))
                {
                    MessageBox.Show("The passwords provided are invalid or do not match.  Please try again.",
                        "Invalid Login Credentials");
                    passwordBox.Text = "";
                    confirmBox.Text = "";
                }
                else if (Model_Validator.verifyUserName(userName))
                {
                    MessageBox.Show("The user name provided is already in use. Please try a different user name.",
                        "Invalid Login Credentials");
                    usernameBox.Text = "";
                    passwordBox.Text = "";
                    confirmBox.Text = "";
                }
                else
                {
                    //Adds the userName and password to the User Table.
                    var userID = DietAppController.addNewUser(userName, password);
                    //Gets the user information for the user just added to the DB based on the newly created userID.
                    var justAdded = DietAppController.getUserData(userID);
                    //Builds a blank user profile.
                    var newUser = new Users
                    {
                        //Adds the current userName to the blank user profile.
                        userName = userName,
                        firstName = firstName,
                        lastName = lastName,
                        email = email,
                        initialWeight = weight,
                        heightInches = height

                    };
                    //Updates the user.
                    DietAppController.updateUsers(justAdded, newUser);
                    //Opens the main form.
                    var mainForm = new MainForm();
                    //Loads the user.
                    mainForm.loadUser(newUser);
                    //Shows the main form.
                    mainForm.Show();
                    //Hides the current form.
                    this.Hide();
                }
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
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}