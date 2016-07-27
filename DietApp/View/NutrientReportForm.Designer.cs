namespace DietApp.View
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
            this.checkCalories = new System.Windows.Forms.CheckBox();
            this.checkFat = new System.Windows.Forms.CheckBox();
            this.checkProtein = new System.Windows.Forms.CheckBox();
            this.checkCarbohydrates = new System.Windows.Forms.CheckBox();
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
            this.chart1.Location = new System.Drawing.Point(18, 18);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1140, 437);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(123, 503);
            this.prevButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(176, 35);
            this.prevButton.TabIndex = 5;
            this.prevButton.Text = "Prev 10 Days";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(308, 503);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(176, 35);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Next 10 Days";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BTNPrint
            // 
            this.BTNPrint.Location = new System.Drawing.Point(492, 503);
            this.BTNPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNPrint.Name = "BTNPrint";
            this.BTNPrint.Size = new System.Drawing.Size(176, 35);
            this.BTNPrint.TabIndex = 7;
            this.BTNPrint.Text = "Print";
            this.BTNPrint.UseVisualStyleBackColor = true;
            this.BTNPrint.Click += new System.EventHandler(this.BTNPrint_Click);
            // 
            // lbDays
            // 
            this.lbDays.AutoSize = true;
            this.lbDays.Location = new System.Drawing.Point(676, 511);
            this.lbDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(118, 20);
            this.lbDays.TabIndex = 8;
            this.lbDays.Text = "Days to Display";
            // 
            // nudDays
            // 
            this.nudDays.Location = new System.Drawing.Point(806, 505);
            this.nudDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.nudDays.Size = new System.Drawing.Size(66, 26);
            this.nudDays.TabIndex = 9;
            this.nudDays.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDays.ValueChanged += new System.EventHandler(this.NutrientReportForm_Load);
            // 
            // checkCalories
            // 
            this.checkCalories.AutoSize = true;
            this.checkCalories.Checked = true;
            this.checkCalories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCalories.Location = new System.Drawing.Point(20, 466);
            this.checkCalories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkCalories.Name = "checkCalories";
            this.checkCalories.Size = new System.Drawing.Size(92, 24);
            this.checkCalories.TabIndex = 1;
            this.checkCalories.Text = "Calories";
            this.checkCalories.UseVisualStyleBackColor = true;
            this.checkCalories.CheckedChanged += new System.EventHandler(this.NutrientReportForm_Load);
            this.checkCalories.CheckStateChanged += new System.EventHandler(this.NutrientReportForm_Load);
            // 
            // checkFat
            // 
            this.checkFat.AutoSize = true;
            this.checkFat.Location = new System.Drawing.Point(124, 466);
            this.checkFat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkFat.Name = "checkFat";
            this.checkFat.Size = new System.Drawing.Size(59, 24);
            this.checkFat.TabIndex = 2;
            this.checkFat.Text = "Fat";
            this.checkFat.UseVisualStyleBackColor = true;
            this.checkFat.CheckedChanged += new System.EventHandler(this.NutrientReportForm_Load);
            // 
            // checkProtein
            // 
            this.checkProtein.AutoSize = true;
            this.checkProtein.Location = new System.Drawing.Point(212, 466);
            this.checkProtein.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkProtein.Name = "checkProtein";
            this.checkProtein.Size = new System.Drawing.Size(85, 24);
            this.checkProtein.TabIndex = 3;
            this.checkProtein.Text = "Protein";
            this.checkProtein.UseVisualStyleBackColor = true;
            this.checkProtein.CheckedChanged += new System.EventHandler(this.NutrientReportForm_Load);
            // 
            // checkCarbohydrates
            // 
            this.checkCarbohydrates.AutoSize = true;
            this.checkCarbohydrates.Location = new System.Drawing.Point(310, 466);
            this.checkCarbohydrates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkCarbohydrates.Name = "checkCarbohydrates";
            this.checkCarbohydrates.Size = new System.Drawing.Size(139, 24);
            this.checkCarbohydrates.TabIndex = 4;
            this.checkCarbohydrates.Text = "Carbohydrates";
            this.checkCarbohydrates.UseVisualStyleBackColor = true;
            this.checkCarbohydrates.CheckedChanged += new System.EventHandler(this.NutrientReportForm_Load);
            // 
            // NutrientReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 586);
            this.Controls.Add(this.checkCarbohydrates);
            this.Controls.Add(this.checkProtein);
            this.Controls.Add(this.checkFat);
            this.Controls.Add(this.checkCalories);
            this.Controls.Add(this.lbDays);
            this.Controls.Add(this.nudDays);
            this.Controls.Add(this.BTNPrint);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.CheckBox checkCalories;
        private System.Windows.Forms.CheckBox checkFat;
        private System.Windows.Forms.CheckBox checkProtein;
        private System.Windows.Forms.CheckBox checkCarbohydrates;
    }
}