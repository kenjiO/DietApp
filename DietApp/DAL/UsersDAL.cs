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
                        var result = Int16.TryParse(idNumber, out number);
                        if (result)
                        {
                            newUser = getUserData(number);
                        }

                        return newUser;
                    }
                }
            }
        }

        /// <summary>
        /// Retrieves the user data from the system for the specified user.
        /// </summary>
        /// <param name="userId">The user name.</param>
        /// <returns>The user object containing the specified data.</returns>
        public static Users getUserData(int userId)
        {
            int value;
            var newUser = new Users();
            using (var userDataTable = new DietAppDataSet())
            {
                using (var userIDDataSet = new DietAppDataSetTableAdapters.usersIdTableAdapter())
                {
                    using (var userDataSet = new DietAppDataSetTableAdapters.usersTableAdapter())
                    {
                        userDataSet.FillData(userDataTable.users, userId);
                        foreach (DataRow row in userDataSet.GetData(userId).Rows)
                        {
                            newUser.userId = userId;
                            newUser.userName = row["userName"].ToString();
                            newUser.firstName = row["firstName"].ToString();
                            newUser.lastName = row["lastName"].ToString();
                            newUser.email = row["email"].ToString();
                            Int32.TryParse(row["initialWeight"].ToString(), out value);
                            newUser.initialWeight = value;
                            Int32.TryParse(row["heightInches"].ToString(), out value);
                            newUser.heightInches = value;
                            Int32.TryParse(row["dailyCalorieGoal"].ToString(), out value);
                            newUser.dailyCalorieGoal = value;
                            Int32.TryParse(row["goalWeight"].ToString(), out value);
                            newUser.goalWeight = value;
                        }

                        return newUser;
                    }
                }
            }
        }

        /// <summary>
        ///Adds a userName and password to the DB for a new user to be created.  Returns the newUser's userID.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>newUsers userID</returns>
        public static int addNewUser(String userName, String password)
        {
            var PasswordHash = new Encryption();
            short number;
            var idNumber = "";
            int userID;
            using (var userDataTable = new DietAppDataSet())
            {
                using (var userPasswordComboSet = new DietAppDataSetTableAdapters.userPasswordComboTableAdapter())
                {
                    userPasswordComboSet.Insert(userName, PasswordHash.GetSHA1Hash(password));
                }

                using (var userIDDataSet = new DietAppDataSetTableAdapters.usersIdTableAdapter())
                {
                    foreach (DataRow row in userIDDataSet.GetData(userName).Rows)
                    {
                        idNumber = row["userId"].ToString();
                    }
                    var result = Int16.TryParse(idNumber, out number);
                    if (result)
                    {
                        userID = number;
                    }
                    else
                    {
                        userID = 0;
                    }
                }

                return userID;
            }
        }

        /// <summary>
        /// Updates the newUser's information in the DB.
        /// </summary>
        /// <param name="oldUsers"></param>
        /// <param name="newUsers"></param>
        public static void updateUsers(Users oldUsers, Users newUsers)
        {
            using (var userDataTable = new DietAppDataSet())
            {
                using (var usersDataSet = new DietAppDataSetTableAdapters.usersTableAdapter())
                {
                    usersDataSet.Update(newUsers.userName, newUsers.firstName, newUsers.lastName, newUsers.email,
                    newUsers.initialWeight, newUsers.heightInches, newUsers.dailyCalorieGoal,
                    newUsers.goalWeight, oldUsers.userId, oldUsers.userName, oldUsers.firstName, oldUsers.lastName, oldUsers.email,
                    oldUsers.initialWeight, oldUsers.heightInches, oldUsers.dailyCalorieGoal,
                    oldUsers.goalWeight, newUsers.userId);
                }
            }
        }
    }
}