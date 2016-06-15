using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DietApp.Model;
using DietApp.Controller;

namespace DietApp
{
    public partial class ProfileInfo : Form
    {
        private AppController _controller;

        public ProfileInfo(AppController controller)
        {
            this._controller = controller;
            InitializeComponent();
        }

        private void ProfileInfo_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            } catch (SqlException ex)
            {
                MessageBox.Show("Database error loading profile.\n" + ex.Message);
            }
        }

        private void LoadData()
        {
            User user = _controller.GetCurrentUser();
            if (user == null)
            {
                MessageBox.Show("User does not exist");
                return;
            }
            firstNameBox.Text = user.FirstName;
            lastNameBox.Text = user.LastName;
            emailBox.Text = user.Email;
        }

    }
}

