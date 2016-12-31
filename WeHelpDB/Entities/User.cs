using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeHelpDB.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        #region Relationships
        public virtual Person Person { get; set; }
        public virtual Ong Ong { get; set; }
        public virtual ICollection<Event> CreatedEvents { get; set; }
        #endregion
    }
}
