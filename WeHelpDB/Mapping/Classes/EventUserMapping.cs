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
    public class EventUserMapping : EntityTypeConfiguration<EventUser>, IMapping
    {
        public EventUserMapping()
        {
            ToTable("EventUser");
            HasKey(p => new
            {
                p.EventId,
                p.UserId
            });
            HasRequired(p => p.Event).WithMany(p => p.Participants).HasForeignKey(p => p.EventId).WillCascadeOnDelete();
            HasRequired(p => p.User).WithMany(p => p.ParticipateEvents).HasForeignKey(p => p.UserId).WillCascadeOnDelete(false);
            Property(p => p.CreatedAt).IsRequired();
            Property(p => p.UpdatedAt).IsRequired();
        }
    }
}
