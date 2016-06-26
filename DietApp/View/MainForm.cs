using DietApp.Model;
using DietApp.View;
using System;
using System.Windows.Forms;

namespace DietApp
{
    public partial class MainForm : Form
    {
        private Users theUser;
        private ProfileInfo profileForm;
        private WellnessTrackingForm wellnessForm;
        private FoodEntryForm entryForm;

        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Updates the title bar with an appropriate greeting.
        /// If user is defined, userName is displayed as a part of that greeting.
        /// Else, the user is directed to the profile form and a generic greeting is displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateTitle(object sender, EventArgs e)
        {
            if (this.theUser.getFullName() == " ")
            {
                this.profileForm = new ProfileInfo();
                this.profileForm.loadUser(this.theUser);
                this.profileForm.MdiParent = this;
                this.profileForm.FormClosed += new FormClosedEventHandler(ProfileInfoFormClosed);
                this.profileForm.Show();
                this.Text = "Welcome to Health Trends.";
            }
            else
            {
                this.Text = "Welcome to Health Trends, " + theUser.getFullName() + ".";
                this.profileForm = null;
            }
        }

        /// <summary>
        /// Shows the profile window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.profileForm == null)
            {
                this.profileForm = new ProfileInfo();
                this.profileForm.loadUser(this.theUser);
                this.profileForm.MdiParent = this;
                this.profileForm.FormClosed += new FormClosedEventHandler(ProfileInfoFormClosed);
                this.profileForm.Show();
            }
            else
            {
                this.profileForm.Activate();
            }
        }

        /// <summary>
        /// Closes the profile window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProfileInfoFormClosed(object sender, FormClosedEventArgs e)
        {
            this.profileForm = null;
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
        /// Restarts the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Shows the WellnessTracking Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wellnessTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.wellnessForm == null)
            {
                this.wellnessForm = new WellnessTrackingForm();
                this.wellnessForm.loadUser(this.theUser);
                this.wellnessForm.MdiParent = this;
                this.wellnessForm.FormClosed += new FormClosedEventHandler(WellnessFormClosed);
                this.wellnessForm.Show();
            }
            else
            {
                this.wellnessForm.Activate();
            }
        }

        /// <summary>
        /// Closes the WellnessTracking Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WellnessFormClosed(object sender, FormClosedEventArgs e)
        {
            this.wellnessForm = null;
        }

        private void enterFoodItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.entryForm == null)
            {
                this.entryForm = new FoodEntryForm(this.theUser);
                this.entryForm.MdiParent = this;
                this.entryForm.FormClosed += new FormClosedEventHandler(FoodEntryFormClosed);
                this.entryForm.Show();
            }
            else
            {
                this.entryForm.Activate();
            }
        }

        private void FoodEntryFormClosed(object sender, FormClosedEventArgs e)
        {
            this.entryForm = null;
        }
    }
}