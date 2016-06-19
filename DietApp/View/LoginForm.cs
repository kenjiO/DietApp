using DietApp.Controller;
using DietApp.Model;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DietApp
{
    public partial class loginForm : Form
    {
        private Users theUser;

        public loginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Checks the user's login credentials against the information in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void loginButton_Click(object sender, System.EventArgs e)
        {
            System.String userName, password;

            userName = usernameBox.Text;
            password = passwordBox.Text;

            try
            {
                if (DietAppController.comparePassword(userName, password))
                {
                    this.theUser = DietAppController.getUserData(userName);
                    var mainForm = new MainForm();
                    mainForm.loadUser(this.theUser);
                    mainForm.Show();
                    //Hides the login form from view.
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The username and/or password provided is invalid.  Please try again.",
                        "Invalid Login Credentials");
                    usernameBox.Text = "";
                    passwordBox.Text = "";
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
            this.Close();
        }

        /// <summary>
        /// Allows for new user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newButton_Click(object sender, EventArgs e)
        {
            var newUser = new NewUser();
            newUser.Show();
            //Hides the login form from view.
            this.Hide();
        }
    }
}