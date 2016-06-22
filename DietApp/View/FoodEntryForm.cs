using DietApp.Controller;
using DietApp.Model;
using System;
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
            catch (DietApp.DAL.DuplcateFoodEntryException ex)
            {
                MessageBox.Show("An entry for that food and date/time already exists");
            }
            MessageBox.Show("Entry added");
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
            catch (FormatException e)
            {
                return null;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
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