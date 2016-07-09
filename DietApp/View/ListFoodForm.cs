using DietApp.Controller;
using DietApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DietApp.View
{
    public partial class ListFoodForm : Form
    {
        private Users currentUser;
        private BindingSource bindingSource1;
        private const int DATAGRID_EDIT_COLUMN_INDEX = 6;
        private const int DATAGRID_DELETE_COLUMN_INDEX = 7;
        private List<FoodEntry> currentDayEntries;

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
        public void refreshData()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                this.currentDayEntries = DietAppController.getFoodEntriesForUserByDate(this.currentUser.userId, dateTimePicker1.Value);
                Cursor.Current = Cursors.Default;
            }
            catch (SqlException ex)
            {
                this.currentDayEntries = new List<FoodEntry>();
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bindingSource1.DataSource = this.currentDayEntries;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the column is the edit button column
            if (e.ColumnIndex == DATAGRID_EDIT_COLUMN_INDEX)
            {
                try
                {
                    FoodEntry entryToEdit = this.currentDayEntries[e.RowIndex];
                    if (entryToEdit == null)
                    {
                        MessageBox.Show("There was an application error editing this item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    launchEditForm(entryToEdit);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show("There was an application error editing this item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Check if column is delete button column
            if (e.ColumnIndex == DATAGRID_DELETE_COLUMN_INDEX)
            {
                try
                {
                    FoodEntry entryToDelete = this.currentDayEntries[e.RowIndex];
                    if (entryToDelete == null)
                    {
                        MessageBox.Show("There was an application error editing this item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    DialogResult result = MessageBox.Show("Delete " + entryToDelete.Name + " ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result != DialogResult.Yes)
                    {
                        return;
                    }
                    Cursor.Current = Cursors.WaitCursor;
                    DietAppController.deleteFoodEntry(entryToDelete);
                    refreshData();
                    Cursor.Current = Cursors.Default;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("There was an application error deleting this item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException ex)
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Launches the form to edit an entry
        /// </summary>
        /// <param name="entryToEdit">The entry to edit</param>
        private void launchEditForm(FoodEntry entryToEdit)
        {
            FoodEditForm editForm = new FoodEditForm(entryToEdit);
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                refreshData();
            }
        }
    }
}