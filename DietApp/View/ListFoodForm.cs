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
                // Need to call Close() as an event handler for Load event
                Load += (s, e) => Close();
            }
            this.currentUser = currentUser;
            InitializeComponent();
        }

        private void ListFoodForm_Load(object sender, EventArgs e)
        {
            this.bindingSource1 = new BindingSource();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bindingSource1;
            refreshData();
        }

        /// <summary>
        /// Event handler when the date is changed
        /// </summary>
        private void dateTimePicker1_DateSelected(object sender, EventArgs e)
        {
            refreshData();
        }

        private void prevDayButton_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-1);
            refreshData();
        }

        private void nextDayButton_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
            refreshData();
        }

        /// <summary>
        /// Reload the list of food entries to the datepicker date
        /// </summary>
        private void refreshData()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                bindingSource1.DataSource = DietAppController.getFoodEntriesForUserByDate(this.currentUser.userId, dateTimePicker1.Value);
                Cursor.Current = Cursors.Default;
            }
            catch (SqlException ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}