using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeHelpDB.Entities
{
    public class RequirementUser
    {
        #region Constructor
        public RequirementUser()
        { }
        #endregion

        #region Properties
        public int RequirementId { get; set; }
        public int UserId { get; set; }
        public decimal Quant { get; set; }
        public string Unity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        #endregion

        #region Relationships
        public virtual Requirement Requirement { get; set; }
        public virtual User User { get; set; }
        #endregion
    }
}
