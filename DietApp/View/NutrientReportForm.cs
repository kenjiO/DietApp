//-----------------------------------------------------------------------
// <copyright file="NutrientReportForm.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This is the form view for Nutrient Reports.</summary>
// <author>Robert Carswell</author>
// <author>Kenji Okamot</author>
//-----------------------------------------------------------------------

namespace DietApp.View
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Drawing.Printing;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;
    using DietApp.Controller;
    using DietApp.Model;

    /// <summary>
    /// The form for nutrient report.
    /// </summary>
    public partial class NutrientReportForm : Form
    {
        /// <summary>The current user id.</summary>
        private int theUserId;

        /// <summary>The maximum chart.</summary>
        private int maxValue;

        /// <summary>The report page.</summary>
        private int reportPage = 1;

        /// <summary>
        /// Initializes a new instance of the <see cref="NutrientReportForm"/> class.
        /// </summary>
        /// <param name="currentUserId">The current user.</param>
        public NutrientReportForm(int currentUserId)
        {
            if (currentUserId == 0)
            {
                MessageBox.Show("Error loading Food Entries Window. No user specified");

                // Need to call Close() as an event handler for Load event
                this.Load += (s, e) => this.Close();
            }

            this.theUserId = currentUserId;
            this.maxValue = 250;
            this.reportPage = 1;
            this.InitialLook();
            this.InitializeComponent();
        }

        /// <summary>
        /// Load the form.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        public void NutrientReportForm_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
            this.RunReport();
            System.Windows.Forms.Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Runs the report.
        /// </summary>
        public void RunReport()
        {
            if (this.checkCalories.Checked == false && this.checkFat.Checked == false && this.checkProtein.Checked == false && this.checkCarbohydrates.Checked == false)
            {
                this.checkCalories.Checked = true;
            }

            this.chart1.Legends.Clear();
            this.chart1.Series.Clear();
            this.chart1.ChartAreas.Clear();
            this.chart1.Titles.Clear();
            this.maxValue = 0;
            string title = "Nutrition Values";

            if (this.checkCalories.Checked == true)
            {
                string name = "Calories";
                this.ChartSeries(name, System.Drawing.Color.Blue);
                this.ChartLegends(name);
            }

            if (this.checkFat.Checked == true)
            {
                string name = "Fat";
                this.ChartSeries(name, System.Drawing.Color.Green);
                this.ChartLegends(name);
            }

            if (this.checkProtein.Checked == true)
            {
                string name = "Protein";
                this.ChartSeries(name, System.Drawing.Color.Purple);
                this.ChartLegends(name);
            }

            if (this.checkCarbohydrates.Checked == true)
            {
                string name = "Carbohydrates";
                this.ChartSeries(name, System.Drawing.Color.Red);
                this.ChartLegends(name);
            }

            this.ChartAreas(this.maxValue);
            this.ChartTitle(title);

            this.chart1.Invalidate();

            this.prevButton.Text = "Prev " + this.nudDays.Value + " Days";
            this.nextButton.Text = "Next " + this.nudDays.Value + " Days";
        }

        /// <summary>
        /// Sets up the look and style of the user's chart, Areas.
        /// </summary>
        /// <param name="max">Maximum chart value.</param>
        private void ChartAreas(double max)
        {
            if (max == 0)
            {
                max = 250;
            }

            var axisX = new System.Windows.Forms.DataVisualization.Charting.Axis
            {
                Interval = 1,
            };

            var axisY = new System.Windows.Forms.DataVisualization.Charting.Axis
            {
                Minimum = 0,
                Maximum = max,
                Title = "grams",
            };

            var chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea
            {
                AxisX = axisX,
                AxisY = axisY,
            };

            this.chart1.ChartAreas.Add(chartArea1);
        }

        /// <summary>
        /// Sets up the look and style of the user's chart, Title.
        /// </summary>
        /// <param name="title">Title of the chart.</param>
        private void ChartTitle(string title)
        {
            this.chart1.Titles.Clear();
            var titles1 = new System.Windows.Forms.DataVisualization.Charting.Title
            {
                Name = title,
                Text = DietAppController.getUserData(this.theUserId).firstName + "'s " + title,
                Visible = true,
            };
            this.chart1.Titles.Add(titles1);
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
            this.chart1.Legends.Add(legends1);
        }

        /// <summary>
        /// Sets up the look and style of the user's chart, Series.
        /// </summary>
        /// <param name="name">The name of the data.</param>
        /// <param name="color">The color of the line.</param>
        private void ChartSeries(string name, Color color)
        {
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = name,
                Color = color,
                BorderWidth = 5,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Column,
            };

            int toDisplay = (int)this.nudDays.Value;
            DateTime date = new DateTime();
            date = DateTime.Now.AddDays(1 - (this.reportPage * toDisplay));

            try
            {
                List<DailyNutrition> dataPoints = DietAppController.GetXDayNutrientTotals(this.theUserId, date, toDisplay);

                for (int i = 0; i < toDisplay; i++)
                {
                    string day = date.AddDays(i).ToString("MM/dd");
                    if ((dataPoints.Count > 0) && dataPoints[0].Date.ToString("MM/dd").Equals(day))
                    {
                        int value = 0;
                        if (name.Equals("Calories"))
                        {
                            value = (int)dataPoints[0].Calories;
                        }
                        else if (name.Equals("Fat"))
                        {
                            value = (int)dataPoints[0].Fat;
                        }
                        else if (name.Equals("Protein"))
                        {
                            value = (int)dataPoints[0].Protein;
                        }
                        else if (name.Equals("Carbohydrates"))
                        {
                            value = (int)dataPoints[0].Carbohydrates;
                        }

                        series1.Points.AddXY(day, value);
                        if ((value * 1.1) > this.maxValue)
                        {
                            this.maxValue = Convert.ToInt32(value * 1.1);
                        }

                        dataPoints.RemoveAt(0);
                    }
                    else
                    {
                        // No data for this day, but still need to add something so the date
                        // shows up on the X axis 
                        series1.Points.AddXY(day, 0);
                    }
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                return;
            }

            this.chart1.Series.Add(series1);
        }

        /// <summary>
        /// Clicks the previous button.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void PrevButton_Click(object sender, EventArgs e)
        {
            this.reportPage++;
            this.nextButton.Enabled = true;

            this.RunReport();
        }

        /// <summary>
        /// Click the next button.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            this.reportPage--;
            if (this.reportPage == 1)
            {
                this.nextButton.Enabled = false;
            }

            this.RunReport();
        }

        /// <summary>
        /// Button that prints current chart data.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void BTNPrint_Click(object sender, EventArgs e)
        {
            var pd = new System.Drawing.Printing.PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.PrintChart);
            pd.DefaultPageSettings.Landscape = true;

            PrintPreviewDialog pdi = new PrintPreviewDialog();
            pdi.Document = pd;
            if (pdi.ShowDialog() == DialogResult.OK)
            {
                pdi.Document.Print();
            }
        }

        /// <summary>
        /// Sets up the chart to print.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="ev">Click on object.</param>
        private void PrintChart(object sender, PrintPageEventArgs ev)
        {
            using (var f = new System.Drawing.Font("Arial", 10))
            {
                var size = ev.Graphics.MeasureString(Text, f);
                ev.Graphics.DrawString(string.Empty, f, Brushes.Black, ev.PageBounds.X + ((ev.PageBounds.Width - size.Width) / 2), ev.PageBounds.Y);
            }

            // Note, the chart printing code wants to print in pixels.
            Rectangle marginBounds = ev.MarginBounds;
            if (ev.Graphics.PageUnit != GraphicsUnit.Pixel)
            {
                ev.Graphics.PageUnit = GraphicsUnit.Pixel;
                marginBounds.X = (int)(marginBounds.X * (ev.Graphics.DpiX / 100f));
                marginBounds.Y = (int)(marginBounds.Y * (ev.Graphics.DpiY / 100f));
                marginBounds.Width = (int)(marginBounds.Width * (ev.Graphics.DpiX / 100f));
                marginBounds.Height = (int)(marginBounds.Height * (ev.Graphics.DpiY / 100f));
            }

            this.chart1.Printing.PrintPaint(ev.Graphics, marginBounds);
        }

        /// <summary>
        /// Creates the initial look.
        /// </summary>
        private void InitialLook()
        {
            // NumericUpDown
            this.nudDays = new NumericUpDown();
            this.nudDays.Value = 10;

            // Report Prev/Next Buttons
            this.prevButton = new Button();
            this.prevButton.Text = "Prev " + this.nudDays.Value + " Days";
            this.nextButton = new Button();
            this.nextButton.Text = "Next " + this.nudDays.Value + " Days";
        }
    }
}
