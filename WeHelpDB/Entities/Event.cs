using System;

namespace WeHelpDB.Entities
{
    public class Event
    {
        #region Constuctor
        public Event()
        {
            Address = new Address();
        }
        #endregion

        #region Properties
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public Address Address { get; set; }
        public string EventStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        #endregion

        #region Relationships
        public Category Category { get; set; }
        public User User { get; set; }
        #endregion
    }
}
