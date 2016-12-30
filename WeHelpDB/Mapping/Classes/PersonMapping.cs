using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WeHelpDB.Entities;
using WeHelpDB.Mapping.Interfaces;

namespace WeHelpDB.Mapping.Classes
{
    public class PersonMapping : EntityTypeConfiguration<Person>, IMapping
    {
        public PersonMapping()
        {
            HasKey(p => p.UserId);
            Property(p => p.Name).HasMaxLength(50).IsRequired();
            Property(p => p.CreatedAt).IsRequired();
            Property(p => p.UpdatedAt).IsRequired();
            
        }
    }
}
