﻿using DietApp.DAL;
using DietApp.Model;
using System;

namespace DietApp.Controller
{
    public class DietAppController
    {
        /// <summary>
        /// Compares the password against the stored value of the password for the specified userName in the database.
        /// </summary>
        /// <param name="userName">The user name.</param>
        /// <param name="password">The password.</param>
        /// <returns>A boolean value indicating if the data matches.</returns>
        public static Boolean comparePassword(String userName, String password)
        {
            return Model_Validator.comparePassword(userName, password);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>new Users user</returns>
        public static int addNewUser(String userName, String password)
        {
            return UsersDAL.addNewUser(userName, password);
        }

        /// <summary>
        /// Retrieves the user data from the system for the specified user.
        /// </summary>
        /// <param name="userName">The user name.</param>
        /// <returns>The user object containing the specified data.</returns>
        public static Users getUserData(String userName)
        {
            return UsersDAL.getUserData(userName);
        }

        /// <summary>
        /// Retrieves the user data from the system for the specified user.
        /// </summary>
        /// <param name="userId">The user name.</param>
        /// <returns>The user object containing the specified data.</returns>
        public static Users getUserData(int userId)
        {
            return UsersDAL.getUserData(userId);
        }

        /// <summary>
        /// Updates the user information.
        /// </summary>
        /// <param name="oldUsers"></param>
        /// <param name="newUsers"></param>
        public static void updateUsers(Users oldUsers, Users newUsers)
        {
            UsersDAL.updateUsers(oldUsers, newUsers);
        }


        public static Wellness dateWellnessData(int userId, string date)
        {
            return WellnessDAL.dateWellnessData(userId, date);
        }
    }
}