using System;
using System.Security.Cryptography;
using System.Text;

namespace SecureUserManagementCaseStudy.Security
{
    public static class Crypto
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}






























/*
 * 
 * using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SecureUserManagementCaseStudy.Security
{
    public static class Crypto
    {



        {
            public static string HashPassword(string password)  // MUST be public static
            {
                using (var sha = System.Security.Cryptography.SHA256.Create())
                {
                    byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password);
                    byte[] hash = sha.ComputeHash(bytes);
                    return System.Convert.ToBase64String(hash);
                }
            }
        }
    }


















    private static readonly byte[] Key = Encoding.UTF8.GetBytes("1234567890123456");
            private static readonly byte[] IV = Encoding.UTF8.GetBytes("6543210987654321");

            public static string HashPassword(string password)
            {
                SHA256 sha = SHA256.Create();
                byte[] hashBytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashBytes);
            }

            public static string Encrypt(string plainText)
            {
                 Aes aes = Aes.Create();
                aes.Key = Key;
                aes.IV = IV;

                 MemoryStream ms = new MemoryStream();
               CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);
                 StreamWriter sw = new StreamWriter(cs);

                sw.Write(plainText);
                sw.Close();

                return Convert.ToBase64String(ms.ToArray());
            }

            public static string Decrypt(string cipherText)
            {
                 Aes aes = Aes.Create();
                aes.Key = Key;
                aes.IV = IV;

                byte[] buffer = Convert.FromBase64String(cipherText);

              MemoryStream ms = new MemoryStream(buffer);
               CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read);
                 StreamReader sr = new StreamReader(cs);

                return sr.ReadToEnd();
            }
        }
    }
}*/