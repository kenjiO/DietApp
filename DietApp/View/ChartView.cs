//-----------------------------------------------------------------------
// <copyright file="ChartView.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This class sets up chart display features.</summary>
// <author>Robert Carswell</author>
//-----------------------------------------------------------------------

namespace DietApp.View
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms.DataVisualization.Charting;
    using DietApp.Controller;
    using DietApp.Model;

    /// <summary>
    /// Sets up chart display features.
    /// </summary>
    public class ChartView
    {
        /// <summary>The current user.</summary>
        private Users theUser;

        /// <summary>The current user.</summary>
        private Chart theChart;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartView"/> class.
        /// </summary>
        /// <param name="currentUser">The current user.</param>
        /// <param name="currentChart">The current chart.</param>
        public ChartView(Users currentUser, Chart currentChart)
        {
            // Loads Overview Data
            this.theUser = DietAppController.getUserData(currentUser.userId);
            this.theChart = currentChart;

            // Clears Chart
            this.theChart.Titles.Clear();
            this.theChart.Legends.Clear();
            this.theChart.ChartAreas.Clear();
            this.theChart.Series.Clear();
        }

        /// <summary>
        /// Sets up the look and style of the user's chart, Title.
        /// </summary>
        /// <param name="name">Name of the chart.</param>
        public void ChartTitle(string name)
        { 
            var titles = new System.Windows.Forms.DataVisualization.Charting.Title
            {
                Name = name,
                Text = this.theUser.firstName + "'s Data",
                Visible = true,
            };
            this.theChart.Titles.Add(titles);
        }

        /// <summary>
        /// Sets up the look and style of the user's chart, Legends.
        /// </summary>
        /// <param name="type">Type of the chart data.</param>
        public void ChartLegends(string type)
        {
            var legends1 = new System.Windows.Forms.DataVisualization.Charting.Legend
            {
                Name = type,
            };
            this.theChart.Legends.Add(legends1);
        }

        /// <summary>
        /// Sets up the look and style of the user's chart, Areas.
        /// </summary>
        /// <param name="min">Minimum chart value.</param>
        /// <param name="max">Maximum chart value.</param>
        /// <param name="title">Title of the chart.</param>
        public void ChartAreas(double min, double max, string title)
        {
            this.theChart.ChartAreas.Clear();

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

            this.theChart.ChartAreas.Add(chartArea1);
        }

        /// <summary>
        /// Sets up the look and style of the user's chart, Series.
        /// </summary>
        /// <param name="type">The type of the data.</param>
        /// <param name="color">The color of the line.</param>
        /// <param name="xDates">The x axis dates.</param>
        /// <param name="yValues">The y axis values.</param>
        public void ChartSeries(string type, Color color, string[] xDates, double[] yValues)
        {
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = type,
                Color = color,
                BorderWidth = 5,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line,
            };

            this.theChart.Series.Add(series1);

            if (!xDates.Length.Equals(yValues.Length))
            {
                throw new ArgumentException("X and Y array counts not equal.");
            }

            if (xDates.Length > 0 && yValues.Length > 0)
            {
                for (int i = 0; i < xDates.Length; i++)
                {
                    series1.Points.AddXY(xDates[i], yValues[i]);
                }
            }
            else
            {
                throw new ArgumentException("X and Y array are empty.");
            }
        }
    }
}
