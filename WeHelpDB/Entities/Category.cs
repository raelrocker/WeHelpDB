using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeHelpDB.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Description { get; set; }

        #region Relationships
        public ICollection<Event> Events { get; set; }
        #endregion
    }
}
