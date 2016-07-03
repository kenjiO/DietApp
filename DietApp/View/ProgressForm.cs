using DietApp.Controller;
using DietApp.Model;
using System;
using System.Windows.Forms;

namespace DietApp.View
{
    public partial class ProgressForm : Form
    {
        private Users theUser;
        private Progress theProgress;

        public ProgressForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the user's information to the Progress window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProgressForm_Load(object sender, EventArgs e)
        {
            if (this.theUser != null)
            {
                theProgress = DietAppController.getBMIData(theUser.userId);
                oldBMIBox.Text = theProgress.oldBMI.ToString();
                newBMIBox.Text = theProgress.newBMI.ToString();
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
    }
}