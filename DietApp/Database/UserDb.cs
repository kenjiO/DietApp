using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DietApp.Model;

namespace DietApp.Database
{
    public static class UserDb
    {

        public static User GetUser(string username)
        {
           string selectStatement =
                "SELECT firstName, lastName, email " +
                "FROM users " +
                "WHERE username = @username";

           using (SqlConnection connection = DbConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            User user = new User();

                            if (!DBNull.Value.Equals(reader["firstName"]))
                                user.firstName = reader["firstName"].ToString();
                            if (!DBNull.Value.Equals(reader["lastName"]))
                                user.lastName = reader["lastName"].ToString();
                            if (!DBNull.Value.Equals(reader["email"]))
                                user.email = reader["email"].ToString();
                            return user;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        /// <summary>
        ///     Creates a New User
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        public static bool CreateNewUser(User user)
        {
            bool insertSuccessful = true;
            String insertStatement =
                "INSERT INTO Users (" +
                "Users.username, " +
                "Users.firstName, " +
                "Users.lastName, " +
                "Users.password, " +
                "Users.initialWeight, " +
                "Users.heightFeet, " +
                "Users.heightInches, " +
                "Users.dailyCalorieGoal, " +
                "Users.goalWeight" +
                ")" +
                " VALUES(" +
                "@username, " +
                "@firstName, " +
                "@lastName, " +
                "@password, " +
                "@initialWeight, " +
                "@heightFeet, " +
                "@heightInches, " +
                "@dailyCalorieGoal, " +
                "@goalWeight" +
                ")";

            try
            {
                using (SqlConnection connection = DbConnection.GetConnection())
                {
                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {
                        connection.Open();

                        insertCommand.Parameters.AddWithValue("@username", user.username);
                        insertCommand.Parameters.AddWithValue("@firstName", user.firstName);
                        insertCommand.Parameters.AddWithValue("@lastName", user.lastName);
                        insertCommand.Parameters.AddWithValue("@password", user.password);
                        insertCommand.Parameters.AddWithValue("@initialWeight", user.initialWeight);
                        insertCommand.Parameters.AddWithValue("@heightFeet", user.heightFeet);
                        insertCommand.Parameters.AddWithValue("@heightInches", user.heightInches);
                        insertCommand.Parameters.AddWithValue("@dailyCalorieGoal", user.dailyCalorieGoal);
                        insertCommand.Parameters.AddWithValue("@goalWeight", user.goalWeight);
                    }
                }
            }
            //catch (DuplicateKeyException)
            //{
            //    throw;
            //}
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            return insertSuccessful;
        }
    }
}
