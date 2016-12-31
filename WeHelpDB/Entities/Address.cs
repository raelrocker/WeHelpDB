using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeHelpDB.Entities
{
    public class Address
    {
        public string Street { get; set; }
        public string Complement { get; set; }
        public int? Number { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
    }
}
