using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeHelpDB.Entities;
using WeHelpDB.Mapping.Interfaces;

namespace WeHelpDB.Mapping.Classes
{
    public class RequirementMapping : EntityTypeConfiguration<Requirement>, IMapping
    {
        public RequirementMapping()
        {
            HasKey(p => p.RequirementId);
            Property(p => p.RequirementId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Description).HasMaxLength(50).IsRequired();
            Property(p => p.Quant).IsRequired().HasPrecision(6,2);
            Property(p => p.Unity).HasMaxLength(2).IsFixedLength().IsRequired();
            Property(p => p.CreatedAt).IsRequired();
            Property(p => p.UpdatedAt).IsRequired();
            
        }
    }
}
