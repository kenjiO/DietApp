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
        /// Determines if the system should save or update information based on date existing in DB or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void WellnessInfo_Click(object sender, System.EventArgs e)
        {
            if (View_Validator.ValidateWellness(this.userWellness))
            {
                //Update Wellness Info
                this.updateInfo_Click();
            }
            else
            {
                //Save Wellness Info
                this.saveInfo_Click();
            }
        }

        /// <summary>
        /// Checks to see if wellness data matches data in DB.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CheckDBForWellness(object sender, System.EventArgs e)
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
            if (!View_Validator.wellnessMatchDB(userWellnessUpdate))
            {
                //Update Wellness Info
                this.updateConfirm();
            }
        }

        // Helper Methods //

        /// <summary>
        /// Prompts user if they try to navigate to a different tab with unsaved changes.
        /// </summary>
        private void updateConfirm()
        {
            var dialogResult = MessageBox.Show("You have not saved changes for this entry. " +
                "Do you wish to update your data?", "Update Entry",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.updateInfo_Click();
            }
        }

        /// <summary>
        /// Saves the data to the DB.
        /// </summary>
        private void saveInfo_Click()
        {
            this.userWellness = new Wellness
            {
                diastolicBP = Int32.Parse(diastolicUpDown.Value.ToString()),
                systolicBP = Int32.Parse(systolicUpDown.Value.ToString()),
                weight = Int32.Parse(weightUpDown.Value.ToString()),
                heartRate = Int32.Parse(heartRateUpDown.Value.ToString()),
                date = dateTimePicker.Value,
                userID = this.theUser.userId
            };
            if (!View_Validator.ValidateWellness(this.userWellness) || this.userWellness.weight == 0) { 
                MessageBox.Show("Please enter valid data for all fields.",
                    "Wellness Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    DietAppController.addDailyWellnessData(this.userWellness);
                    Cursor.Current = Cursors.Default;
                    this.Refresh();
                    MessageBox.Show("You have successfully recorded data.  " +
                        "You are one step closer to making data-driven decisions about your health.",
                        "Record Updated");
                }
                catch (SqlException ex)
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                catch (Exception ex)
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        /// <summary>
        /// Saves updated data to the DB.
        /// </summary>
        private void updateInfo_Click()
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

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                DietAppController.updateDailyWellnessData(userWellnessUpdate, this.userWellness);
                this.userWellness = userWellnessUpdate;
                this.Refresh();
                MessageBox.Show("You have successfully recorded data.  You are one step closer to making data-driven decisions about your health.", "Record Updated");
            }
            catch (SqlException ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            Cursor.Current = Cursors.Default;
        }
    }
}