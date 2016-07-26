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
    using System.Drawing.Printing;
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
        private int reportPage;

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

            this.theUserId = currentUserId;
            this.minValue = 15;
            this.maxValue = 185;
            this.reportPage = 1;
            this.InitialLook();
            this.InitializeComponent();
        }

        /// <summary>
        /// Loads the reports information.
        /// </summary>
        /// <param name="sender">Sending object.</param>
        /// <param name="e">Click on object.</param>
        public void WellnessReportForm_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
            System.Threading.Thread.Sleep(500);
            this.RunReport();
            System.Windows.Forms.Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Runs the report chart data.
        /// </summary>
        private void RunReport()
        {
            this.chartUserData.Legends.Clear();
            this.chartUserData.Series.Clear();
            SeriesChartType chartType = this.ChartType();
            this.chartUserData.ChartAreas.Clear();
            this.chartUserData.Titles.Clear();
            this.minValue = 185;
            this.maxValue = 15;
            string title = "Wellness Data";

            if (this.checkWeight.Checked == false && this.checkHeartRate.Checked == false && this.checkBP.Checked == false && this.checkBMI.Checked == false)
            {
                this.checkWeight.Checked = true;
            }
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
            if (this.checkWeight.Checked == true)
            {
                int type = 1;
                string name = DietAppController.GetType(type).MeasurementTypeName + " (" + DietAppController.GetType(type).MeasurementDefaultUnit + ")";
                this.ChartSeries(type, name, System.Drawing.Color.Blue, chartType);
                this.ChartLegends(name);
            }

            if (this.checkHeartRate.Checked == true)
            {
                int type = 2;
                string name = DietAppController.GetType(type).MeasurementTypeName + " (" + DietAppController.GetType(type).MeasurementDefaultUnit + ")";
                this.ChartSeries(type, name, System.Drawing.Color.Red, chartType);
                this.ChartLegends(name);
            }

            if (this.checkBP.Checked == true)
            {
                int type = 3;
                string name = DietAppController.GetType(type).MeasurementTypeName + " \n(" + DietAppController.GetType(type).MeasurementDefaultUnit + ")";
                this.ChartSeries(type, name, System.Drawing.Color.Purple, chartType);
                this.ChartLegends(name);
                type = 4;
                name = DietAppController.GetType(type).MeasurementTypeName + " \n(" + DietAppController.GetType(type).MeasurementDefaultUnit + ")";
                this.ChartSeries(type, name, System.Drawing.Color.Green, chartType);
                this.ChartLegends(name);                
            }

            if (this.checkBMI.Checked == true)
            {
                int type = 1;
                string name = "BMI (lb./sqrt in.)";
                this.ChartSeriesBMI(type, name, System.Drawing.Color.Black, chartType);
                this.ChartLegends(name);
            }

            this.ChartAreas(this.minValue, this.maxValue, title);
            this.ChartTitle(title);

            this.chartUserData.Invalidate();

            this.prevButton.Text = "Prev " + this.nudDays.Value + " Days";
            this.nextButton.Text = "Next " + this.nudDays.Value + " Days";

            System.Windows.Forms.Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Sets up the look and style of the user's chart, Areas.
        /// </summary>
        /// <param name="min">Minimum chart value.</param>
        /// <param name="max">Maximum chart value.</param>
        /// <param name="title">Title of the chart.</param>
        private void ChartAreas(double min, double max, string title)
        {
            if (min == 185)
            {
                min = 15;
            }

            if (max == 15)
            {
                max = 185;
            }

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
            var titles1 = new System.Windows.Forms.DataVisualization.Charting.Title
            {
                Name = title,
                Text = DietAppController.getUserData(this.theUserId).firstName + "'s " + title,
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
        /// <param name="name">The name of the data.</param>
        /// <param name="color">The color of the line.</param>
        /// <param name="chartType">Type of chart to display.</param>
        private void ChartSeries(int type, string name, Color color, SeriesChartType chartType)
        {
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = name,
                Color = color,
                BorderWidth = 5,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = chartType,
                MarkerStyle = MarkerStyle.Circle,
            };

            int toDisplay = (int)this.nudDays.Value;
            DateTime date = new DateTime();
            date = DateTime.Now.AddDays(1 - (this.reportPage * toDisplay));
            List<DailyMeasurements> chartList = DietAppController.GetUserChartDataXDays(this.theUserId, type, date, toDisplay);

            if (chartList.Count > 0)
            {
                foreach (DailyMeasurements measurements in chartList)
                {
                    series1.Points.AddXY(measurements.Date.ToShortDateString(), measurements.Measurement);
                    if ((measurements.Measurement * 1.1) > this.maxValue)
                    {
                        this.maxValue = Convert.ToInt32(measurements.Measurement * 1.1);
                    }

                    if ((measurements.Measurement * 0.9) < this.minValue && !(measurements.Measurement == 0))
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

                this.maxValue = 185;
                this.minValue = 15;
            }

            this.chartUserData.Series.Add(series1);
        }

        /// <summary>
        /// Sets up the look and style of the user's chart, Series.
        /// </summary>
        /// <param name="type">The type of the measurement.</param>
        /// <param name="name">The name of the data.</param>
        /// <param name="color">The color of the line.</param>
        /// <param name="chartType">Type of chart to display.</param>
        private void ChartSeriesBMI(int type, string name, Color color, SeriesChartType chartType)
        {
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = name,
                Color = color,
                BorderWidth = 5,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = chartType,
                MarkerStyle = MarkerStyle.Circle,
            };

            int toDisplay = (int)this.nudDays.Value;
            DateTime date = new DateTime();
            date = DateTime.Now.AddDays(1 - (this.reportPage * toDisplay));
            List<DailyMeasurements> chartList = DietAppController.GetUserChartDataXDays(this.theUserId, type, date, toDisplay);

            if (chartList.Count > 0)
            {
                foreach (DailyMeasurements measurements in chartList)
                {
                    double bmi = Math.Round(measurements.Measurement * 703 / Math.Pow(DietAppController.getUserData(this.theUserId).heightInches, 2), 2);
                    
                    series1.Points.AddXY(measurements.Date.ToShortDateString(), bmi);
                    if ((bmi * 1.1) > this.maxValue)
                    {
                        this.maxValue = Convert.ToInt32(bmi * 1.1);
                    }

                    if ((bmi * 0.9) < this.minValue && !(measurements.Measurement == 0))
                    {
                        this.minValue = Convert.ToInt32(bmi * 0.9);
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

                this.maxValue = 185;
                this.minValue = 15;
            }

            this.chartUserData.Series.Add(series1);
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

            this.RunReport();
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

            this.chartUserData.Printing.PrintPaint(ev.Graphics, marginBounds);
        }

        /// <summary>
        /// Returns the chart type.
        /// </summary>
        /// <returns>The chart type.</returns>
        private SeriesChartType ChartType()
        {
            if (radioBubble.Checked)
            {
                return SeriesChartType.Bubble;
            }
            else if (radioColumn.Checked)
            {
                return SeriesChartType.Column;
            }
            else if (radioLine.Checked)
            {
                return SeriesChartType.Line;
            }
            else if (radioPoint.Checked)
            {
                return SeriesChartType.Point;
            }
            else
            {
                return SeriesChartType.Bubble;
            }
        }

        /// <summary>
        /// Creates the initial look.
        /// </summary>
        private void InitialLook()
        {
            // Radio Buttons
            this.radioBubble = new RadioButton();
            this.radioBubble.Checked = true;
            this.radioColumn = new RadioButton();
            this.radioColumn.Checked = true;
            this.radioLine = new RadioButton();
            this.radioLine.Checked = true;
            this.radioPoint = new RadioButton();
            this.radioPoint.Checked = true;

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