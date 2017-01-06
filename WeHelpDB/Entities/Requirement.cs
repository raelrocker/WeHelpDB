using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeHelpDB.Entities
{
    public class Requirement
    {
        #region Constrcutor
        public Requirement()
        {

        }
        #endregion

        #region Properties
        public int RequirementId { get; set; }
        public int EventoId { get; set; }
        public string Description { get; set; }
        public decimal Quant { get; set; }
        public string Unity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        #endregion

        #region Relationships
        public virtual Event Event { get; set; }
        #endregion
    }
}
