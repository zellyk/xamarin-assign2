using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assign2
{
    public class Vet
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Specialization { get; set; }
        public string Name => $"{FirstName} {LastName}";
    }
}
