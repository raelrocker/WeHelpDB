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
    public class CategoryMapping : EntityTypeConfiguration<Category>, IMapping
    {
        public CategoryMapping()
        {
            HasKey(p => p.CategoryId);
            Property(p => p.CategoryId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Description).HasMaxLength(20);
        }
    }
}
