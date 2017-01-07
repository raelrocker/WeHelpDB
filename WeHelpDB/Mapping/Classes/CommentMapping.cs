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
    public class CommentMapping : EntityTypeConfiguration<Comment>, IMapping
    {
        public CommentMapping()
        {
            ToTable("Comments");
            HasKey(p => new
            {
                p.EventId,
                p.UserId,
                p.CreatedAt
            });
            Property(p => p.UserId).IsRequired();
            Property(p => p.EventId).IsRequired();
            Property(p => p.CreatedAt).IsRequired();
            Property(p => p.UpdatedAt).IsRequired();
            Property(p => p.Text).HasMaxLength(200).IsRequired();
            HasRequired(p => p.Event).WithMany(p => p.Comments).WillCascadeOnDelete();
            HasRequired(p => p.User).WithMany(p => p.Comments).WillCascadeOnDelete(false);
        }
    }
}
