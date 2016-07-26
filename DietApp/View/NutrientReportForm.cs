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

        /// <summary>The report start date page.</summary>
        private DateTime date;

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

            this.reportPage = 1;
            this.theUserId = currentUserId;
            this.date = new DateTime();
            this.nudDays = new NumericUpDown();
            this.nudDays.Value = 10;
            this.prevButton = new Button();
            this.prevButton.Text = "Prev " + this.nudDays.Value + " Days";
            this.nextButton = new Button();
            this.nextButton.Text = "Next " + this.nudDays.Value + " Days";
            this.InitializeComponent();
        }

        /// <summary>
        /// Load the form.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        public void NutrientReportForm_Load(object sender, EventArgs e)
        {
            this.RunReport();
        }

        /// <summary>
        /// Runs the report.
        /// </summary>
        public void RunReport()
        {
            this.chart1.Series.Clear();
            this.maxValue = 250;

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;

            this.ChartSeries();
            string title = "Nutrient Values";
            this.ChartAreas(this.maxValue, title);
            this.ChartTitle(title);

            this.chart1.Invalidate();

            this.prevButton.Text = "Prev " + this.nudDays.Value + " Days";
            this.nextButton.Text = "Next " + this.nudDays.Value + " Days";
        }

        /// <summary>
        /// Sets up the look and style of the user's chart, Areas.
        /// </summary>
        /// <param name="max">Maximum chart value.</param>
        /// <param name="title">Title of the chart.</param>
        private void ChartAreas(double max, string title)
        {
            if (max == 0)
            {
                max = 250;
            }

            this.chart1.ChartAreas.Clear();

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

            var axisY2 = new System.Windows.Forms.DataVisualization.Charting.Axis
            {
                Title = "calories",
            };

            var chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea
            {
                AxisX = axisX,
                AxisY = axisY,
                AxisY2 = axisY2
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
        /// Sets up the look and style of the user's chart, Series.
        /// </summary>
        private void ChartSeries()
        {
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Fat",
                Color = System.Drawing.Color.Green,
                BorderWidth = 5,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Column,
            };

            var series2 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Protein",
                Color = System.Drawing.Color.Yellow,
                BorderWidth = 5,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Column,
            };

            var series3 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Carbohydrates",
                Color = System.Drawing.Color.Red,
                BorderWidth = 5,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Column,
            };

            var series4 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Calories",
                Color = System.Drawing.Color.Blue,
                BorderWidth = 5,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Column,
            };

            int toDisplay = (int)this.nudDays.Value;
            this.date = DateTime.Now.AddDays(1 - (this.reportPage * toDisplay));

            try
            {
                List<DailyNutrition> dataPoints = DietAppController.GetXDayNutrientTotals(this.theUserId, this.date, toDisplay);
                System.Windows.Forms.Cursor.Current = Cursors.Default;

                for (int i = 0; i < toDisplay; i++)
                {
                    string day = date.AddDays(i).ToString("MM/dd");
                    if ((dataPoints.Count > 0) && dataPoints[0].Date.ToString("MM/dd").Equals(day))
                    {
                        //day = day + "\n\n" + dataPoints[0].Calories + "\ncalories";
                        series1.Points.AddXY(day, dataPoints[0].Fat);
                        if ((dataPoints[0].Fat * 1.1) > this.maxValue)
                        {
                            this.maxValue = Convert.ToInt32(dataPoints[0].Fat * 1.1);
                        }
                        series2.Points.AddXY(day, dataPoints[0].Protein);
                        if ((dataPoints[0].Protein * 1.1) > this.maxValue)
                        {
                            this.maxValue = Convert.ToInt32(dataPoints[0].Protein * 1.1);
                        }
                        series3.Points.AddXY(day, dataPoints[0].Carbohydrates);
                        if ((dataPoints[0].Carbohydrates * 1.1) > this.maxValue)
                        {
                            this.maxValue = Convert.ToInt32(dataPoints[0].Carbohydrates * 1.1);
                        }
                        series4.Points.AddXY(day, dataPoints[0].Calories);

                        dataPoints.RemoveAt(0);
                    }
                    else
                    {
                        // No data for this day, but still need to add something so the date
                        // shows up on the X axis 
                        series1.Points.AddXY(day, 0);
                        series2.Points.AddXY(day, 0);
                        series3.Points.AddXY(day, 0);
                        series4.Points.AddXY(day, 0);
                    }

                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                return;
            }

            this.chart1.ChartAreas["ChartArea1"].AxisY2.Enabled = AxisEnabled.True;
            series4.YAxisType = AxisType.Secondary;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
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
                ev.Graphics.DrawString("Whatever text you want", f, Brushes.Black, ev.PageBounds.X + ((ev.PageBounds.Width - size.Width) / 2), ev.PageBounds.Y);
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
    }
}