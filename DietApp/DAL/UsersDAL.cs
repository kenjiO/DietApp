using DietApp.Model;
using System;
using System.Data;

namespace DietApp.DAL
{
    public class UsersDAL
    {
        /// <summary>
        /// Retrieves the user data from the system for the specified user.
        /// </summary>
        /// <param name="userName">The user name.</param>
        /// <returns>The user object containing the specified data.</returns>
        public static Users getUserData(String userName)
        {
            short number;
            var idNumber = "";
            int value;
            var newUser = new Users();
            using (var userDataTable = new DietAppDataSet())
            {
                using (var userIDDataSet = new DietAppDataSetTableAdapters.usersIdTableAdapter())
                {
                    using (var userDataSet = new DietAppDataSetTableAdapters.usersTableAdapter())
                    {
                        userIDDataSet.FillData(userDataTable.usersId, userName);

                        foreach (DataRow row in userIDDataSet.GetData(userName).Rows)
                        {
                            idNumber = row["userId"].ToString();
                        }
                        bool result = Int16.TryParse(idNumber, out number);
                        if (result)
                        {
                            userDataSet.FillData(userDataTable.users, number);

                            foreach (DataRow row in userDataSet.GetData(number).Rows)
                            {
                                newUser.userId = number;
                                newUser.userName = row["userName"].ToString();
                                newUser.firstName = row["firstName"].ToString();
                                newUser.lastName = row["lastName"].ToString();
                                Int32.TryParse(row["initialWeight"].ToString(), out value);
                                newUser.initialWeight = value;
                                Int32.TryParse(row["heightInches"].ToString(), out value);
                                newUser.heightInches = value;
                                Int32.TryParse(row["dailyCalorieGoal"].ToString(), out value);
                                newUser.dailyCalorieGoal = value;
                                Int32.TryParse(row["goalWeight"].ToString(), out value);
                                newUser.goalWeight = value;
                            }
                        }

                        return newUser;
                    }
                }
            }
        }
    }
}