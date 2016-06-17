using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietApp.Model;
using DietApp.Database;

namespace DietApp.Controller
{
    public class AppController
    {
        /// <summary>
        /// Gets the current loggod on user
        /// </summary>
        /// <returns>User object representing the current loggod on user</returns>
        public User GetCurrentUser()
        {
            //TODO: get the actual current user
            return UserDb.GetUser("user1");
        }
    }


  
}
