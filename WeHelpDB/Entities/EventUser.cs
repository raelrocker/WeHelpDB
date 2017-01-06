using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeHelpDB.Entities
{
    public class EventUser
    {
        #region Constructor
        public EventUser()
        {

        }
        #endregion

        #region Properties
        public int EventId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        #endregion

        #region Relationships
        public virtual Event Event { get; set; }
        public virtual User User { get; set; }
        #endregion

    }
}
