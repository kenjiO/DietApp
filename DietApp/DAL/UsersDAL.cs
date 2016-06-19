using DietApp.Model;
using System;
using System.Data;
using System.Data.SqlClient;

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
                                newUser.username = row["username"].ToString();
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

        /// <summary>
        /// Creates a New User
        /// </summary>
        /// <param name="User"></param>
        /// <returns>A bool result. True if added, else false.</returns>
        public static Users addNewUser(String username, String password)
        {
            String insertStatement =
                "INSERT INTO Users (" +
                "Users.username, " +
                "Users.firstName, " +
                "Users.lastName, " +
                "Users.email, " +
                "Users.password, " +
                "Users.initialWeight, " +
                "Users.heightInches, " +
                "Users.dailyCalorieGoal, " +
                "Users.goalWeight" +
                ")" +
                " VALUES(" +
                "@username, " +
                "@firstName, " +
                "@lastName, " +
                "@email, " +
                "@password, " +
                "@initialWeight, " +
                "@heightInches, " +
                "@dailyCalorieGoal, " +
                "@goalWeight" +
                ")";

            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {
                        connection.Open();

                        insertCommand.Parameters.AddWithValue("@username", username);
                        insertCommand.Parameters.AddWithValue("@firstName", "New");
                        insertCommand.Parameters.AddWithValue("@lastName", "User");
                        insertCommand.Parameters.AddWithValue("@email", "sample@email.com");
                        insertCommand.Parameters.AddWithValue("@password", password);
                        insertCommand.Parameters.AddWithValue("@initialWeight", 150);
                        insertCommand.Parameters.AddWithValue("@heightInches", 69);
                        insertCommand.Parameters.AddWithValue("@dailyCalorieGoal", 1800);
                        insertCommand.Parameters.AddWithValue("@goalWeight", 140);


                        insertCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            return getUserData(username);
        }
    
        /// <summary>
        /// Get the hashed password from the DB, hashes the input password, and validates that the two match.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>A bool result. True if match, else false.</returns>
        public static bool ComparePassword(String username, String password)
        {
            Validation validation = new Validation();
            
            String hashedPassword = "";

            String selectStatement =
                "SELECT Users.password " +
                "FROM Users " +
                "WHERE Users.username = @username";

            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@username", username);
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            int passwordOrdinal = reader.GetOrdinal("password");

                            while (reader.Read())
                            {
                                hashedPassword = reader.GetString(passwordOrdinal);
                            }
                        }
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

            return validation.VerifySHA1Hash(password, hashedPassword);
        }
    
        /// <summary>
        /// Updates Users profile
        /// </summary>
        /// <param name="oldUsers"></param>
        /// <param name="newUsers"></param>
        /// <returns>A bool result. True if updated, else false.</returns>
        public static bool updateUsers(Users oldUsers, Users newUsers)
        {
            String updateStatement =
                "UPDATE Users " +
                "SET " +
                "Users.firstName = @newfirstName, " +
                "Users.lastName = @newlastName, " +
                "Users.email = @newemail " +
                "Users.password = @newpassword " +
                "Users.initialWeight = @newinitialWeight, " +
                "Users.heightInches = @newheightInches, " +
                "Users.dailyCalorieGoal = @newdailyCalorieGoal, " +
                "Users.goalWeight = @newgoalWeight" +
                "WHERE Users.firstName = @oldfirstName, " +
                "AND Users.lastName = @oldlastName, " +
                "AND Users.email = @oldemail " +
                "AND Users.password = @oldpassword " +
                "AND Users.initialWeight = @oldinitialWeight, " +
                "AND Users.heightInches = @oldheightInches, " +
                "AND Users.dailyCalorieGoal = @olddailyCalorieGoal, " +
                "AND Users.goalWeight = @oldgoalWeight";

            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                    {
                        connection.Open();

                        updateCommand.Parameters.AddWithValue("@newusername", newUsers.username);
                        updateCommand.Parameters.AddWithValue("@newfirstName", newUsers.firstName);
                        updateCommand.Parameters.AddWithValue("@newlastName", newUsers.lastName);
                        updateCommand.Parameters.AddWithValue("@newemail", newUsers.email);
                        updateCommand.Parameters.AddWithValue("@newpassword", newUsers.password);
                        updateCommand.Parameters.AddWithValue("@newinitialWeight", newUsers.initialWeight);
                        updateCommand.Parameters.AddWithValue("@newheightInches", newUsers.heightInches);
                        updateCommand.Parameters.AddWithValue("@newdailyCalorieGoal", newUsers.dailyCalorieGoal);
                        updateCommand.Parameters.AddWithValue("@newgoalWeight", newUsers.goalWeight);

                        updateCommand.Parameters.AddWithValue("@oldusername", oldUsers.username);
                        updateCommand.Parameters.AddWithValue("@oldfirstName", oldUsers.firstName);
                        updateCommand.Parameters.AddWithValue("@oldlastName", oldUsers.lastName);
                        updateCommand.Parameters.AddWithValue("@oldemail", oldUsers.email);
                        updateCommand.Parameters.AddWithValue("@oldpassword", oldUsers.password);
                        updateCommand.Parameters.AddWithValue("@oldinitialWeight", oldUsers.initialWeight);
                        updateCommand.Parameters.AddWithValue("@oldheightInches", oldUsers.heightInches);
                        updateCommand.Parameters.AddWithValue("@olddailyCalorieGoal", oldUsers.dailyCalorieGoal);
                        updateCommand.Parameters.AddWithValue("@oldgoalWeight", oldUsers.goalWeight);

                        int count = updateCommand.ExecuteNonQuery();
                        if (count > 0)
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
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}