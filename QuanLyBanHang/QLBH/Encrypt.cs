using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace QLBH
{
    class Encrypt
    {
        public string HashCode(string passText)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (byte b in GetHash(passText))
                {
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }
            catch
            {
                throw;
            }
        }

        public static byte[] GetHash(string passText)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(passText));
        }
    }
}
