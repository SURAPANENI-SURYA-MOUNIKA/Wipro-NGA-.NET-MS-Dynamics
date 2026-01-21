using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace DemoEncryption
{

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Aes class
            //string message = "Here is a secret message that will be encrypted using AES encryption!";
            string password = "Strogpassword123";
            //convert string to bytes
            byte[] passwordbyte= Encoding.UTF8.GetBytes(password);
            //creating HSA 256 instance
            SHA256 sha256 = SHA256.Create();//simple hashing algo
            byte[] key = sha256.ComputeHash(passwordbyte);
            //con has to readable string
            string HashPassword = Convert.ToBase64String(key);
            Console.WriteLine("hashed password:" + HashPassword);//display hash password


            
        }
    }
}


























    /*
    internal class Program
    {
        //for implementing encryption in .net we have following packages
       //1. System.Security.Cryptography
       //2.BouncyCasrle
       //3.Bcrypt .net -next

        //steps for implementing encru in .net
        //s-1 choose e cryption algo(AES,RSA,DES
        //s-2 Generate enc keys ex-symmentry key for aes public and private for rsa

        //s-3 imple encr and decr logic
        //s4 test implemetat to ensure data is correct enc and dec
        static void Main(string[] args)
        {
            string message = "Here is  a secret message that will be ency using AES";
            string encyptedMessage = aes.Encrypt(message);
            Console.WriteLine("here is the enc message" + message);

            string decryptedMessage=Aes.Decrypt
        }
    }
}
    */