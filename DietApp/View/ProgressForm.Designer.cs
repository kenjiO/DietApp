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
            this.oldWeightLabel = new System.Windows.Forms.Label();
            this.newWeightLabel = new System.Windows.Forms.Label();
            this.newWeightBox = new System.Windows.Forms.TextBox();
            this.oldWeightBox = new System.Windows.Forms.TextBox();
            this.msgLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oldBMILabel
            // 
            this.oldBMILabel.AutoSize = true;
            this.oldBMILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldBMILabel.Location = new System.Drawing.Point(47, 26);
            this.oldBMILabel.Name = "oldBMILabel";
            this.oldBMILabel.Size = new System.Drawing.Size(152, 29);
            this.oldBMILabel.TabIndex = 0;
            this.oldBMILabel.Text = "Original BMI:";
            // 
            // oldBMIBox
            // 
            this.oldBMIBox.Enabled = false;
            this.oldBMIBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldBMIBox.Location = new System.Drawing.Point(210, 23);
            this.oldBMIBox.Name = "oldBMIBox";
            this.oldBMIBox.Size = new System.Drawing.Size(100, 35);
            this.oldBMIBox.TabIndex = 2;
            // 
            // newBMIBox
            // 
            this.newBMIBox.Enabled = false;
            this.newBMIBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBMIBox.Location = new System.Drawing.Point(210, 131);
            this.newBMIBox.Name = "newBMIBox";
            this.newBMIBox.Size = new System.Drawing.Size(100, 35);
            this.newBMIBox.TabIndex = 4;
            // 
            // newBMILabel
            // 
            this.newBMILabel.AutoSize = true;
            this.newBMILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBMILabel.Location = new System.Drawing.Point(47, 134);
            this.newBMILabel.Name = "newBMILabel";
            this.newBMILabel.Size = new System.Drawing.Size(146, 29);
            this.newBMILabel.TabIndex = 3;
            this.newBMILabel.Text = "Current BMI:";
            // 
            // oldWeightLabel
            // 
            this.oldWeightLabel.AutoSize = true;
            this.oldWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldWeightLabel.Location = new System.Drawing.Point(14, 77);
            this.oldWeightLabel.Name = "oldWeightLabel";
            this.oldWeightLabel.Size = new System.Drawing.Size(185, 29);
            this.oldWeightLabel.TabIndex = 5;
            this.oldWeightLabel.Text = "Original Weight:";
            // 
            // newWeightLabel
            // 
            this.newWeightLabel.AutoSize = true;
            this.newWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newWeightLabel.Location = new System.Drawing.Point(14, 185);
            this.newWeightLabel.Name = "newWeightLabel";
            this.newWeightLabel.Size = new System.Drawing.Size(179, 29);
            this.newWeightLabel.TabIndex = 6;
            this.newWeightLabel.Text = "Current Weight:";
            // 
            // newWeightBox
            // 
            this.newWeightBox.Enabled = false;
            this.newWeightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newWeightBox.Location = new System.Drawing.Point(210, 182);
            this.newWeightBox.Name = "newWeightBox";
            this.newWeightBox.Size = new System.Drawing.Size(100, 35);
            this.newWeightBox.TabIndex = 7;
            // 
            // oldWeightBox
            // 
            this.oldWeightBox.Enabled = false;
            this.oldWeightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldWeightBox.Location = new System.Drawing.Point(210, 74);
            this.oldWeightBox.Name = "oldWeightBox";
            this.oldWeightBox.Size = new System.Drawing.Size(100, 35);
            this.oldWeightBox.TabIndex = 8;
            // 
            // msgLabel
            // 
            this.msgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msgLabel.AutoSize = true;
            this.msgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLabel.Location = new System.Drawing.Point(417, 63);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(0, 29);
            this.msgLabel.TabIndex = 9;
            this.msgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 339);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.oldWeightBox);
            this.Controls.Add(this.newWeightBox);
            this.Controls.Add(this.newWeightLabel);
            this.Controls.Add(this.oldWeightLabel);
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
        private System.Windows.Forms.Label oldWeightLabel;
        private System.Windows.Forms.Label newWeightLabel;
        private System.Windows.Forms.TextBox newWeightBox;
        private System.Windows.Forms.TextBox oldWeightBox;
        private System.Windows.Forms.Label msgLabel;
    }
}