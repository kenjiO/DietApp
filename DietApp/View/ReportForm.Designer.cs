namespace DietApp.View
{
    partial class ReportForm
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartUserData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoad = new System.Windows.Forms.Button();
            this.rbWeight = new System.Windows.Forms.RadioButton();
            this.rbHeartRate = new System.Windows.Forms.RadioButton();
            this.rbSystolicBP = new System.Windows.Forms.RadioButton();
            this.rbDiastolicBP = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartUserData)).BeginInit();
            this.SuspendLayout();
            // 
            // chartUserData
            // 
            chartArea1.Name = "ChartArea1";
            this.chartUserData.ChartAreas.Add(chartArea1);
            this.chartUserData.Location = new System.Drawing.Point(12, 12);
            this.chartUserData.Name = "chartUserData";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "UserData";
            this.chartUserData.Series.Add(series1);
            this.chartUserData.Size = new System.Drawing.Size(399, 300);
            this.chartUserData.TabIndex = 0;
            this.chartUserData.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "User Data";
            this.chartUserData.Titles.Add(title1);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(336, 318);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // rbWeight
            // 
            this.rbWeight.AutoSize = true;
            this.rbWeight.Location = new System.Drawing.Point(13, 318);
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
            this.rbHeartRate.Location = new System.Drawing.Point(79, 318);
            this.rbHeartRate.Name = "rbHeartRate";
            this.rbHeartRate.Size = new System.Drawing.Size(77, 17);
            this.rbHeartRate.TabIndex = 3;
            this.rbHeartRate.TabStop = true;
            this.rbHeartRate.Text = "Heart Rate";
            this.rbHeartRate.UseVisualStyleBackColor = true;
            // 
            // rbSystolicBP
            // 
            this.rbSystolicBP.AutoSize = true;
            this.rbSystolicBP.Location = new System.Drawing.Point(163, 318);
            this.rbSystolicBP.Name = "rbSystolicBP";
            this.rbSystolicBP.Size = new System.Drawing.Size(78, 17);
            this.rbSystolicBP.TabIndex = 4;
            this.rbSystolicBP.TabStop = true;
            this.rbSystolicBP.Text = "Systolic BP";
            this.rbSystolicBP.UseVisualStyleBackColor = true;
            // 
            // rbDiastolicBP
            // 
            this.rbDiastolicBP.AutoSize = true;
            this.rbDiastolicBP.Location = new System.Drawing.Point(248, 318);
            this.rbDiastolicBP.Name = "rbDiastolicBP";
            this.rbDiastolicBP.Size = new System.Drawing.Size(82, 17);
            this.rbDiastolicBP.TabIndex = 5;
            this.rbDiastolicBP.TabStop = true;
            this.rbDiastolicBP.Text = "Diastolic BP";
            this.rbDiastolicBP.UseVisualStyleBackColor = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 349);
            this.Controls.Add(this.rbDiastolicBP);
            this.Controls.Add(this.rbSystolicBP);
            this.Controls.Add(this.rbHeartRate);
            this.Controls.Add(this.rbWeight);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.chartUserData);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartUserData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartUserData;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.RadioButton rbWeight;
        private System.Windows.Forms.RadioButton rbHeartRate;
        private System.Windows.Forms.RadioButton rbSystolicBP;
        private System.Windows.Forms.RadioButton rbDiastolicBP;
    }
}