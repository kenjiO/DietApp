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
            if (controller == null)
            {
                throw new ArgumentNullException("controller must not be null");
            }
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
                MessageBox.Show("No user is currently logged on");
                return;
            }
            firstNameBox.Text = user.firstName;
            lastNameBox.Text = user.lastName;
            emailBox.Text = user.email;
        }

    }
}

