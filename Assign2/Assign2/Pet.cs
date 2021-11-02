using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assign2
{
    public class Pet
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int OwnerId { get; set; }
    }
}
