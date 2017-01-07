using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeHelpDB.Entities
{
    public class Comment
    {
        #region Constructor
        public Comment()
        { }
        #endregion

        #region Properties
        public int EventId { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        #endregion

        #region Relationships
        public Event Event { get; set; }
        public User User { get; set; }
        #endregion
    }
}
