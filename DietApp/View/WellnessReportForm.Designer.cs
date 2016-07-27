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
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.BTNPrint = new System.Windows.Forms.Button();
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            this.lbDays = new System.Windows.Forms.Label();
            this.checkWeight = new System.Windows.Forms.CheckBox();
            this.checkHeartRate = new System.Windows.Forms.CheckBox();
            this.checkBP = new System.Windows.Forms.CheckBox();
            this.checkBMI = new System.Windows.Forms.CheckBox();
            this.radioBubble = new System.Windows.Forms.RadioButton();
            this.radioColumn = new System.Windows.Forms.RadioButton();
            this.radioLine = new System.Windows.Forms.RadioButton();
            this.radioPoint = new System.Windows.Forms.RadioButton();
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
            this.chartUserData.Location = new System.Drawing.Point(18, 19);
            this.chartUserData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartUserData.Name = "chartUserData";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "UserData";
            this.chartUserData.Series.Add(series1);
            this.chartUserData.Size = new System.Drawing.Size(1124, 492);
            this.chartUserData.TabIndex = 0;
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(82, 594);
            this.prevButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(217, 35);
            this.prevButton.TabIndex = 11;
            this.prevButton.Text = "Prev 10 Days";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(308, 594);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(224, 35);
            this.nextButton.TabIndex = 12;
            this.nextButton.Text = "Next 10 Days";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BTNPrint
            // 
            this.BTNPrint.Location = new System.Drawing.Point(763, 594);
            this.BTNPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNPrint.Name = "BTNPrint";
            this.BTNPrint.Size = new System.Drawing.Size(190, 35);
            this.BTNPrint.TabIndex = 13;
            this.BTNPrint.Text = "Print";
            this.BTNPrint.UseVisualStyleBackColor = true;
            this.BTNPrint.Click += new System.EventHandler(this.BTNPrint_Click);
            // 
            // nudDays
            // 
            this.nudDays.Location = new System.Drawing.Point(888, 521);
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
            this.nudDays.TabIndex = 10;
            this.nudDays.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDays.ValueChanged += new System.EventHandler(this.WellnessReportForm_Load);
            // 
            // lbDays
            // 
            this.lbDays.AutoSize = true;
            this.lbDays.Location = new System.Drawing.Point(758, 528);
            this.lbDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(118, 20);
            this.lbDays.TabIndex = 9;
            this.lbDays.Text = "Days to Display";
            // 
            // checkWeight
            // 
            this.checkWeight.AutoSize = true;
            this.checkWeight.Checked = true;
            this.checkWeight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkWeight.Location = new System.Drawing.Point(83, 521);
            this.checkWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkWeight.Name = "checkWeight";
            this.checkWeight.Size = new System.Drawing.Size(85, 24);
            this.checkWeight.TabIndex = 1;
            this.checkWeight.Text = "Weight";
            this.checkWeight.UseVisualStyleBackColor = true;
            this.checkWeight.CheckedChanged += new System.EventHandler(this.WellnessReportForm_Load);
            // 
            // checkHeartRate
            // 
            this.checkHeartRate.AutoSize = true;
            this.checkHeartRate.Location = new System.Drawing.Point(182, 520);
            this.checkHeartRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkHeartRate.Name = "checkHeartRate";
            this.checkHeartRate.Size = new System.Drawing.Size(114, 24);
            this.checkHeartRate.TabIndex = 2;
            this.checkHeartRate.Text = "Heart Rate";
            this.checkHeartRate.UseVisualStyleBackColor = true;
            this.checkHeartRate.CheckedChanged += new System.EventHandler(this.WellnessReportForm_Load);
            // 
            // checkBP
            // 
            this.checkBP.AutoSize = true;
            this.checkBP.Location = new System.Drawing.Point(308, 521);
            this.checkBP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBP.Name = "checkBP";
            this.checkBP.Size = new System.Drawing.Size(143, 24);
            this.checkBP.TabIndex = 3;
            this.checkBP.Text = "Blood Pressure";
            this.checkBP.UseVisualStyleBackColor = true;
            this.checkBP.CheckedChanged += new System.EventHandler(this.WellnessReportForm_Load);
            // 
            // checkBMI
            // 
            this.checkBMI.AutoSize = true;
            this.checkBMI.Location = new System.Drawing.Point(465, 521);
            this.checkBMI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBMI.Name = "checkBMI";
            this.checkBMI.Size = new System.Drawing.Size(64, 24);
            this.checkBMI.TabIndex = 4;
            this.checkBMI.Text = "BMI";
            this.checkBMI.UseVisualStyleBackColor = true;
            this.checkBMI.CheckedChanged += new System.EventHandler(this.WellnessReportForm_Load);
            // 
            // radioBubble
            // 
            this.radioBubble.AutoSize = true;
            this.radioBubble.Checked = true;
            this.radioBubble.Location = new System.Drawing.Point(82, 559);
            this.radioBubble.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBubble.Name = "radioBubble";
            this.radioBubble.Size = new System.Drawing.Size(84, 24);
            this.radioBubble.TabIndex = 5;
            this.radioBubble.TabStop = true;
            this.radioBubble.Text = "Bubble";
            this.radioBubble.UseVisualStyleBackColor = true;
            this.radioBubble.Click += new System.EventHandler(this.WellnessReportForm_Load);
            // 
            // radioColumn
            // 
            this.radioColumn.AutoSize = true;
            this.radioColumn.Location = new System.Drawing.Point(182, 559);
            this.radioColumn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioColumn.Name = "radioColumn";
            this.radioColumn.Size = new System.Drawing.Size(88, 24);
            this.radioColumn.TabIndex = 6;
            this.radioColumn.TabStop = true;
            this.radioColumn.Text = "Column";
            this.radioColumn.UseVisualStyleBackColor = true;
            this.radioColumn.Click += new System.EventHandler(this.WellnessReportForm_Load);
            // 
            // radioLine
            // 
            this.radioLine.AutoSize = true;
            this.radioLine.Location = new System.Drawing.Point(308, 559);
            this.radioLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioLine.Name = "radioLine";
            this.radioLine.Size = new System.Drawing.Size(64, 24);
            this.radioLine.TabIndex = 7;
            this.radioLine.TabStop = true;
            this.radioLine.Text = "Line";
            this.radioLine.UseVisualStyleBackColor = true;
            this.radioLine.Click += new System.EventHandler(this.WellnessReportForm_Load);
            // 
            // radioPoint
            // 
            this.radioPoint.AutoSize = true;
            this.radioPoint.Location = new System.Drawing.Point(465, 559);
            this.radioPoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioPoint.Name = "radioPoint";
            this.radioPoint.Size = new System.Drawing.Size(70, 24);
            this.radioPoint.TabIndex = 8;
            this.radioPoint.TabStop = true;
            this.radioPoint.Text = "Point";
            this.radioPoint.UseVisualStyleBackColor = true;
            this.radioPoint.Click += new System.EventHandler(this.WellnessReportForm_Load);
            // 
            // WellnessReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 649);
            this.Controls.Add(this.radioPoint);
            this.Controls.Add(this.radioLine);
            this.Controls.Add(this.radioColumn);
            this.Controls.Add(this.radioBubble);
            this.Controls.Add(this.checkBMI);
            this.Controls.Add(this.checkBP);
            this.Controls.Add(this.checkHeartRate);
            this.Controls.Add(this.checkWeight);
            this.Controls.Add(this.lbDays);
            this.Controls.Add(this.nudDays);
            this.Controls.Add(this.BTNPrint);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.chartUserData);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WellnessReportForm";
            this.Text = "Wellness Report";
            this.Load += new System.EventHandler(this.WellnessReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartUserData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartUserData;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button BTNPrint;
        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.NumericUpDown nudDays;
        private System.Windows.Forms.CheckBox checkWeight;
        private System.Windows.Forms.CheckBox checkHeartRate;
        private System.Windows.Forms.CheckBox checkBP;
        private System.Windows.Forms.CheckBox checkBMI;
        private System.Windows.Forms.RadioButton radioBubble;
        private System.Windows.Forms.RadioButton radioColumn;
        private System.Windows.Forms.RadioButton radioLine;
        private System.Windows.Forms.RadioButton radioPoint;
    }
}