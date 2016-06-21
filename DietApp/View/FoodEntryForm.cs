using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietApp.View
{
    public partial class FoodEntryForm : Form
    {
        public FoodEntryForm()
        {
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
