using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App9
{
    class customer
    {
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }
        public string Name { get; set;}
        public int Size { get; set; }
        public string Color { get; set; }
        public string Address { get; set; }      
        public string Gender { get; set; }

    }
}
