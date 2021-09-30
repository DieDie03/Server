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
    class LightConfig : IEntityTypeConfiguration<Light>
    {
        public void Configure(EntityTypeBuilder<Light> builder)
        {
            // unique index
            builder.HasIndex(x => x.Id).IsUnique();
            builder.Property(x => x.Blue).IsRequired();
            builder.Property(x => x.Green).IsRequired();
            builder.Property(x => x.Red).IsRequired();
        }
    }
}
