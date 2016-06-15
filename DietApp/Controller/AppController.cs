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
        public User GetCurrentUser()
        {
            //TODO: get the actual current user
            return UserDb.GetUser("user1");
        }
    }


  
}
