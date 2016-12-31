using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeHelpDB.Context;
using WeHelpDB.Entities;
using WeHelpDB.Repositories.Abstract;
using WeHelpDB.Repositories.Interfaces;

namespace WeHelpDB.Repositories.Classes
{
    public class EventRepository : Repository<Event>, IRepository<Event>
    {
        #region Constructor
        public EventRepository(WeHelpContext context)
            : base (context)
        { }
        #endregion
    }
}
