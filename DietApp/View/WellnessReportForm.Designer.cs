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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartUserData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rbWeight = new System.Windows.Forms.RadioButton();
            this.rbHeartRate = new System.Windows.Forms.RadioButton();
            this.rbBP = new System.Windows.Forms.RadioButton();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.BTNPrint = new System.Windows.Forms.Button();
            this.rbBMI = new System.Windows.Forms.RadioButton();
            this.lbDays = new System.Windows.Forms.Label();
            this.nudDaysComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartUserData)).BeginInit();
            this.SuspendLayout();
            // 
            // chartUserData
            // 
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.Name = "ChartArea1";
            this.chartUserData.ChartAreas.Add(chartArea2);
            this.chartUserData.Location = new System.Drawing.Point(12, 12);
            this.chartUserData.Name = "chartUserData";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "UserData";
            this.chartUserData.Series.Add(series2);
            this.chartUserData.Size = new System.Drawing.Size(578, 320);
            this.chartUserData.TabIndex = 0;
            this.chartUserData.Text = "chart1";
            // 
            // rbWeight
            // 
            this.rbWeight.AutoSize = true;
            this.rbWeight.Checked = true;
            this.rbWeight.Location = new System.Drawing.Point(12, 344);
            this.rbWeight.Name = "rbWeight";
            this.rbWeight.Size = new System.Drawing.Size(59, 17);
            this.rbWeight.TabIndex = 2;
            this.rbWeight.TabStop = true;
            this.rbWeight.Text = "Weight";
            this.rbWeight.UseVisualStyleBackColor = true;
            this.rbWeight.Click += new System.EventHandler(this.radioButtons_SelectedValueChanged);
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
            this.rbHeartRate.Click += new System.EventHandler(this.radioButtons_SelectedValueChanged);
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
            this.rbBP.Click += new System.EventHandler(this.radioButtons_SelectedValueChanged);
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
            this.BTNPrint.Location = new System.Drawing.Point(473, 375);
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
            this.rbBMI.Click += new System.EventHandler(this.radioButtons_SelectedValueChanged);
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
            // nudDaysComboBox
            // 
            this.nudDaysComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nudDaysComboBox.FormattingEnabled = true;
            this.nudDaysComboBox.Location = new System.Drawing.Point(545, 344);
            this.nudDaysComboBox.Name = "nudDaysComboBox";
            this.nudDaysComboBox.Size = new System.Drawing.Size(44, 21);
            this.nudDaysComboBox.TabIndex = 9;
            this.nudDaysComboBox.SelectedValueChanged += new System.EventHandler(this.nudDaysComboBox_SelectedValueChanged);
            // 
            // WellnessReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 440);
            this.Controls.Add(this.nudDaysComboBox);
            this.Controls.Add(this.lbDays);
            this.Controls.Add(this.rbBMI);
            this.Controls.Add(this.BTNPrint);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.rbBP);
            this.Controls.Add(this.rbHeartRate);
            this.Controls.Add(this.rbWeight);
            this.Controls.Add(this.chartUserData);
            this.Name = "WellnessReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.WellnessReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartUserData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartUserData;
        private System.Windows.Forms.RadioButton rbWeight;
        private System.Windows.Forms.RadioButton rbHeartRate;
        private System.Windows.Forms.RadioButton rbBP;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button BTNPrint;
        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.RadioButton rbBMI;
        private System.Windows.Forms.ComboBox nudDaysComboBox;
    }
}