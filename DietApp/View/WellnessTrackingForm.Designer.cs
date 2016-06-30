namespace DietApp.View
{
    partial class WellnessTrackingForm
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
            this.poundsLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.heartRateLabel = new System.Windows.Forms.Label();
            this.bloodPressureLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bpLabel = new System.Windows.Forms.Label();
            this.systolicUpDown = new System.Windows.Forms.NumericUpDown();
            this.diastolicUpDown = new System.Windows.Forms.NumericUpDown();
            this.slantLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.heartRateUpDown = new System.Windows.Forms.NumericUpDown();
            this.weightUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.systolicUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diastolicUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartRateUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // poundsLabel
            // 
            this.poundsLabel.AutoSize = true;
            this.poundsLabel.Location = new System.Drawing.Point(83, 81);
            this.poundsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.poundsLabel.Name = "poundsLabel";
            this.poundsLabel.Size = new System.Drawing.Size(40, 13);
            this.poundsLabel.TabIndex = 71;
            this.poundsLabel.Text = "(in lbs.)";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(44, 81);
            this.weightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(59, 20);
            this.weightLabel.TabIndex = 70;
            this.weightLabel.Text = "Weight";
            // 
            // heartRateLabel
            // 
            this.heartRateLabel.AutoSize = true;
            this.heartRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heartRateLabel.Location = new System.Drawing.Point(44, 142);
            this.heartRateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heartRateLabel.Name = "heartRateLabel";
            this.heartRateLabel.Size = new System.Drawing.Size(88, 20);
            this.heartRateLabel.TabIndex = 73;
            this.heartRateLabel.Text = "Heart Rate";
            // 
            // bloodPressureLabel
            // 
            this.bloodPressureLabel.AutoSize = true;
            this.bloodPressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodPressureLabel.Location = new System.Drawing.Point(164, 82);
            this.bloodPressureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bloodPressureLabel.Name = "bloodPressureLabel";
            this.bloodPressureLabel.Size = new System.Drawing.Size(117, 20);
            this.bloodPressureLabel.TabIndex = 75;
            this.bloodPressureLabel.Text = "Blood Pressure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "(resting)";
            // 
            // bpLabel
            // 
            this.bpLabel.AutoSize = true;
            this.bpLabel.Location = new System.Drawing.Point(245, 82);
            this.bpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bpLabel.Name = "bpLabel";
            this.bpLabel.Size = new System.Drawing.Size(94, 13);
            this.bpLabel.TabIndex = 77;
            this.bpLabel.Text = "(Systolic/Diastolic)";
            // 
            // systolicUpDown
            // 
            this.systolicUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systolicUpDown.Location = new System.Drawing.Point(167, 105);
            this.systolicUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.systolicUpDown.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.systolicUpDown.Name = "systolicUpDown";
            this.systolicUpDown.Size = new System.Drawing.Size(80, 26);
            this.systolicUpDown.TabIndex = 78;
            // 
            // diastolicUpDown
            // 
            this.diastolicUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diastolicUpDown.Location = new System.Drawing.Point(273, 105);
            this.diastolicUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.diastolicUpDown.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.diastolicUpDown.Name = "diastolicUpDown";
            this.diastolicUpDown.Size = new System.Drawing.Size(80, 26);
            this.diastolicUpDown.TabIndex = 79;
            // 
            // slantLabel
            // 
            this.slantLabel.AutoSize = true;
            this.slantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slantLabel.Location = new System.Drawing.Point(251, 102);
            this.slantLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.slantLabel.Name = "slantLabel";
            this.slantLabel.Size = new System.Drawing.Size(20, 29);
            this.slantLabel.TabIndex = 80;
            this.slantLabel.Text = "/";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(44, 42);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(311, 26);
            this.dateTimePicker.TabIndex = 81;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.WellnessTrackingForm_Load);
            // 
            // heartRateUpDown
            // 
            this.heartRateUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heartRateUpDown.Location = new System.Drawing.Point(47, 163);
            this.heartRateUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.heartRateUpDown.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.heartRateUpDown.Name = "heartRateUpDown";
            this.heartRateUpDown.Size = new System.Drawing.Size(80, 26);
            this.heartRateUpDown.TabIndex = 82;
            // 
            // weightUpDown
            // 
            this.weightUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightUpDown.Location = new System.Drawing.Point(47, 105);
            this.weightUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.weightUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.weightUpDown.Name = "weightUpDown";
            this.weightUpDown.Size = new System.Drawing.Size(80, 26);
            this.weightUpDown.TabIndex = 83;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(275, 154);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 31);
            this.saveButton.TabIndex = 84;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveInfo_Click);
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(275, 154);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(80, 31);
            this.updateButton.TabIndex = 86;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateInfo_Click);
            // 
            // WellnessTrackingForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 261);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.weightUpDown);
            this.Controls.Add(this.heartRateUpDown);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.slantLabel);
            this.Controls.Add(this.diastolicUpDown);
            this.Controls.Add(this.systolicUpDown);
            this.Controls.Add(this.bpLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bloodPressureLabel);
            this.Controls.Add(this.heartRateLabel);
            this.Controls.Add(this.poundsLabel);
            this.Controls.Add(this.weightLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WellnessTrackingForm";
            this.Text = "Wellness Tracking";
            this.Load += new System.EventHandler(this.WellnessTrackingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.systolicUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diastolicUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartRateUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label poundsLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label heartRateLabel;
        private System.Windows.Forms.Label bloodPressureLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bpLabel;
        private System.Windows.Forms.NumericUpDown systolicUpDown;
        private System.Windows.Forms.NumericUpDown diastolicUpDown;
        private System.Windows.Forms.Label slantLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.NumericUpDown heartRateUpDown;
        private System.Windows.Forms.NumericUpDown weightUpDown;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button updateButton;
    }
}