using DietApp.Controller;
using DietApp.Model;
using DietApp.View;
using System;
using System.Windows.Forms;

namespace DietApp
{
    public partial class MainForm : Form
    {
        private Users theUser;
        private ProfileInfo profileInfoForm;
        private WellnessTrackingForm wellnessForm;
        private FoodEntryForm foodForm;
        private ListFoodForm foodListForm;
        private ProgressForm progressForm;
        private NutrientReportForm nutrientForm;


        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Updates Any Changes
            this.theUser = DietAppController.getUserData(this.theUser.userId);
            updateTitle();
            loadTabs();
        }

        /// <summary>
        /// Updates the title bar with an appropriate greeting.
        /// If user is defined, userName is displayed as a part of that greeting.
        /// Else, the user is directed to the profile form and a generic greeting is displayed.
        /// </summary>
        private void updateTitle()
        {
            if (this.theUser.getFullName() == " ")
            {
                this.Text = "Welcome to Health Trends.";
            }
            else
            {
                this.Text = "Welcome to Health Trends, " + theUser.getFullName() + ".";
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
        /// Loads content into the tab pages
        /// </summary>
        private void loadTabs()
        {
            this.profileInfoForm = new ProfileInfo();
            this.profileInfoForm.loadUser(this.theUser);
            this.profileInfoForm.TopLevel = false;
            this.profileInfoForm.Visible = true;
            this.profileInfoForm.FormBorderStyle = FormBorderStyle.None;
            this.profileInfoForm.Dock = DockStyle.Fill;
            tabPageProfile.Controls.Add(this.profileInfoForm);

            this.wellnessForm = new WellnessTrackingForm();
            this.wellnessForm.loadUser(this.theUser);
            this.wellnessForm.TopLevel = false;
            this.wellnessForm.Visible = true;
            this.wellnessForm.FormBorderStyle = FormBorderStyle.None;
            this.wellnessForm.Dock = DockStyle.Fill;
            tabPageWellness.Controls.Add(this.wellnessForm);

            this.foodForm = new FoodEntryForm(this.theUser);
            this.foodForm.TopLevel = false;
            this.foodForm.Visible = true;
            this.foodForm.FormBorderStyle = FormBorderStyle.None;
            this.foodForm.Dock = DockStyle.Fill;
            tabPageFoodEntries.Controls.Add(this.foodForm);

            this.foodListForm = new ListFoodForm(this.theUser);
            this.foodListForm.TopLevel = false;
            this.foodListForm.Visible = true;
            this.foodListForm.FormBorderStyle = FormBorderStyle.None;
            this.foodListForm.Dock = DockStyle.Fill;
            tabPageFoodList.Controls.Add(this.foodListForm);

            this.progressForm = new ProgressForm();
            this.progressForm.loadUser(this.theUser);
            this.progressForm.TopLevel = false;
            this.progressForm.Visible = true;
            this.progressForm.FormBorderStyle = FormBorderStyle.None;
            this.progressForm.Dock = DockStyle.Fill;
            tabPageProgressForm.Controls.Add(this.progressForm);

        var reportForm = new ReportForm();
        reportForm.loadUser(this.theUser);
            reportForm.TopLevel = false;
            reportForm.Visible = true;
            reportForm.FormBorderStyle = FormBorderStyle.None;
            reportForm.Dock = DockStyle.Fill;
            tabPageUserReport.Controls.Add(reportForm);

            this.nutrientForm = new NutrientReportForm(this.theUser);
            this.nutrientForm.TopLevel = false;
            this.nutrientForm.Visible = true;
            this.nutrientForm.FormBorderStyle = FormBorderStyle.None;
            this.nutrientForm.Dock = DockStyle.Fill;
            tabPageNutrientReport.Controls.Add(this.nutrientForm);
        }
       /// <summary>
       /// Loads various functions (in order listed from top to bottom) when user navigates to a different tab.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void TabControl1_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageWellness)
            {
                this.wellnessForm.CheckDBForWellness(sender, e);
            }
            else if (tabControl1.SelectedTab == tabPageProgressForm)
            {
                this.progressForm.ProgressForm_Load(sender, e);
            }
            else if (tabControl1.SelectedTab == tabPageFoodList)
            {
                this.foodListForm.refreshData();
            }
            else if (tabControl1.SelectedTab == tabPageNutrientReport)
            {
                this.nutrientForm.runReport();
            }
        }
    }
}