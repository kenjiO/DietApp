//-----------------------------------------------------------------------
// <copyright file="WellnessReportForm.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the form view for User's Wellness Reports.</summary>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

namespace DietApp.View
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;
    using DietApp.Controller;
    using DietApp.Model;

    /// <summary>
    /// Form for display of User's Wellness Reports.
    /// </summary>
    public partial class WellnessReportForm : Form
    {
        /// <summary>The current user.</summary>
        private Users theUser;

        /// <summary>The type of wellness.</summary>
        private int type;

        /// <summary>The title of the graph.</summary>
        private string title;

        /// <summary>The name of the data.</summary>
        private string name;

        /// <summary>The minimum chart value.</summary>
        private int minValue;

        /// <summary>The maximum chart.</summary>
        private int maxValue;

        /// <summary>The report page.</summary>
        private int reportPage = 1;

        /// <summary>
        /// Initializes a new instance of the <see cref="WellnessReportForm"/> class.
        /// </summary>
        /// <param name="currentUser">The current user.</param>
        public WellnessReportForm(Users currentUser)
        {
            if (currentUser == null)
            {
                MessageBox.Show("Error loading Food Entries Window. No user specified");

                // Need to call Close() as an event handler for Load event
                this.Load += (s, e) => this.Close();
            }

            this.theUser = DietAppController.getUserData(currentUser.userId);
            this.InitializeComponent();
        }

        /// <summary>
        /// Loads the reports information.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        public void WellnessReportForm_Load(object sender, EventArgs e)
        {
            this.minValue = 0;
            this.maxValue = 200;
            rbWeight.Checked = true;
            rbHeartRate.Checked = false;
            rbBP.Checked = false;
            this.BTNLoad_Click(sender, e);
        }

        /// <summary>
        /// Button that loads chart data.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void BTNLoad_Click(object sender, EventArgs e)
        {
            if (rbWeight.Checked == true)
            {
                this.chartUserData.Series.Clear();
                this.chartUserData.Legends.Clear();
                this.type = 1;
                this.title = "Weight";
                this.name = "Weight";
                this.ChartTitle(this.title);
                this.ChartSeries(this.type, this.name, System.Drawing.Color.Green);
                this.ChartAreas(this.minValue, this.maxValue, this.title);
                this.ChartLegends(this.name);
                this.chartUserData.Invalidate();
            }
            else if (rbHeartRate.Checked == true)
            {
                this.chartUserData.Series.Clear();
                this.chartUserData.Legends.Clear();
                this.type = 2;
                this.title = "Heart Rate";
                this.name = "Heart Rate";
                this.ChartTitle(this.title);
                this.ChartSeries(this.type, this.name, System.Drawing.Color.Green);
                this.ChartAreas(this.minValue, this.maxValue, this.title);
                this.ChartLegends(this.name);
                this.chartUserData.Invalidate();
            }
            else if (rbBP.Checked == true)
            {
                this.chartUserData.Series.Clear();
                this.chartUserData.Legends.Clear();
                this.type = 3;
                this.title = "Blood Pressure";
                this.name = "Systolic";
                this.ChartTitle(this.title);
                this.ChartSeries(this.type, this.name, System.Drawing.Color.Green);
                this.ChartLegends(this.name);
                double systolicMax = this.maxValue;
                this.type = 4;
                this.name = "Diastolic";
                this.ChartSeries(this.type, this.name, System.Drawing.Color.Red);
                this.ChartAreas(this.minValue, systolicMax, this.title);
                this.ChartLegends(this.name);
                this.chartUserData.Invalidate();
            }
            else
            {
                this.chartUserData.Series.Clear();
                this.chartUserData.Legends.Clear();
                this.type = 1;
                this.title = string.Empty;
                this.name = string.Empty;
                this.ChartTitle(this.title);
                this.ChartSeries(this.type, this.name, System.Drawing.Color.Red);
                this.ChartAreas(this.minValue, this.maxValue, this.title);
                this.ChartLegends(this.name);
                this.chartUserData.Invalidate();
            }
        }

        /// <summary>
        /// Sets up the look and style of the user's chart, Areas.
        /// </summary>
        /// <param name="min">Minimum chart value.</param>
        /// <param name="max">Maximum chart value.</param>
        /// <param name="title">Title of the chart.</param>
        private void ChartAreas(double min, double max, string title)
        {
            this.chartUserData.ChartAreas.Clear();

            var axisX = new System.Windows.Forms.DataVisualization.Charting.Axis
            {
                Interval = 1,
            };
            
            var axisY = new System.Windows.Forms.DataVisualization.Charting.Axis
            {
                Minimum = min,
                Maximum = max,
                Title = title,
            };

            var chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea
            {
                AxisX = axisX,
                AxisY = axisY,
            };

            this.chartUserData.ChartAreas.Add(chartArea1);
        }

        /// <summary>
        /// Sets up the look and style of the user's chart, Title.
        /// </summary>
        /// <param name="title">Title of the chart.</param>
        private void ChartTitle(string title)
        {
            this.chartUserData.Titles.Clear();
            var titles1 = new System.Windows.Forms.DataVisualization.Charting.Title
            {
                Name = title,
                Text = this.theUser.firstName + "'s " + title + " Data",
                Visible = true,
            };
            this.chartUserData.Titles.Add(titles1);
        }

        /// <summary>
        /// Sets up the look and style of the user's chart, Legends.
        /// </summary>
        /// <param name="name">Name of the chart data.</param>
        private void ChartLegends(string name)
        {
            var legends1 = new System.Windows.Forms.DataVisualization.Charting.Legend
            {
                Name = name,
            };
            this.chartUserData.Legends.Add(legends1);
        }

        /// <summary>
        /// Sets up the look and style of the user's chart, Series.
        /// </summary>
        /// <param name="type">The type of the measurement.</param>
        /// /// <param name="name">The name of the data.</param>
        /// /// <param name="color">The color of the line.</param>
        private void ChartSeries(int type, string name, Color color)
        {
            this.minValue = 200;
            this.maxValue = 0;

            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = name,
                Color = color,
                BorderWidth = 5,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line,
            };

            this.chartUserData.Series.Add(series1);

            List<DailyMeasurements> chartList = DietAppController.getUserChartData(this.theUser.userId, type);
            foreach (DailyMeasurements measurements in chartList)
            {
                series1.Points.AddXY(measurements.Date.ToShortDateString(), measurements.Measurement);
                if ((measurements.Measurement * 1.1) > this.maxValue)
                {
                    this.maxValue = Convert.ToInt32(measurements.Measurement * 1.1);
                }

                if ((measurements.Measurement * 0.9) < this.minValue)
                {
                    this.minValue = Convert.ToInt32(measurements.Measurement * 0.9);
                }
            }
        }

        /// <summary>
        /// Button that loads chart data, prior page.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void PrevButton_Click(object sender, EventArgs e)
        {
            this.reportPage++;
            nextButton.Enabled = true;

            // runReport();
        }

        /// <summary>
        /// Button that loads chart data, next page.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            this.reportPage--;
            if (this.reportPage == 1)
            {
                nextButton.Enabled = false;
            }

            // runReport();
        }
    }
}