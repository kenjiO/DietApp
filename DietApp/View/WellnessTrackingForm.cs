using DietApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietApp.View
{
    public partial class WellnessTrackingForm : Form
    {
        private Users theUser;

        public WellnessTrackingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the user's information to the Wellness Tracking window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WellnessTrackingForm_Load(object sender, EventArgs e)
        {
            if (this.theUser != null)
            {

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
        /// Saves the data to the DB.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void saveInfo_Click(object sender, System.EventArgs e)
        {

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
