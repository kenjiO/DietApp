using DietApp.Model;
using System;
using System.Windows.Forms;

namespace DietApp
{
    public partial class MainForm : Form
    {
        private Users theUser;

        public MainForm()
        {
            InitializeComponent();
        }

        private void updateTitle(object sender, EventArgs e)
        {
            this.Text = "Welcome to Health Trends, " + theUser.getFullName();
        }

        private void myHealthTrendsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        public void loadUser(Users newUser)
        {
            this.theUser = newUser;

            Console.WriteLine(theUser.getFullName());
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}