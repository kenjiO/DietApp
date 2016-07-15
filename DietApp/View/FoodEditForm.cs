using DietApp.Controller;
using DietApp.Model;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DietApp.View
{
    public partial class FoodEditForm : Form
    {
        private FoodEntry originalEntry;

        /// <summary>
        /// Create a new form for enterting foods
        /// </summary>
        /// <param name="entry">The entry to edit</param>
        public FoodEditForm(FoodEntry entry)
        {
            if (entry == null)
            {
                MessageBox.Show("Error loading edit window. Null entry is invalid");
                // Need to call Close() as an event handler for Load event
                Load += (s, e) => Close();
            }
            this.originalEntry = entry;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        /// <summary>
        /// Called on form load
        /// </summary>
        private void FoodEditForm_Load(object sender, EventArgs e)
        {
            timePicker.ShowUpDown = true;
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "hh:mm tt";
            loadValuesIntoForm(this.originalEntry);
        }

        /// <summary>
        /// Sets the form fields values
        /// </summary>
        /// <param name="entry">The foodEntry to get the values from</param>
        private void loadValuesIntoForm(FoodEntry entry)
        {
            foodBox.Text = entry.Name;
            caloriesBox.Text = entry.Calories.ToString();
            fatBox.Text = entry.Fat.ToString();
            proteinBox.Text = entry.Protein.ToString();
            carbohydratesBox.Text = entry.Carbohydrates.ToString();
            datePicker.Value = entry.ConsumedAt;
            timePicker.Value = entry.ConsumedAt;
        }

        /// <summary>
        /// Checks the form for errors
        /// </summary>
        /// <returns>Null if no errors or a string indicating what errors are present</returns>
        private string validateEntry()
        {
            string errors = "";
            if (foodBox.Text.Trim().Equals(""))
                errors += "Food name is blank\n";
            int x;
            if ((!int.TryParse(caloriesBox.Text.Trim(), out x) || x < 0) && !caloriesBox.Text.Trim().Equals(""))
                errors += "Invalid entry for calories\n";
            if ((!int.TryParse(fatBox.Text.Trim(), out x) || x < 0) && !fatBox.Text.Trim().Equals(""))
                errors += "Invalid entry for fat\n";
            if ((!int.TryParse(proteinBox.Text.Trim(), out x) || x < 0) && !proteinBox.Text.Trim().Equals(""))
                errors += "Invalid entry for protein\n";
            if ((!int.TryParse(carbohydratesBox.Text.Trim(), out x) || x < 0) && !carbohydratesBox.Text.Trim().Equals(""))
                errors += "Invalid entry for carbohydrates\n";
            if (errors.Equals("") && noUpdatesMade())
                errors = "You have not changed any data";
            if (errors.Equals(""))
                return null;
            else
                return errors;
        }

        /// <summary>
        /// Check wether user has changed any data
        /// </summary>
        /// <returns>True if no changes have been made. False otherwise</returns>
        private bool noUpdatesMade()
        {
            return foodBox.Text.Equals(this.originalEntry.Name) &&
                getIntOrNullValue(caloriesBox.Text) == this.originalEntry.Calories &&
                getIntOrNullValue(proteinBox.Text) == this.originalEntry.Protein &&
                getIntOrNullValue(fatBox.Text) == this.originalEntry.Fat &&
                getIntOrNullValue(carbohydratesBox.Text) == this.originalEntry.Carbohydrates &&
                getEnteredDateTime().ToString("yyyyMMddhhmmss").Equals(this.originalEntry.ConsumedAt.ToString("yyyyMMddhhmmss"));
        }

        /// <summary>
        /// Get an int or null from a string
        /// </summary>
        /// <param name="value">The string to convert</param>
        /// <returns>The string as an int if it is a valid int or null otherwise</returns>
        private int? getIntOrNullValue(string value)
        {
            try
            {
                return Convert.ToInt32(value.Trim());
            }
            catch (FormatException)
            {
                return null;
            }
        }

        /// <summary>
        /// Get a datetime object from combining the date and time fields of the form
        /// </summary>
        /// <returns>The datetime indicated on the form</returns>
        private DateTime getEnteredDateTime()
        {
            DateTime consumedDate = datePicker.Value;
            int year = consumedDate.Year;
            int month = consumedDate.Month;
            int day = consumedDate.Day;
            TimeSpan time = timePicker.Value.TimeOfDay;
            int hours = time.Hours;
            int minutes = time.Minutes;
            return new DateTime(year, month, day, hours, minutes, 0);
        }

        /// <summary>
        /// Updates The Entry with the form values
        /// </summary>
        private void updateEntry()
        {
            String errors = validateEntry();
            if (errors != null)
            {
                MessageBox.Show(errors);
                return;
            }
            string name = foodBox.Text;
            int? calories = getIntOrNullValue(caloriesBox.Text);
            int? fat = getIntOrNullValue(fatBox.Text);
            int? protein = getIntOrNullValue(proteinBox.Text);
            int? carbohydrates = getIntOrNullValue(carbohydratesBox.Text);
            DateTime consumedAt = getEnteredDateTime();
            FoodEntry updatedEntry = new FoodEntry(
                this.originalEntry.UserId,
                name,
                calories,
                fat,
                protein,
                carbohydrates,
                consumedAt);
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                DietAppController.updateFoodEntry(this.originalEntry, updatedEntry);
            }
            catch (SqlException ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                return;
            }
            Cursor.Current = Cursors.Default;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            updateEntry();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}