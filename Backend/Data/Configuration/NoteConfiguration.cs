using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class NoteConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder
                .HasKey(n => n.Id);

            builder
                .Property(n => n.Id)
                .UseIdentityColumn();
            builder
                .Property(n => n.Title)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .HasMany(n => n.Users)
                .WithMany(u => u.Notes);
            builder
                .ToTable("Notes");
        }
    }
}
