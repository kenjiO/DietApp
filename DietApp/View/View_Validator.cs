using DietApp.Controller;
using DietApp.Model;
using System;
using System.Windows.Forms;

namespace DietApp.View
{
    /// <summary>
    /// Validator of standard view information
    /// </summary>
    internal class View_Validator
    {
        /// <summary>
        /// Check if the textbox is blank
        /// </summary>
        /// <param name="textBox">Text box to check</param>
        /// <returns>True if blank [Message], else false.</returns>
        internal static bool Blank(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show(textBox.Tag + " blank, please provide information.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks to not match conditions
        /// </summary>
        /// <param name="textBoxA">1 text box to compare</param>
        /// <param name="textBoxB">The other text box to compare</param>
        /// <returns>True if notmatch [Message], else false</returns>
        internal static bool NotMatch(TextBox textBoxA, TextBox textBoxB)
        {
            if (!(textBoxA.Text.Equals(textBoxB.Text)))
            {
                MessageBox.Show(textBoxA.Tag + " does not match " + textBoxB.Tag + " , please provide matching information.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Verifies whether or not a user is null.
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        internal static bool Users(Users users)
        {
            if (users == null)
            {
                MessageBox.Show("User does not exist.", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("No user is currently logged on.", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Verifies whether or not the data fields on the Wellness Forms are filled out.
        /// </summary>
        /// <param name="theWellness"></param>
        /// <returns></returns>
        public static bool ValidateWellness(Wellness theWellness)
        {
            var result = false;
            var missingData = "";

            if (theWellness == null)
            {
                result = false;
            }
            else if (theWellness.weight == 0)
            {
                missingData = "\tWeight\n";
                result = false;
            }
            else if (theWellness.heartRate == 0)
            {
                missingData = "\tHeart Rate\n";
                result = false;
            }
            else if (theWellness.systolicBP == 0)
            {
                missingData = "\tSystolic BP\n";
                result = false;
            }
            else if (theWellness.diastolicBP == 0)
            {
                missingData = "\tDiastolic BP\n";
                result = false;
            }
            else
            {
                result = true;
            }

            if (!result)
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Verifies if data in DB matches wellness entry.
        /// </summary>
        /// <param name="theWellness"></param>
        /// <returns></returns>
        public static bool wellnessMatchDB(Wellness theWellness)
        {
            bool result = false;
            var wellnessFromDB = DietAppController.dateWellnessData(theWellness.userID, theWellness.date.ToString());
            if (String.Compare(theWellness.ToString(), wellnessFromDB.ToString()) == 0)
            {
                result = true;
            }
            return result;
        }
    }
}