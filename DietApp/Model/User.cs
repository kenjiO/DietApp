using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Model
{
    /// <summary>
    /// User class, relates to Users table in HealthTrends
    /// </summary>
    public class User
    {
        public User()
        {
        }
        
        //*********** Getters and Setters **********//
        public int userID { get; set; }
        public string username { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public double initialWeight { get; set; }
        public int heightFeet { get; set; }
        public int heightInches { get; set; }
        public double dailyCalorieGoal { get; set; }
        public double goalWeight { get; set; }

        public string email { get; set; }

        /// <summary>
        /// Returns the concatenated string of first name, last name.
        /// </summary>
        public string UserInfo
        {
            get
            {
                return this.firstName + " " + this.lastName;
            }
        }
    }
}