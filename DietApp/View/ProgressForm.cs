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
                newBMIBox.Text = theProgress.newBMI.ToString();
                oldWeightBox.Text = theProgress.oldWeight.ToString();
                newWeightBox.Text = theProgress.newWeight.ToString();
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

            if (BMI <= 15)
            {
                msg = "Very severely underweight\n" + this.weightDifference() + "\n" + this.goalWeight();
            }
            else if (BMI > 15 && BMI <= 16)
            {
                msg = "Severely underweight\n" + this.weightDifference() + "\n" + this.goalWeight();
            }
            else if (BMI > 16 && BMI <= 18.5)
            {
                msg = "Underweight\n" + this.weightDifference() + "\n" + this.goalWeight();
            }
            else if (BMI > 18.5 && BMI <= 25)
            {
                msg = "Normal (healthy weight)\n Congratulations! Your BMI is normal, which means you are a healthy weight for your height." + "\n" + this.goalWeight();
            }
            else if (BMI > 25 && BMI <= 30)
            {
                msg = "Overweight\n" + this.weightDifference() + "\n" + this.goalWeight();
            }
            else if (BMI > 30 && BMI <= 35)
            {
                msg = "Obese Class I (Moderately obese)\n" + this.weightDifference() + "\n" + this.goalWeight();
            }
            else if (BMI > 35 && BMI <= 40)
            {
                msg = "Obese Class II (Severely obese)\n" + this.weightDifference() + "\n" + this.goalWeight();
            }
            else if (BMI > 40)
            {
                msg = "Obese Class III (Very severely obese)\n" + this.weightDifference() + "\n" +this.goalWeight();
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
            int ideal;
            var msg = "";
            if (BMI <= 18.5)
            {
                ideal = Convert.ToInt32(Math.Round((18.6 / 703) * Math.Pow(this.theUser.heightInches, 2)));
                msg = "You need to gain " + (ideal - this.theProgress.newWeight) + " lb(s). to reach a healthy BMI.\n" +
                    "This means you should aim for a weight of approximately " + ideal + " lbs.";
            }
            else if (BMI > 25)
            {
                ideal = Convert.ToInt32(Math.Round((25.0 / 703) * Math.Pow(this.theUser.heightInches, 2)));
                msg = "You need to lose " + (ideal - this.theUser.goalWeight) + " lb(s). to reach a healthy BMI.\n" +
                    "This means you should aim for a weight of approximately " + ideal + " lbs.";
            }
            else
            {
                msg = "error";
            }

            return msg;
        }

        /// <summary>
        /// Determines how much weight needs to be lost or gained to reach the user's goal weight and returns it as a string.
        /// </summary>
        /// <returns></returns>
        private String goalWeight()
        {
            var msg = "";
            if (this.theUser.goalWeight < this.theProgress.newWeight)
            {
                msg = "\n Goal Weight: \n You need to lose "+ (this.theProgress.newWeight - this.theUser.goalWeight) +" lb(s) to meet your goal weight.";
            }
            else if (this.theUser.goalWeight > this.theProgress.newWeight)
            {
                msg = "\n Goal Weight: \n You need to gain " + (this.theUser.goalWeight - this.theProgress.newWeight) + " lb(s) to meet your goal weight.";
            }
            else if (this.theUser.goalWeight == this.theProgress.newWeight)
            {
                msg = "\n Goal Weight: \n Congratulations!  You've met your goal weight.";
            }
            else
            {
                msg = "error";
            }


            return msg;
        }
    }
}