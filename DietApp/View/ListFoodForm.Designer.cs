namespace DietApp.View
{
    partial class ListFoodForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.prevDayButton = new System.Windows.Forms.Button();
            this.nextDayButton = new System.Windows.Forms.Button();
            this.ConsumedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Food = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protein = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carbohydrates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConsumedAt,
            this.Food,
            this.Calories,
            this.Protein,
            this.Fat,
            this.Carbohydrates});
            this.dataGridView1.Location = new System.Drawing.Point(45, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Size = new System.Drawing.Size(520, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(197, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a Date to View Food Entries";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prevDayButton
            // 
            this.prevDayButton.Location = new System.Drawing.Point(86, 46);
            this.prevDayButton.Name = "prevDayButton";
            this.prevDayButton.Size = new System.Drawing.Size(75, 23);
            this.prevDayButton.TabIndex = 3;
            this.prevDayButton.Text = "Prev Day";
            this.prevDayButton.UseVisualStyleBackColor = true;
            // 
            // nextDayButton
            // 
            this.nextDayButton.Location = new System.Drawing.Point(439, 46);
            this.nextDayButton.Name = "nextDayButton";
            this.nextDayButton.Size = new System.Drawing.Size(75, 23);
            this.nextDayButton.TabIndex = 4;
            this.nextDayButton.Text = "Next Day";
            this.nextDayButton.UseVisualStyleBackColor = true;
            // 
            // ConsumedAt
            // 
            this.ConsumedAt.DataPropertyName = "ConsumedAt";
            dataGridViewCellStyle20.Format = "t";
            dataGridViewCellStyle20.NullValue = null;
            this.ConsumedAt.DefaultCellStyle = dataGridViewCellStyle20;
            this.ConsumedAt.HeaderText = "Time";
            this.ConsumedAt.Name = "ConsumedAt";
            this.ConsumedAt.ReadOnly = true;
            this.ConsumedAt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ConsumedAt.Width = 75;
            // 
            // Food
            // 
            this.Food.DataPropertyName = "Name";
            this.Food.HeaderText = "Food";
            this.Food.Name = "Food";
            this.Food.ReadOnly = true;
            this.Food.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Food.Width = 340;
            // 
            // Calories
            // 
            this.Calories.DataPropertyName = "Calories";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Calories.DefaultCellStyle = dataGridViewCellStyle21;
            this.Calories.HeaderText = "Calories";
            this.Calories.Name = "Calories";
            this.Calories.ReadOnly = true;
            this.Calories.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Calories.Width = 90;
            // 
            // Protein
            // 
            this.Protein.DataPropertyName = "Protein";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Protein.DefaultCellStyle = dataGridViewCellStyle22;
            this.Protein.HeaderText = "Protein";
            this.Protein.Name = "Protein";
            this.Protein.ReadOnly = true;
            this.Protein.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Protein.Width = 90;
            // 
            // Fat
            // 
            this.Fat.DataPropertyName = "Fat";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Fat.DefaultCellStyle = dataGridViewCellStyle23;
            this.Fat.HeaderText = "Fat";
            this.Fat.Name = "Fat";
            this.Fat.ReadOnly = true;
            this.Fat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fat.Width = 90;
            // 
            // Carbohydrates
            // 
            this.Carbohydrates.DataPropertyName = "Carbohydrates";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Carbohydrates.DefaultCellStyle = dataGridViewCellStyle24;
            this.Carbohydrates.HeaderText = "Carbs";
            this.Carbohydrates.Name = "Carbohydrates";
            this.Carbohydrates.ReadOnly = true;
            this.Carbohydrates.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Carbohydrates.Width = 90;
            // 
            // ListFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 414);
            this.Controls.Add(this.nextDayButton);
            this.Controls.Add(this.prevDayButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListFoodForm";
            this.Text = "ListFoodForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prevDayButton;
        private System.Windows.Forms.Button nextDayButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsumedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Food;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protein;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carbohydrates;
    }
}
