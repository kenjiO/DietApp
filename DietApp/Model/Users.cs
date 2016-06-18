﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Model
{
    public class Users
    {
        public int userId { get; set; }
        public string username { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int initialWeight { get; set; }
        public int heightInches { get; set; }
        public int dailyCalorieGoal { get; set; }
        public int goalWeight { get; set; }

        /// <summary>
        /// Concatenates the user's first and last name.
        /// </summary>
        /// <returns>A string representation of the user's full name.</returns>
        public string getFullName()
        {
            return firstName + " " + lastName;
        }
    }
}