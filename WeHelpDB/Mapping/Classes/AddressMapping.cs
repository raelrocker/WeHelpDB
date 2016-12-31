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
    public class AddressMapping : ComplexTypeConfiguration<Address>, IMapping
    {
        public AddressMapping()
        {
            Property(p => p.Street).HasMaxLength(50).IsRequired().HasColumnName("Street");
            Property(p => p.Complement).HasMaxLength(30).IsOptional().HasColumnName("Complement");
            Property(p => p.Number).IsOptional().HasColumnName("Number");
            Property(p => p.Zip).HasMaxLength(9).IsRequired().IsRequired().HasColumnName("Zip");
            Property(p => p.City).HasMaxLength(50).IsRequired().IsRequired().HasColumnName("City");
            Property(p => p.State).IsFixedLength().HasMaxLength(2).IsRequired().IsRequired().HasColumnName("State");
            Property(p => p.Lat).HasPrecision(17, 14).IsRequired().IsRequired().HasColumnName("Lat");
            Property(p => p.Lng).HasPrecision(17, 14).IsRequired().IsRequired().HasColumnName("Lng");
        }
    }
}
