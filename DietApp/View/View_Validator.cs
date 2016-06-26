using DietApp.Model;
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
    }
}