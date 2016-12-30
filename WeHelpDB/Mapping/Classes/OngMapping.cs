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
    public class OngMapping : EntityTypeConfiguration<Ong>, IMapping
    {
        public OngMapping()
        {
            ToTable("Ongs");
            HasKey(p => p.UserId);
            Property(p => p.Name).HasMaxLength(50).IsRequired();
            Property(p => p.Cnpj).HasMaxLength(18).IsRequired();
            Property(p => p.Street).HasMaxLength(50).IsRequired();
            Property(p => p.Complement).HasMaxLength(30).IsOptional();
            Property(p => p.Number).IsOptional();
            Property(p => p.Zip).HasMaxLength(9).IsRequired();
            Property(p => p.City).HasMaxLength(50).IsRequired();
            Property(p => p.State).IsFixedLength().HasMaxLength(2).IsRequired();
            Property(p => p.Lat).HasPrecision(17, 14).IsRequired();
            Property(p => p.Lng).HasPrecision(17, 14).IsRequired();
            Property(p => p.CreatedAt).IsRequired();
            Property(p => p.UpdatedAt).IsRequired();
            
        }
    }
}
