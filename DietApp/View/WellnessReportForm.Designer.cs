namespace DietApp.View
{
    partial class WellnessReportForm
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartUserData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoad = new System.Windows.Forms.Button();
            this.rbWeight = new System.Windows.Forms.RadioButton();
            this.rbHeartRate = new System.Windows.Forms.RadioButton();
            this.rbBP = new System.Windows.Forms.RadioButton();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.BTNPrint = new System.Windows.Forms.Button();
            this.rbBMI = new System.Windows.Forms.RadioButton();
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            this.lbDays = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartUserData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).BeginInit();
            this.SuspendLayout();
            // 
            // chartUserData
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartArea1";
            this.chartUserData.ChartAreas.Add(chartArea1);
            this.chartUserData.Location = new System.Drawing.Point(12, 12);
            this.chartUserData.Name = "chartUserData";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "UserData";
            this.chartUserData.Series.Add(series1);
            this.chartUserData.Size = new System.Drawing.Size(578, 320);
            this.chartUserData.TabIndex = 0;
            this.chartUserData.Text = "chart1";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(258, 367);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(117, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BTNLoad_Click);
            // 
            // rbWeight
            // 
            this.rbWeight.AutoSize = true;
            this.rbWeight.Location = new System.Drawing.Point(12, 344);
            this.rbWeight.Name = "rbWeight";
            this.rbWeight.Size = new System.Drawing.Size(59, 17);
            this.rbWeight.TabIndex = 2;
            this.rbWeight.TabStop = true;
            this.rbWeight.Text = "Weight";
            this.rbWeight.UseVisualStyleBackColor = true;
            // 
            // rbHeartRate
            // 
            this.rbHeartRate.AutoSize = true;
            this.rbHeartRate.Location = new System.Drawing.Point(77, 344);
            this.rbHeartRate.Name = "rbHeartRate";
            this.rbHeartRate.Size = new System.Drawing.Size(77, 17);
            this.rbHeartRate.TabIndex = 3;
            this.rbHeartRate.TabStop = true;
            this.rbHeartRate.Text = "Heart Rate";
            this.rbHeartRate.UseVisualStyleBackColor = true;
            // 
            // rbBP
            // 
            this.rbBP.AutoSize = true;
            this.rbBP.Location = new System.Drawing.Point(160, 344);
            this.rbBP.Name = "rbBP";
            this.rbBP.Size = new System.Drawing.Size(39, 17);
            this.rbBP.TabIndex = 4;
            this.rbBP.TabStop = true;
            this.rbBP.Text = "BP";
            this.rbBP.UseVisualStyleBackColor = true;
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(12, 367);
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
            this.nextButton.Location = new System.Drawing.Point(135, 367);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(117, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next 10 Days";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BTNPrint
            // 
            this.BTNPrint.Location = new System.Drawing.Point(381, 367);
            this.BTNPrint.Name = "BTNPrint";
            this.BTNPrint.Size = new System.Drawing.Size(117, 23);
            this.BTNPrint.TabIndex = 5;
            this.BTNPrint.Text = "Print";
            this.BTNPrint.UseVisualStyleBackColor = true;
            this.BTNPrint.Click += new System.EventHandler(this.BTNPrint_Click);
            // 
            // rbBMI
            // 
            this.rbBMI.AutoSize = true;
            this.rbBMI.Location = new System.Drawing.Point(205, 344);
            this.rbBMI.Name = "rbBMI";
            this.rbBMI.Size = new System.Drawing.Size(44, 17);
            this.rbBMI.TabIndex = 6;
            this.rbBMI.TabStop = true;
            this.rbBMI.Text = "BMI";
            this.rbBMI.UseVisualStyleBackColor = true;
            // 
            // nudDays
            // 
            this.nudDays.Location = new System.Drawing.Point(545, 344);
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
            this.nudDays.TabIndex = 7;
            this.nudDays.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // lbDays
            // 
            this.lbDays.AutoSize = true;
            this.lbDays.Location = new System.Drawing.Point(459, 348);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(80, 13);
            this.lbDays.TabIndex = 8;
            this.lbDays.Text = "Days to Display";
            // 
            // WellnessReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 440);
            this.Controls.Add(this.lbDays);
            this.Controls.Add(this.nudDays);
            this.Controls.Add(this.rbBMI);
            this.Controls.Add(this.BTNPrint);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.rbBP);
            this.Controls.Add(this.rbHeartRate);
            this.Controls.Add(this.rbWeight);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.chartUserData);
            this.Name = "WellnessReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.WellnessReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartUserData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartUserData;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.RadioButton rbWeight;
        private System.Windows.Forms.RadioButton rbHeartRate;
        private System.Windows.Forms.RadioButton rbBP;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button BTNPrint;
        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.NumericUpDown nudDays;
        private System.Windows.Forms.RadioButton rbBMI;
    }
}