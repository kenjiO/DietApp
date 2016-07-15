using DietApp.Controller;
using DietApp.Model;
using System;
using System.Windows.Forms;

namespace DietApp.View
{
    public partial class ProgressForm : Form
    {
        private Users theUser;
        private Progress theProgress;

        public ProgressForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the user's information to the Progress window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ProgressForm_Load(object sender, EventArgs e)
        {
            if (this.theUser != null)
            {
                theProgress = DietAppController.getBMIData(theUser.userId);
                oldBMIBox.Text = theProgress.oldBMI.ToString();
                oldWeightBox.Text = theProgress.oldWeight.ToString();
                if(theProgress.newBMI > 0)
                {
                    newBMIBox.Text = theProgress.newBMI.ToString();
                    newWeightBox.Text = theProgress.newWeight.ToString();
                } else
                {
                    newBMIBox.Text = "n/a";
                    newWeightBox.Text = "n/a";
                }
                
                msgLabel.Text = this.currentBMIStatus();
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

        //Helper Methods//

        /// <summary>
        /// Returns a string value explaining the user's current BMI and progress recommended.
        /// </summary>
        /// <returns></returns>
        private string currentBMIStatus()
        {
            var BMI = this.theProgress.newBMI;
            var msg = "";

            if(BMI == 0)
            {
                msg = "Please enter wellness data to calculate your current BMI.";
            }
            else if (BMI >0 && BMI <= 15)
            {
                msg = "Very severely underweight\n" + this.weightDifference();
            }
            else if (BMI > 15 && BMI <= 16)
            {
                msg = "Severely underweight\n" + this.weightDifference();
            }
            else if (BMI > 16 && BMI <= 18.5)
            {
                msg = "Underweight\n" + this.weightDifference();
            }
            else if (BMI > 18.5 && BMI <= 25)
            {
                msg = "Normal (healthy weight)\n Congratulations! Your BMI is normal, which means you are a healthy weight for your height.";
            }
            else if (BMI > 25 && BMI <= 30)
            {
                msg = "Overweight\n" + this.weightDifference();
            }
            else if (BMI > 30 && BMI <= 35)
            {
                msg = "Obese Class I (Moderately obese)\n" + this.weightDifference();
            }
            else if (BMI > 35 && BMI <= 40)
            {
                msg = "Obese Class II (Severely obese)\n" + this.weightDifference();
            }
            else if (BMI > 40)
            {
                msg = "Obese Class III (Very severely obese)\n" + this.weightDifference();
            }
            else
            {
                msg = "error";
            }

            return msg;
        }

        /// <summary>
        /// Determines how much weight needs to be lost or gained to reach the user's ideal BMI and returns it as a string.
        /// </summary>
        /// <returns></returns>
        private String weightDifference()
        {
            var BMI = this.theProgress.newBMI;
            var msg = "";
            if (BMI <= 18.5)
            {
                this.theUser.goalWeight = Convert.ToInt32(Math.Round((18.6 / 703) * Math.Pow(this.theUser.heightInches, 2)));
                msg = "You need to gain " + (this.theUser.goalWeight - this.theProgress.newWeight) + " lb(s). to reach a healthy BMI.\n" +
                    "This means you should aim for a weight of approximately " + this.theUser.goalWeight + " lbs.";
            }
            else if (BMI > 25)
            {
                this.theUser.goalWeight = Convert.ToInt32(Math.Round((25.0 / 703) * Math.Pow(this.theUser.heightInches, 2)));
                msg = "You need to lose " + (this.theProgress.newWeight - this.theUser.goalWeight) + " lb(s). to reach a healthy BMI.\n" +
                    "This means you should aim for a weight of approximately " + this.theUser.goalWeight + " lbs.";
            }
            else
            {
                msg = "error";
            }

            return msg;
        }
    }
}