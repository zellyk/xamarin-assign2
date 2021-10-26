using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assign2
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public bool IsValid(out string message)
        {
            message = default;
            if(Password.Length >= 10)return true;

            message = "Password length must be greater than or equal to 10 characters";

            return false;
        }
    }
}
