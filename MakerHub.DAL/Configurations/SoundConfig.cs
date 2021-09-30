using MakerHub.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHub.DAL.Configurations
{
    class SoundConfig : IEntityTypeConfiguration<Sound>
    {
        public void Configure(EntityTypeBuilder<Sound> builder)
        {
            // unique index
            builder.HasIndex(x => x.Id).IsUnique();
            builder.Property(x => x.Level).IsRequired();
            builder.Property(x => x.Intensity).IsRequired();
        }
    }
}
