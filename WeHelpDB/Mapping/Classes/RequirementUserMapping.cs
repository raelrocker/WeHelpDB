using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeHelpDB.Entities;
using WeHelpDB.Mapping.Interfaces;

namespace WeHelpDB.Mapping.Classes
{
    class RequirementUserMapping : EntityTypeConfiguration<RequirementUser>, IMapping
    {
        public RequirementUserMapping()
        {
            ToTable("RequirementUser");
            HasKey(p => new
            {
                p.RequirementId,
                p.UserId
            });
            HasRequired(p => p.Requirement).WithMany(p => p.UserRequirements).HasForeignKey(p => p.RequirementId).WillCascadeOnDelete();
            HasRequired(p => p.User).WithMany(p => p.Requirements).HasForeignKey(p => p.UserId).WillCascadeOnDelete(false);
            Property(p => p.CreatedAt).IsRequired();
            Property(p => p.UpdatedAt).IsRequired();
            Property(p => p.Quant).IsRequired().HasPrecision(6, 2);
            Property(p => p.Unity).HasMaxLength(2).IsFixedLength().IsRequired();
        }
    }
}
