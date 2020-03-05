using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationApp.Utils
{
    public class Helper
    {
        public static string CreateSalt(int size)
        {
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buf = new byte[size];
            rng.GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
        public static string GenerateSHA256Hash(string input, string salt)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input + salt);
            System.Security.Cryptography.SHA256Managed sha256hashString =
                new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256hashString.ComputeHash(bytes);
            return ByteArrayToString(hash);
        }


    }
}
