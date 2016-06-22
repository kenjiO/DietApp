using DietApp.Controller;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DietApp.Model
{
    public class Model_Validator
    {
        /// <summary>
        /// Compares the password against the stored value of the password for the specified userName in the database.
        /// </summary>
        /// <param name="userName">The user name.</param>
        /// <param name="password">The password.</param>
        /// <returns>A boolean value indicating if the data matches.</returns>
        public static bool comparePassword(String userName, String password)
        {
            var pass = "";

            using (var userPasswordDataTable = new DietAppDataSet())
            {
                using (var userPasswordDataSet = new DietAppDataSetTableAdapters.userPasswordTableAdapter())
                {
                    userPasswordDataSet.FillData(userPasswordDataTable.userPassword, userName);

                    foreach (DataRow row in userPasswordDataSet.GetData(userName).Rows)
                    {
                        pass = row[0].ToString();
                    }
                    return VerifySHA1Hash(password, pass);
                }
            }
        }

        /// <summary>
        /// Verifies the user name.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static bool verifyUserName(String userName)
        {
            Users testUser;
            var value = false;
            try
            {
                testUser = DietAppController.getUserData(userName);
                if (testUser.username == null)
                {
                    value = false;
                }
                else if (testUser.username.Equals(userName, StringComparison.InvariantCultureIgnoreCase))
                {
                    value = true;
                }
                else
                {
                    value = false;
                }
            }
            catch (SqlException ex)
            {
                value = false;
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                value = false;
                Console.WriteLine(ex);
            }
            return value;
        }

        /// <summary>
        /// Verifies the hash of input against a given hash.
        /// </summary>
        /// <param name="input">The input password.</param>
        /// <param name="hash">The hash algorithm.</param>
        /// <returns>A boolean value.  True if match, else false.</returns>
        private static bool VerifySHA1Hash(String input, String hash)
        {
            var PasswordHash = new Encryption();
            var comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(PasswordHash.GetSHA1Hash(input), hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}