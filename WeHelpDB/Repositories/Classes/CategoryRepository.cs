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
    public class CategoryRepository : Repository<Category>, IRepository<Category>
    {
        #region Constructor
        public CategoryRepository(WeHelpContext context)
            : base (context)
        { }
        #endregion
    }
}
