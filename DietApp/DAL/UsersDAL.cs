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
        /// <param name="userName">Username</param>
        /// <param name="password">Password</param>
        /// <returns>newUsers userId</returns>
        public static int addNewUser(String userName, String password)
        {
            var PasswordHash = new Encryption();
            short number;
            var idNumber = "";
            int userId;
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
                        userId = number;
                    }
                    else
                    {
                        userId = 0;
                    }
                }

                return userId;
            }
        }

        /// <summary>
        /// Updates the newUser's information in the DB.
        /// Note: userId, userName, and password will not update.
        /// </summary>
        /// <param name="oldUsers">The old user's information</param>
        /// <param name="newUsers">The new user's information</param>
        public static void updateUsers(Users oldUsers, Users newUsers)
        {
            using (var userDataTable = new DietAppDataSet())
            {
                using (var usersDataSet = new DietAppDataSetTableAdapters.usersTableAdapter())
                {
                    usersDataSet.updateUser(newUsers.firstName, newUsers.lastName, newUsers.email,
                    newUsers.initialWeight, newUsers.heightInches, newUsers.dailyCalorieGoal, newUsers.goalWeight,
                    oldUsers.userId, oldUsers.firstName, oldUsers.lastName, oldUsers.email,
                    oldUsers.initialWeight, oldUsers.heightInches, oldUsers.dailyCalorieGoal, oldUsers.goalWeight);
                }
            }
        }

        /// <summary>
        /// Deletes User's information in the DB.
        /// Note:  This is used for testing only.
        /// </summary>
        /// <param name="userId">Id(row) of user.</param>
        public static void deleteUsers(int userId)
        {
            using (var userDataTable = new DietAppDataSet())
            {
                using (var usersDataSet = new DietAppDataSetTableAdapters.usersTableAdapter())
                {
                    usersDataSet.deleteUser(userId);
                }
            }
        }
    }
}