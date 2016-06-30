using DietApp.Controller;
using DietApp.Model;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DietApp.View
{
    public partial class WellnessTrackingForm : Form
    {
        private Users theUser;
        private Wellness userWellness;

        public WellnessTrackingForm()
        {
            InitializeComponent();
            dateTimePicker.MaxDate = System.DateTime.Now;
        }

        /// <summary>
        /// Loads the user's information to the Wellness Tracking window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WellnessTrackingForm_Load(object sender, EventArgs e)
        {
            if (this.theUser != null)
            {
                var date = dateTimePicker.Value.ToString();
                this.userWellness = DietAppController.dateWellnessData(this.theUser.userId, date);
                if (this.userWellness.userID != 0 && this.userWellness != null)
                {
                    diastolicUpDown.Value = this.userWellness.diastolicBP;
                    systolicUpDown.Value = this.userWellness.systolicBP;
                    weightUpDown.Value = this.userWellness.weight;
                    heartRateUpDown.Value = this.userWellness.heartRate;
                    dateTimePicker.Value = this.userWellness.date;
                }
                this.setButton();
            }
            else
            {
                MessageBox.Show("User does not exist.");
                MessageBox.Show("No user is currently logged in.");
                return;
            }
        }

        /// <summary>
        /// Loads the user.
        /// </summary>
        /// <param name="newUser"></param>
        public void loadUser(Users newUser)
        {
            this.theUser = newUser;
        }

        /// <summary>
        /// Saves the data to the DB.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void saveInfo_Click(object sender, System.EventArgs e)
        {
            this.userWellness = new Wellness();
            this.userWellness.diastolicBP = Int32.Parse(diastolicUpDown.Value.ToString());
            this.userWellness.systolicBP = Int32.Parse(systolicUpDown.Value.ToString());
            this.userWellness.weight = Int32.Parse(weightUpDown.Value.ToString());
            this.userWellness.heartRate = Int32.Parse(heartRateUpDown.Value.ToString());
            this.userWellness.date = dateTimePicker.Value;
            this.userWellness.userID = this.theUser.userId;
            if (!View_Validator.ValidateWellness(this.userWellness))
            {
                MessageBox.Show("Please enter data for all fields.", "Wellness Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DietAppController.addDailyWellnessData(this.userWellness);
                    this.Refresh();
                    this.setButton();
                    MessageBox.Show("You have successfully recorded data.  You are one step closer to making data-driven decisions about your health.", "Record Updated");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        /// <summary>
        /// Saves the data to the DB.
        /// UPDATE FUNCTIONALITY UNDER DEVELOPMENT FOR ITERATION 2.  BUTTON DISABLED.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void updateInfo_Click(object sender, System.EventArgs e)
        {
            var userWellnessUpdate = new Wellness
            {
                diastolicBP = Int32.Parse(diastolicUpDown.Value.ToString()),
                systolicBP = Int32.Parse(systolicUpDown.Value.ToString()),
                weight = Int32.Parse(weightUpDown.Value.ToString()),
                heartRate = Int32.Parse(heartRateUpDown.Value.ToString()),
                date = dateTimePicker.Value,
                userID = this.theUser.userId
            };

            try
            {
                DietAppController.updateDailyWellnessData(userWellnessUpdate, this.userWellness);
                MessageBox.Show("You have successfully recorded data.  You are one step closer to making data-driven decisions about your health.", "Record Updated");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Closes the form if the user decides to "cancel" what (s)he is doing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// If there is information in the DB for the user and the wellness object with a weight >0, displays update button.
        /// If not, displays the save button.
        /// </summary>
        private void setButton()
        {
            if (View_Validator.ValidateWellness(this.userWellness))
            {
                updateButton.Enabled = true;
                updateButton.Visible = true;
                saveButton.Enabled = false;
                saveButton.Visible = false;
            }
            else
            {
                updateButton.Enabled = false;
                updateButton.Visible = false;
                saveButton.Enabled = true;
                saveButton.Visible = true;
            }
        }
    }
}