using DietApp.Controller;
using DietApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DietApp.View
{
    public partial class NutrientReportForm : Form
    {
        private Users theUser;
        private int reportPage = 1;

        public NutrientReportForm(Users currentUser)
        {
            if (currentUser == null)
            {
                MessageBox.Show("Error loading Food Entries Window. No user specified");
                // Need to call Close() as an event handler for Load event
                Load += (s, e) => Close();
            }
            this.theUser = currentUser;
            InitializeComponent();
        }

        private void NutrientReportForm_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.Series.Clear();
            chart1.Series.Add("Fat");
            chart1.Series.Add("Protein");
            chart1.Series.Add("Carbohydrates");
            chart1.ChartAreas[0].AxisY.Maximum = 500;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
        }

        public void runReport()
        {
            DateTime reportStartDate = DateTime.Now.AddDays(this.reportPage * -10 + 1);
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
            try
            {
                List<DailyNutrition> dataPoints = DietAppController.get10DayNutrientTotals(this.theUser.userId, reportStartDate);
                System.Windows.Forms.Cursor.Current = Cursors.Default;

                for (int i = 0; i < 10; i++)
                {
                    string day = reportStartDate.AddDays(i).ToString("MM/dd");
                    if ((dataPoints.Count > 0) && dataPoints[0].Date.ToString("MM/dd").Equals(day))
                    {
                        day = day + "\n\n" + dataPoints[0].Calories + "\ncalories";
                        chart1.Series["Fat"].Points.AddXY(day, dataPoints[0].Fat);
                        chart1.Series["Protein"].Points.AddXY(day, dataPoints[0].Protein);
                        chart1.Series["Carbohydrates"].Points.AddXY(day, dataPoints[0].Carbohydrates);
                        dataPoints.RemoveAt(0);
                    }
                    else
                    {
                        // No data for this day so use zeros
                        day = day + "\n\n\n no data";
                        chart1.Series["Fat"].Points.AddXY(day, 0);
                        chart1.Series["Protein"].Points.AddXY(day, 0);
                        chart1.Series["Carbohydrates"].Points.AddXY(day, 0);
                    }
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                return;
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            this.reportPage++;
            nextButton.Enabled = true;
            runReport();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.reportPage--;
            if (this.reportPage == 1)
            {
                nextButton.Enabled = false;
            }
            runReport();
        }
    }
}