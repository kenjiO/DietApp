using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Model
{
    public class Progress
    {
        public int oldBMI { get; set; }
        public int newBMI { get; set; }
        public int userID { get; set; }

        override public string ToString()
        {
            return "Old BMI: " + this.oldBMI + " New BMI: " + this.newBMI + " UserId: " + this.userID;
        }
    }
}
