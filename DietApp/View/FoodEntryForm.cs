using DietApp.Controller;
using DietApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DietApp.View
{
    public partial class FoodEntryForm : Form
    {
        private Users currentUser;

        /// <summary>
        /// Create a new form for enterting foods
        /// </summary>
        /// <param name="currentUser">The current user to enter foods for</param>
        public FoodEntryForm(Users currentUser)
        {
            if (currentUser == null)
            {
                throw new ArgumentNullException("currentUser cannot be null");
            }
            this.currentUser = currentUser;
            InitializeComponent();
        }

        /// <summary>
        /// Called on form load.  Initializes date and time inputs
        /// </summary>
        private void FoodEntryForm_Load(object sender, EventArgs e)
        {
            datePicker.Value = DateTime.Now;
            timePicker.Value = DateTime.Now;
            timePicker.ShowUpDown = true;
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "hh:mm tt";
        }

        /// <summary>
        /// Submits the food entry form
        /// </summary>
        private void submitButton_Click(object sender, EventArgs e)
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
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                DietAppController.addFoodEntry(
                    currentUser.userId,
                    name,
                    calories,
                    protein,
                    fat,
                    carbohydrates,
                    consumedAt
                );
            }
            catch (DietApp.DAL.DuplcateFoodEntryException)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("An entry for that food and date/time already exists");
                return;
            }
            catch (SqlException ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                return;
            }
            Cursor.Current = Cursors.Default;
            MessageBox.Show("Entry added");
            clearFields();
        }

        /// <summary>
        /// Clears the food entry form fields
        /// </summary>
        private void clearFields()
        {
            foodBox.Text = "";
            caloriesBox.Text = "";
            proteinBox.Text = "";
            carbohydratesBox.Text = "";
            fatBox.Text = "";
        }

        /// <summary>
        /// Checks the food entry forms for errors
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
            if (errors.Equals(""))
                return null;
            else
                return errors;
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchForFood();
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                searchForFood();
            }
        }

        /// <summary>
        /// Takes the searchBox values and searches the DB for foods that match it
        /// </summary>
        private void searchForFood()
        {
            string searchTerm = searchBox.Text.Trim();
            if (searchTerm.Equals(""))
            {
                MessageBox.Show("You must enter a search term");
                return;
            }
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                List<FoodNutritionInfo> results = DietAppController.searchFoodInfo(searchTerm);
                if (results.Count == 0)
                {
                    MessageBox.Show("No results found");
                    return;
                }
                searchResultsListBox.DataSource = results;
                searchResultsListBox.DisplayMember = "name";
            }
            catch (SqlException ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("There was an error getting data from the database\n\n" + ex.Message);
                return;
            }
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Populate the food entry form with the data for the search result list
        /// food the user clicked on
        /// </summary>
        private void searchResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var list = (ListBox)sender;
            FoodNutritionInfo info = (FoodNutritionInfo)list.SelectedItem;
            foodBox.Text = info.name;
            caloriesBox.Text = info.calories.ToString();
            fatBox.Text = info.fat.ToString();
            proteinBox.Text = info.protein.ToString();
            carbohydratesBox.Text = info.carbohydrates.ToString();
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
    }
}