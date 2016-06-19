using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Model
{
    public class Validation
    {
        /// <summary>
        /// Verifies the hash of input against a given hash.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="hash"></param>
        /// <returns>A boolean valuse. tRUE IF MATCH, ELSE FALSE</returns>
        public bool VerifySHA1Hash(String input, String hash)
        {
            Encryption PasswordHash = new Encryption();
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(PasswordHash.GetSAW1Hash(input), hash))
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