using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeHelpDB.Entities
{
    public class Ong
    {
        #region Constructor
        public Ong()
        {
            Address = new Address();
        }
        #endregion

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public byte[] Photo { get; set; }
        public Address Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        #region Relations
        public virtual User User { get; set; }
        #endregion
    }
}
