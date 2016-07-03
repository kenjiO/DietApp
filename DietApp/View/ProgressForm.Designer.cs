namespace DietApp.View
{
    partial class ProgressForm
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
            this.oldBMILabel = new System.Windows.Forms.Label();
            this.oldBMIBox = new System.Windows.Forms.TextBox();
            this.newBMIBox = new System.Windows.Forms.TextBox();
            this.newBMILabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oldBMILabel
            // 
            this.oldBMILabel.AutoSize = true;
            this.oldBMILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldBMILabel.Location = new System.Drawing.Point(12, 9);
            this.oldBMILabel.Name = "oldBMILabel";
            this.oldBMILabel.Size = new System.Drawing.Size(152, 29);
            this.oldBMILabel.TabIndex = 0;
            this.oldBMILabel.Text = "Original BMI:";
            // 
            // oldBMIBox
            // 
            this.oldBMIBox.Enabled = false;
            this.oldBMIBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldBMIBox.Location = new System.Drawing.Point(170, 9);
            this.oldBMIBox.Name = "oldBMIBox";
            this.oldBMIBox.Size = new System.Drawing.Size(100, 35);
            this.oldBMIBox.TabIndex = 2;
            // 
            // newBMIBox
            // 
            this.newBMIBox.Enabled = false;
            this.newBMIBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBMIBox.Location = new System.Drawing.Point(459, 9);
            this.newBMIBox.Name = "newBMIBox";
            this.newBMIBox.Size = new System.Drawing.Size(100, 35);
            this.newBMIBox.TabIndex = 4;
            // 
            // newBMILabel
            // 
            this.newBMILabel.AutoSize = true;
            this.newBMILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBMILabel.Location = new System.Drawing.Point(301, 9);
            this.newBMILabel.Name = "newBMILabel";
            this.newBMILabel.Size = new System.Drawing.Size(146, 29);
            this.newBMILabel.TabIndex = 3;
            this.newBMILabel.Text = "Current BMI:";
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 59);
            this.Controls.Add(this.newBMIBox);
            this.Controls.Add(this.newBMILabel);
            this.Controls.Add(this.oldBMIBox);
            this.Controls.Add(this.oldBMILabel);
            this.Name = "ProgressForm";
            this.Text = "My Progress";
            this.Load += new System.EventHandler(this.ProgressForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oldBMILabel;
        private System.Windows.Forms.TextBox oldBMIBox;
        private System.Windows.Forms.TextBox newBMIBox;
        private System.Windows.Forms.Label newBMILabel;
    }
}