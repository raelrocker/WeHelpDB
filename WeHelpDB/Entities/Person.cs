using System;

namespace WeHelpDB.Entities
{
    public class Person
    {
        #region Properties
        public int UserId { get; set; }
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        #endregion

        #region Relations
        public virtual User User { get; set; }
        #endregion
    }
}
