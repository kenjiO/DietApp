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
            System.String userName, password, confirm;

            userName = usernameBox.Text;
            password = passwordBox.Text;
            confirm = confirmBox.Text;
            
            try
            {
                if (password.Equals("") || confirm.Equals(""))
                {
                    MessageBox.Show("One of provided passwords is blank.  Please try again.",
                        "Invalid Login Credentials");
                }
                else if (!(password.Equals(confirmBox)))
                {
                    MessageBox.Show("The passwords provided invalid or don't match.  Please try again.",
                        "Invalid Login Credentials");
                    passwordBox.Text = "";
                    confirmBox.Text = "";
                }
                else
                {
                    Users newUser = DietAppController.addNewUser(userName, password);
                    var mainForm = new MainForm();
                    mainForm.loadUser(newUser);
                    mainForm.Show();
                    //Close the new user form.
                    this.Close();
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
    }
}