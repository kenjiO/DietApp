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
        /// <summary>The current user id.</summary>
        private int theUserId;

        /// <summary>The minimum chart value.</summary>
        private int minValue;

        /// <summary>The maximum chart.</summary>
        private int maxValue;

        /// <summary>The report page.</summary>
        private int reportPage = 1;

        /// <summary>The report start date page.</summary>
        private DateTime date;

        /// <summary>
        /// Initializes a new instance of the <see cref="WellnessReportForm"/> class.
        /// </summary>
        /// <param name="currentUserId">The current user id.</param>
        public WellnessReportForm(int currentUserId)
        {
            if (currentUserId == 0)
            {
                MessageBox.Show("Error loading Wellness Reports. No user specified");

                // Need to call Close() as an event handler for Load event
                this.Load += (s, e) => this.Close();
            }

            this.reportPage = 1;
            this.theUserId = currentUserId;
            this.InitializeComponent();
        }

        /// <summary>
        /// Loads the reports information.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        public void WellnessReportForm_Load(object sender, EventArgs e)
        {
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
            this.chartUserData.Legends.Clear();
            this.chartUserData.Series.Clear();

            if (rbWeight.Checked == true)
            {
                int type = 1;
                string title = DietAppController.GetType(type).MeasurementTypeName;
                string name = DietAppController.GetType(type).MeasurementTypeName + " (" + DietAppController.GetType(type).MeasurementDefaultUnit + ")";
                this.ChartSeries(type, name, System.Drawing.Color.Blue);
                this.ChartLegends(name);
                this.ChartAreas(this.minValue, this.maxValue, title);
                this.ChartTitle(title);
            }
            else if (rbHeartRate.Checked == true)
            {
                int type = 2;
                string title = DietAppController.GetType(type).MeasurementTypeName;
                string name = DietAppController.GetType(type).MeasurementTypeName + " (" + DietAppController.GetType(type).MeasurementDefaultUnit + ")";
                this.ChartSeries(type, name, System.Drawing.Color.Red);
                this.ChartLegends(name);
                this.ChartAreas(this.minValue, this.maxValue, title);
                this.ChartTitle(title);
            }
            else if (rbBP.Checked == true)
            {
                string title = "Blood Pressure";
                int type = 3;
                string name = DietAppController.GetType(type).MeasurementTypeName + " (" + DietAppController.GetType(type).MeasurementDefaultUnit + ")";
                this.ChartSeries(type, name, System.Drawing.Color.Yellow);
                this.ChartLegends(name);
                type = 4;
                name = DietAppController.GetType(type).MeasurementTypeName + " (" + DietAppController.GetType(type).MeasurementDefaultUnit + ")";
                this.ChartSeries(type, name, System.Drawing.Color.Green);
                this.ChartLegends(name);
                this.ChartAreas(this.minValue, this.maxValue, title);
                this.ChartTitle(title);                
            }
            else
            {
                int type = 1;
                string title = string.Empty;
                string name = string.Empty;
                this.ChartTitle(title);
                this.ChartSeries(type, name, System.Drawing.Color.Black);
                this.ChartAreas(this.minValue, this.maxValue, title);
                this.ChartLegends(name);
                this.chartUserData.Invalidate();
            }

            this.chartUserData.Invalidate();
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
                Text = DietAppController.getUserData(this.theUserId).firstName + "'s " + title + " Data",
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
                ChartType = SeriesChartType.Column,
            };

            this.chartUserData.Series.Add(series1);
            this.date = Convert.ToDateTime("2016-06-20");
            List<DailyMeasurements> chartList = DietAppController.GetUserChartData10Days(this.theUserId, type, this.date);

            if (chartList.Count > 0)
            {
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
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    string day = date.AddDays(i).ToShortDateString() + "*No Data";
                    series1.Points.AddXY(day, 0);
                }

                this.maxValue = 200;
                this.minValue = 0;
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

            this.BTNLoad_Click(sender, e);
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

            this.BTNLoad_Click(sender, e);
        }

        /// <summary>
        /// Button that prints current chart data.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void BTNPrint_Click(object sender, EventArgs e)
        {
            this.PrintWellnessReport.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            this.PrintWellnessReport.Print();
        }
    }
}