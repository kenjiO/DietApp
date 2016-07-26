//-----------------------------------------------------------------------
// <copyright file="View_Validator.cs" company="KKR Summer 2016">
//     Copyright (c) KKR Summer 2016. All rights reserved.
// </copyright>
// <summary>This the validation of view information.</summary>
// <author>Kaleigh Kendrick</author>
// <author>Robert Carswell</author>
// <author>Kenji Okamoto</author>
//-----------------------------------------------------------------------

namespace DietApp.View
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Windows.Forms;
    using DietApp.Controller;
    using DietApp.Model;

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
            bool result = false;
            result = string.IsNullOrWhiteSpace(textBox.Text);
            if (result)
            {
                MessageBox.Show(textBox.Tag + " blank, please provide information.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return result;
        }

        /// <summary>
        /// Checks to not match conditions.
        /// </summary>
        /// <param name="textBoxA">1 text box to compare.</param>
        /// <param name="textBoxB">The other text box to compare.</param>
        /// <returns>True if not a match [Message], else false.</returns>
        internal static bool NotMatch(TextBox textBoxA, TextBox textBoxB)
        {
            if (!textBoxA.Text.Equals(textBoxB.Text))
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
        /// <param name="users">The user to check.</param>
        /// <returns>True if null [Message], else false.</returns>
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
        /// <param name="theWellness">The wellness data to check.</param>
        /// <returns>True if not a match [Message], else false.</returns>
        internal static bool ValidateWellness(Wellness theWellness)
        {
            var result = false;
            var missingData = string.Empty;

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
        /// <param name="theWellness">The wellness data to check.</param>
        /// <returns>True if a match [Message], else false.</returns>
        internal static bool wellnessMatchDB(Wellness theWellness)
        {
            bool result = false;
            var wellnessFromDB = DietAppController.dateWellnessData(theWellness.userID, theWellness.date.ToString());
            if (String.Compare(theWellness.ToString(), wellnessFromDB.ToString()) == 0)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// Compares the user for changes.
        /// </summary>
        /// <param name="userProfileUpdate">User profile to check.</param>
        /// <returns>True if a match [Message], else false.</returns>
        internal static bool UserMatch(Users userProfileUpdate)
        {
            bool result = false;
            var userDB = DietAppController.getUserData(userProfileUpdate.userId);
            if (string.Compare(userProfileUpdate.ToString(), userDB.ToString()) == 0)
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Checks for a valid email address.
        /// </summary>
        /// <param name="email">Email address to validate.</param>
        /// <returns>True if valid, else false.</returns>
        internal static bool Email(string email)
        {
            bool result = false;
            result = new EmailAddressAttribute().IsValid(email);
            if (!result)
            {
                MessageBox.Show(email + " is not valid. Valid address follows XXX@XXX.XX form.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return result;
        }

        /// <summary>
        /// Checks for valid name.
        /// </summary>
        /// <param name="nameBox">Name box to validate.</param>
        /// <returns>True if valid, else false.</returns>
        internal static bool Name(TextBox nameBox)
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text))
            {
                MessageBox.Show(nameBox.Tag + " contains a blank name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nameBox.Text.Length < 2)
            {
                MessageBox.Show(nameBox.Tag + " contains a name less than 2 characters.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (char c in nameBox.Text)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show(nameBox.Tag + " contains a numeric character.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }
    }
}