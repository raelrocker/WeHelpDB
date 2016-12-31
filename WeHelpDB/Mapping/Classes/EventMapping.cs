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
    public class EventMapping : EntityTypeConfiguration<Event>, IMapping
    {
        public EventMapping()
        {
            HasKey(p => p.EventId);
            Property(p => p.EventId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Name).HasMaxLength(50).IsRequired();
            Property(p => p.Description).HasMaxLength(300).IsRequired();
            Property(p => p.StartDate).IsRequired();
            Property(p => p.FinishDate).IsOptional();
            Property(p => p.EventStatus).IsRequired().IsFixedLength().HasMaxLength(1);
            Property(p => p.CreatedAt).IsRequired();
            Property(p => p.UpdatedAt).IsRequired();
        }
    }
}
