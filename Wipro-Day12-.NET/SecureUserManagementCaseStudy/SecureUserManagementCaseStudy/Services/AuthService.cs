using System;
using System.Collections.Generic;
using SecureUserManagementCaseStudy.Models;     // assuming User is here

namespace SecureUserManagementCaseStudy.Services
{
    public class AuthService
    {
        private readonly List<User> users = new List<User>();

        public void Register(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username cannot be empty");

            // Optional: check if username already exists
            if (users.Exists(u => u.Username == username))
                throw new InvalidOperationException("Username already exists");

            string hashedPassword = HashPassword(password);
            users.Add(new User(username, hashedPassword));
        }

        public bool Authenticate(string username, string password)
        {
            string hashedPassword = HashPassword(password);

            foreach (User user in users)
            {
                if (user.Username == username &&
                    user.HashedPassword == hashedPassword)
                {
                    return true;
                }
            }
            return false;
        }

        // You MUST implement this method!
        private string HashPassword(string password)
        {
            // Use BCrypt, Argon2, PBKDF2, etc. in real projects
            // This is just a bad example – NEVER use in production!
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password + "verybad salt"));
        }
    }
}