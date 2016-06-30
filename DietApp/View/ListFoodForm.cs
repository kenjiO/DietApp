using DietApp.Controller;
using DietApp.Model;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DietApp.View
{
    public partial class ListFoodForm : Form
    {
        private Users currentUser;
        private BindingSource bindingSource1;

        public ListFoodForm(Users currentUser)
        {
            if (currentUser == null)
            {
                MessageBox.Show("Error loading Food Entries Window. No user specified");
                Load += (s, e) => Close();
            }
            this.currentUser = currentUser;
            InitializeComponent();
        }

    }
}

