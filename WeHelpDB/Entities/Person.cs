using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeHelpDB.Entities
{
    public class Person
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        #region Relations
        public virtual User User { get; set; }
        #endregion
    }
}
