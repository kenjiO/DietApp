using DietApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Cryptography;
using System.Text;

namespace DietApp.ModelTest
{
    [TestClass]
    public class EncryptionTest
    {
        private string testword = "password";

        /// <summary>
        /// Test the encryption of Passwords
        /// </summary>
        [TestMethod]
        public void TestEncryption()
        {
            //Encrypt Testword
            SHA1CryptoServiceProvider x = new SHA1CryptoServiceProvider();
            byte[] bs = Encoding.UTF8.GetBytes(this.testword);
            bs = x.ComputeHash(bs);
            StringBuilder s = new StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            string password = "0x" + s.ToString();

            //Send Testword through encryption
            Encryption encrypt = new Encryption();
            string result = encrypt.GetSAW1Hash(this.testword);

            Assert.AreEqual(password, result, "Encryption Error.");
        }
    }
}