using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace TruckDriver.Domain.Entitys
{
    public class User : Entity
    {
        public override string TABLE_NAME { get => "User"; set => base.TABLE_NAME = value; }
        public string Name { get; set; }
        public string Password { get; set; }


        public User()
        {

        }

        public User(string name, string password)
        {
            Name = name;
            Password = HashPassword(password);
        }



        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                string hash = BitConverter.ToString(hashBytes).Replace("-", "");

                return hash;
            }
        }

        public bool VerifyPassword(string password)
        {
            string calculatedHash = HashPassword(password);

            return this.Password.Equals(calculatedHash);
        }
    }
}
