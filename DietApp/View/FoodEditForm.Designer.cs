namespace DietApp.View
{
    partial class FoodEditForm
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
            this.foodBox = new System.Windows.Forms.TextBox();
            this.caloriesBox = new System.Windows.Forms.TextBox();
            this.fatBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.proteinBox = new System.Windows.Forms.TextBox();
            this.carbohydratesBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // foodBox
            // 
            this.foodBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodBox.Location = new System.Drawing.Point(260, 158);
            this.foodBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.foodBox.Name = "foodBox";
            this.foodBox.Size = new System.Drawing.Size(379, 33);
            this.foodBox.TabIndex = 6;
            this.foodBox.TextChanged += new System.EventHandler(this.enableDisableUpdateButton);
            // 
            // caloriesBox
            // 
            this.caloriesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesBox.Location = new System.Drawing.Point(260, 208);
            this.caloriesBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.caloriesBox.Name = "caloriesBox";
            this.caloriesBox.Size = new System.Drawing.Size(379, 33);
            this.caloriesBox.TabIndex = 8;
            this.caloriesBox.TextChanged += new System.EventHandler(this.enableDisableUpdateButton);
            // 
            // fatBox
            // 
            this.fatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatBox.Location = new System.Drawing.Point(260, 257);
            this.fatBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fatBox.Name = "fatBox";
            this.fatBox.Size = new System.Drawing.Size(379, 33);
            this.fatBox.TabIndex = 10;
            this.fatBox.TextChanged += new System.EventHandler(this.enableDisableUpdateButton);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(34, 162);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(210, 31);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Food";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Calories";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fat (g)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Protein (g)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Carbohydrates (g)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // proteinBox
            // 
            this.proteinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteinBox.Location = new System.Drawing.Point(260, 303);
            this.proteinBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.proteinBox.Name = "proteinBox";
            this.proteinBox.Size = new System.Drawing.Size(379, 33);
            this.proteinBox.TabIndex = 12;
            this.proteinBox.TextChanged += new System.EventHandler(this.enableDisableUpdateButton);
            // 
            // carbohydratesBox
            // 
            this.carbohydratesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbohydratesBox.Location = new System.Drawing.Point(260, 352);
            this.carbohydratesBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carbohydratesBox.Name = "carbohydratesBox";
            this.carbohydratesBox.Size = new System.Drawing.Size(379, 33);
            this.carbohydratesBox.TabIndex = 14;
            this.carbohydratesBox.TextChanged += new System.EventHandler(this.enableDisableUpdateButton);
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(380, 425);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(112, 35);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(260, 55);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(379, 33);
            this.datePicker.TabIndex = 2;
            this.datePicker.ValueChanged += new System.EventHandler(this.enableDisableUpdateButton);
            // 
            // timePicker
            // 
            this.timePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Location = new System.Drawing.Point(260, 108);
            this.timePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(379, 33);
            this.timePicker.TabIndex = 4;
            this.timePicker.ValueChanged += new System.EventHandler(this.enableDisableUpdateButton);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 31);
            this.label7.TabIndex = 3;
            this.label7.Text = "Time";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(528, 425);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 35);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // FoodEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 557);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.carbohydratesBox);
            this.Controls.Add(this.proteinBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.fatBox);
            this.Controls.Add(this.caloriesBox);
            this.Controls.Add(this.foodBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FoodEditForm";
            this.Text = "Edit Food Entry";
            this.Load += new System.EventHandler(this.FoodEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox foodBox;
        private System.Windows.Forms.TextBox caloriesBox;
        private System.Windows.Forms.TextBox fatBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox proteinBox;
        private System.Windows.Forms.TextBox carbohydratesBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancelButton;
    }
}