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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ConsumedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Food = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protein = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carbohydrates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditEntry = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteEntry = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.prevDayButton = new System.Windows.Forms.Button();
            this.nextDayButton = new System.Windows.Forms.Button();
            this.calorieGoalLabel = new System.Windows.Forms.Label();
            this.totalCaloriesLabel = new System.Windows.Forms.Label();
            this.caloriesUntilGoalLabel = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle57.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle57.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle57;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConsumedAt,
            this.Food,
            this.Calories,
            this.Protein,
            this.Fat,
            this.Carbohydrates,
            this.EditEntry,
            this.DeleteEntry});
            this.dataGridView1.Location = new System.Drawing.Point(2, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(610, 275);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ConsumedAt
            // 
            this.ConsumedAt.DataPropertyName = "ConsumedAt";
            dataGridViewCellStyle58.Format = "t";
            dataGridViewCellStyle58.NullValue = null;
            this.ConsumedAt.DefaultCellStyle = dataGridViewCellStyle58;
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
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Calories.DefaultCellStyle = dataGridViewCellStyle59;
            this.Calories.HeaderText = "Calories";
            this.Calories.Name = "Calories";
            this.Calories.ReadOnly = true;
            this.Calories.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Calories.Width = 90;
            // 
            // Protein
            // 
            this.Protein.DataPropertyName = "Protein";
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Protein.DefaultCellStyle = dataGridViewCellStyle60;
            this.Protein.HeaderText = "Protein";
            this.Protein.Name = "Protein";
            this.Protein.ReadOnly = true;
            this.Protein.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Protein.Width = 90;
            // 
            // Fat
            // 
            this.Fat.DataPropertyName = "Fat";
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Fat.DefaultCellStyle = dataGridViewCellStyle61;
            this.Fat.HeaderText = "Fat";
            this.Fat.Name = "Fat";
            this.Fat.ReadOnly = true;
            this.Fat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fat.Width = 90;
            // 
            // Carbohydrates
            // 
            this.Carbohydrates.DataPropertyName = "Carbohydrates";
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Carbohydrates.DefaultCellStyle = dataGridViewCellStyle62;
            this.Carbohydrates.HeaderText = "Carbs";
            this.Carbohydrates.Name = "Carbohydrates";
            this.Carbohydrates.ReadOnly = true;
            this.Carbohydrates.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Carbohydrates.Width = 90;
            // 
            // EditEntry
            // 
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle63.Padding = new System.Windows.Forms.Padding(2);
            this.EditEntry.DefaultCellStyle = dataGridViewCellStyle63;
            this.EditEntry.HeaderText = "";
            this.EditEntry.Name = "EditEntry";
            this.EditEntry.ReadOnly = true;
            this.EditEntry.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EditEntry.Text = "Edit";
            this.EditEntry.UseColumnTextForButtonValue = true;
            this.EditEntry.Width = 60;
            // 
            // DeleteEntry
            // 
            dataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle64.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle64.Padding = new System.Windows.Forms.Padding(2);
            this.DeleteEntry.DefaultCellStyle = dataGridViewCellStyle64;
            this.DeleteEntry.HeaderText = "";
            this.DeleteEntry.Name = "DeleteEntry";
            this.DeleteEntry.ReadOnly = true;
            this.DeleteEntry.Text = "Delete";
            this.DeleteEntry.UseColumnTextForButtonValue = true;
            this.DeleteEntry.Width = 60;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(197, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.CloseUp += new System.EventHandler(this.dateTimePicker1_DateSelected);
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
            this.prevDayButton.Click += new System.EventHandler(this.prevDayButton_Click);
            // 
            // nextDayButton
            // 
            this.nextDayButton.Location = new System.Drawing.Point(439, 46);
            this.nextDayButton.Name = "nextDayButton";
            this.nextDayButton.Size = new System.Drawing.Size(75, 23);
            this.nextDayButton.TabIndex = 4;
            this.nextDayButton.Text = "Next Day";
            this.nextDayButton.UseVisualStyleBackColor = true;
            this.nextDayButton.Click += new System.EventHandler(this.nextDayButton_Click);
            // 
            // calorieGoalLabel
            // 
            this.calorieGoalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calorieGoalLabel.Location = new System.Drawing.Point(53, 369);
            this.calorieGoalLabel.Name = "calorieGoalLabel";
            this.calorieGoalLabel.Size = new System.Drawing.Size(198, 23);
            this.calorieGoalLabel.TabIndex = 5;
            // 
            // totalCaloriesLabel
            // 
            this.totalCaloriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCaloriesLabel.Location = new System.Drawing.Point(266, 369);
            this.totalCaloriesLabel.Name = "totalCaloriesLabel";
            this.totalCaloriesLabel.Size = new System.Drawing.Size(201, 23);
            this.totalCaloriesLabel.TabIndex = 6;
            // 
            // caloriesUntilGoalLabel
            // 
            this.caloriesUntilGoalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesUntilGoalLabel.Location = new System.Drawing.Point(404, 369);
            this.caloriesUntilGoalLabel.Name = "caloriesUntilGoalLabel";
            this.caloriesUntilGoalLabel.Size = new System.Drawing.Size(152, 23);
            this.caloriesUntilGoalLabel.TabIndex = 7;
            this.caloriesUntilGoalLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ListFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 416);
            this.Controls.Add(this.caloriesUntilGoalLabel);
            this.Controls.Add(this.totalCaloriesLabel);
            this.Controls.Add(this.calorieGoalLabel);
            this.Controls.Add(this.nextDayButton);
            this.Controls.Add(this.prevDayButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListFoodForm";
            this.Text = "ListFoodForm";
            this.Load += new System.EventHandler(this.ListFoodForm_Load);
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
        private System.Windows.Forms.DataGridViewButtonColumn EditEntry;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteEntry;
        private System.Windows.Forms.Label calorieGoalLabel;
        private System.Windows.Forms.Label totalCaloriesLabel;
        private System.Windows.Forms.Label caloriesUntilGoalLabel;
    }
}
