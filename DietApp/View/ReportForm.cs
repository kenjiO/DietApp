//-----------------------------------------------------------------------
// <copyright file="ReportForm.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the form view for user reports.</summary>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

namespace DietApp.View
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;
    using DietApp.Controller;
    using DietApp.Model;

    /// <summary>
    /// Form for display of User Reports.
    /// </summary>
    public partial class ReportForm : Form
    {
        private Users theUser;
        private int type = 1;
        private string title = "Weight";
        private string name = "Weight";
        private int minValue = 0;
        private int maxValue = 200;

        /// <summary>
        /// Form for display of User Reports.
        /// </summary>
        public ReportForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the reports information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ReportForm_Load(object sender, EventArgs e)
        {
            rbWeight.Checked = true;
            this.chartUserData.Series.Clear();
            this.chartUserData.Legends.Clear();
            this.chartTitle(this.title);
            this.chartSeries(this.type, this.name, System.Drawing.Color.Green);
            this.chartAreas(this.minValue, this.maxValue, this.title);
            this.chartLegends(this.name);
            this.chartUserData.Invalidate();
        }
        
        /// <summary>
        /// Loads the user.
        /// </summary>
        /// <param name="newUser">The active user class.</param>
        public void loadUser(Users newUser)
        {
            //Updates Any Changes
            this.theUser = DietAppController.getUserData(newUser.userId);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {           
            if (rbWeight.Checked == true)
            {
                this.chartUserData.Series.Clear();
                this.chartUserData.Legends.Clear();
                this.type = 1;
                this.title = "Weight";
                this.name = "Weight";
                this.chartTitle(title);
                this.chartSeries(type, name, System.Drawing.Color.Green);
                this.chartAreas(this.minValue, this.maxValue, title);
                this.chartLegends(this.name);
                this.chartUserData.Invalidate();

            }
            else if (rbHeartRate.Checked == true)
            {
                this.chartUserData.Series.Clear();
                this.chartUserData.Legends.Clear();
                this.type = 2;
                this.title = "Heart Rate";
                this.name = "Heart Rate";
                this.chartTitle(title);
                this.chartSeries(type, name, System.Drawing.Color.Green);
                this.chartAreas(this.minValue, this.maxValue, title);
                this.chartLegends(this.name);
                this.chartUserData.Invalidate();
            }
            else if (rbBP.Checked == true)
            {
                this.chartUserData.Series.Clear();
                this.chartUserData.Legends.Clear();
                this.type = 3;
                this.title = "Blood Pressure";
                this.name = "Systolic";
                this.chartTitle(title);
                this.chartSeries(type, name, System.Drawing.Color.Green);
                this.chartLegends(this.name);
                double systolicMax = this.maxValue;
                this.type = 4;
                this.name = "Diastolic";
                this.chartSeries(type, name, System.Drawing.Color.Red);
                this.chartAreas(this.minValue, systolicMax, title);
                this.chartLegends(this.name);
                this.chartUserData.Invalidate();
            }
            else
            {
                this.chartUserData.Series.Clear();
                this.chartUserData.Legends.Clear();
                this.type = 1;
                this.title = string.Empty;
                this.name = string.Empty;
                this.chartTitle(title);
                this.chartSeries(type, name, System.Drawing.Color.Red);
                this.chartAreas(this.minValue, this.maxValue, title);
                this.chartLegends(this.name);
                this.chartUserData.Invalidate();
            }

        }

        /// <summary>
        /// Sets up the look and style of the user's chart, Areas.
        /// </summary>
        private void chartAreas(double min, double max, string title)
        {
            this.chartUserData.ChartAreas.Clear();
            
            var axisY = new System.Windows.Forms.DataVisualization.Charting.Axis
            {
                Minimum = min,
                Maximum = max,
                Title = title,
            };

            var chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea
            {
                AxisY = axisY,
            };

            this.chartUserData.ChartAreas.Add(chartArea1);

        }
        
        /// <summary>
        /// Sets up the look and style of the user's chart, Title.
        /// </summary>
        private void chartTitle(string title)
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
        private void chartLegends(string name)
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
        private void chartSeries(int type, string name, Color color)
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
                    this.maxValue = Convert.ToInt32(measurements.Measurement * 1.1);
                if ((measurements.Measurement * 0.9) < this.minValue)
                    this.minValue = Convert.ToInt32(measurements.Measurement * 0.9);
            }
        }
    }
}