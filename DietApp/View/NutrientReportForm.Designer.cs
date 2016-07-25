﻿namespace DietApp.View
{
    partial class NutrientReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.BTNPrint = new System.Windows.Forms.Button();
            this.lbDays = new System.Windows.Forms.Label();
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(589, 284);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(82, 327);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(117, 23);
            this.prevButton.TabIndex = 1;
            this.prevButton.Text = "Prev 10 Days";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(205, 327);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(117, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next 10 Days";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BTNPrint
            // 
            this.BTNPrint.Location = new System.Drawing.Point(328, 327);
            this.BTNPrint.Name = "BTNPrint";
            this.BTNPrint.Size = new System.Drawing.Size(117, 23);
            this.BTNPrint.TabIndex = 3;
            this.BTNPrint.Text = "Print";
            this.BTNPrint.UseVisualStyleBackColor = true;
            this.BTNPrint.Click += new System.EventHandler(this.BTNPrint_Click);
            // 
            // lbDays
            // 
            this.lbDays.AutoSize = true;
            this.lbDays.Location = new System.Drawing.Point(451, 332);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(80, 13);
            this.lbDays.TabIndex = 10;
            this.lbDays.Text = "Days to Display";
            // 
            // nudDays
            // 
            this.nudDays.Location = new System.Drawing.Point(537, 328);
            this.nudDays.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudDays.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudDays.Name = "nudDays";
            this.nudDays.Size = new System.Drawing.Size(44, 20);
            this.nudDays.TabIndex = 9;
            this.nudDays.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDays.ValueChanged += new System.EventHandler(this.NutrientReportForm_Load);
            // 
            // NutrientReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 378);
            this.Controls.Add(this.lbDays);
            this.Controls.Add(this.nudDays);
            this.Controls.Add(this.BTNPrint);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.chart1);
            this.Name = "NutrientReportForm";
            this.Text = "Nutrient Report";
            this.Load += new System.EventHandler(this.NutrientReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button BTNPrint;
        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.NumericUpDown nudDays;
    }
}