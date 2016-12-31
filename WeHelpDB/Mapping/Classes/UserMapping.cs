using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeHelpDB.Entities;
using WeHelpDB.Mapping.Interfaces;
using WeHelpDB.Extensions;

namespace WeHelpDB.Mapping.Classes
{
    public class UserMapping : EntityTypeConfiguration<User>, IMapping
    {
        public UserMapping()
        {
            ToTable("Users");
            HasKey(p => p.UserId);
            Property(p => p.UserId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Email).HasMaxLength(50).IsRequired().IsUnique();
            Property(p => p.Password).HasMaxLength(100).IsRequired();
            Property(p => p.CreatedAt).IsRequired();
            Property(p => p.UpdatedAt).IsRequired();
            HasOptional(p => p.Person).WithRequired(p => p.User).WillCascadeOnDelete();
            HasOptional(p => p.Ong).WithRequired(p => p.User).WillCascadeOnDelete();
            HasMany(p => p.CreatedEvents).WithRequired(p => p.User).WillCascadeOnDelete();
        }
    }
}
