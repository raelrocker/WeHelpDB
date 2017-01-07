using System;
using System.Collections.Generic;

namespace WeHelpDB.Entities
{
    public class User
    {
        #region Constructor
        public User()
        {
            CreatedEvents = new HashSet<Event>();
            ParticipateEvents = new HashSet<EventUser>();
            Requirements = new HashSet<RequirementUser>();
            Comments = new HashSet<Comment>();
        }
        #endregion

        #region Properties
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        #endregion

        #region Relationships
        public virtual Person Person { get; set; }
        public virtual Ong Ong { get; set; }
        public virtual ICollection<Event> CreatedEvents { get; set; }
        public virtual ICollection<EventUser> ParticipateEvents { get; set; }
        public virtual ICollection<RequirementUser> Requirements { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        #endregion
    }
}
