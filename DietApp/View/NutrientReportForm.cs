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
    using DietApp.Controller;
    using DietApp.Model;

    /// <summary>
    /// The form for nutrient report.
    /// </summary>
    public partial class NutrientReportForm : Form
    {
        private const int CHART_Y_AXIS_MAX = 250;
        private Users theUser;
        private int reportPage = 1;

        /// <summary>
        /// Initializes a new instance of the <see cref="NutrientReportForm"/> class.
        /// </summary>
        /// <param name="currentUser">The current user.</param>
        public NutrientReportForm(Users currentUser)
        {
            if (currentUser == null)
            {
                MessageBox.Show("Error loading Food Entries Window. No user specified");
                
                // Need to call Close() as an event handler for Load event
                this.Load += (s, e) => this.Close();
            }

            this.theUser = currentUser;
            this.InitializeComponent();
        }

        /// <summary>
        /// Load the form.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void NutrientReportForm_Load(object sender, EventArgs e)
        {
            this.chart1.ChartAreas[0].AxisX.Interval = 1;
            this.chart1.Series.Clear();
            this.chart1.Series.Add("Fat");
            this.chart1.Series.Add("Protein");
            this.chart1.Series.Add("Carbohydrates");
            this.chart1.ChartAreas[0].AxisY.Maximum = CHART_Y_AXIS_MAX;
            this.chart1.ChartAreas[0].AxisY.Minimum = 0;
            this.runReport();
        }

        /// <summary>
        /// Runs the report.
        /// </summary>
        public void runReport()
        {
            DateTime reportStartDate = DateTime.Now.AddDays((this.reportPage * (-10)) + 1);
            foreach (var series in this.chart1.Series)
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
                    if ((dataPoints.Count > 0) && dataPoints[i].Date.ToString("MM/dd").Equals(day))
                    {
                        day = day + "\n\n" + dataPoints[0].Calories + "\ncalories";
                        this.chart1.Series["Fat"].Points.AddXY(day, dataPoints[i].Fat);
                        this.chart1.Series["Protein"].Points.AddXY(day, dataPoints[i].Protein);
                        this.chart1.Series["Carbohydrates"].Points.AddXY(day, dataPoints[i].Carbohydrates);
                        dataPoints.RemoveAt(i);
                    }
                    else
                    {
                        // No data for this day so use zeros
                        day = day + "\n\n\n no data";
                        this.chart1.Series["Fat"].Points.AddXY(day, 0);
                        this.chart1.Series["Protein"].Points.AddXY(day, 0);
                        this.chart1.Series["Carbohydrates"].Points.AddXY(day, 0);
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

        /// <summary>
        /// Clicks the previous button.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void prevButton_Click(object sender, EventArgs e)
        {
            this.reportPage++;
            this.nextButton.Enabled = true;
            this.runReport();
        }

        /// <summary>
        /// Click the next button.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            this.reportPage--;
            if (this.reportPage == 1)
            {
                this.nextButton.Enabled = false;
            }

            this.runReport();
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

            PrintDialog pdi = new PrintDialog();
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