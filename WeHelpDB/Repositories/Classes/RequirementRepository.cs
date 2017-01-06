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
    public class RequirementRepository : Repository<Requirement>, IRepository<Requirement>
    {
        #region Constructor
        public RequirementRepository(WeHelpContext context)
            : base (context)
        { }
        #endregion
    }
}
