using System.Collections.Generic;

namespace WeHelpDB.Entities
{
    public class Category
    {
        #region Properties
        public int CategoryId { get; set; }
        public string Description { get; set; }
        #endregion

        #region Relationships
        public ICollection<Event> Events { get; set; }
        #endregion
    }
}
