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

        public FoodEntryForm(Users currentUser)
        {
            if (currentUser == null)
            {
                throw new ArgumentNullException("currentUser cannot be null");
            }
            this.currentUser = currentUser;
            InitializeComponent();
        }

        private void FoodEntryForm_Load(object sender, EventArgs e)
        {
            datePicker.Value = DateTime.Now;
            timePicker.Value = DateTime.Now;
            timePicker.ShowUpDown = true;
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "hh:mm tt";
        }

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
                MessageBox.Show("An entry for that food and date/time already exists");
                return;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                return;
            }
            MessageBox.Show("Entry added");
            clearFields();
        }

        private void clearFields()
        {
            foodBox.Text = "";
            caloriesBox.Text = "";
            proteinBox.Text = "";
            carbohydratesBox.Text = "";
            fatBox.Text = "";
        }

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

        private void searchForFood()
        {
            string searchTerm = searchBox.Text.Trim();
            if (searchTerm.Equals(""))
            {
                MessageBox.Show("You must enter a search term");
                return;
            }
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
                MessageBox.Show("There was an error getting data from the database\n\n" + ex.Message);
                return;
            }
        }

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