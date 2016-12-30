using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeHelpDB.Entities
{
    public class Ong
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public byte[] Photo { get; set; }
        public string Street { get; set; }
        public string Complement { get; set; }
        public int? Number { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        #region Relations
        public virtual User User { get; set; }
        #endregion
    }
}
