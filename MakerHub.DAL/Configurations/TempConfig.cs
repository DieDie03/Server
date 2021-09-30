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
    class TempConfig : IEntityTypeConfiguration<Temperature>
    {
        public void Configure(EntityTypeBuilder<Temperature> builder)
        {
            // unique index
            builder.HasIndex(x => x.Id).IsUnique();
            builder.Property(x => x.Degrees).IsRequired();
        }
    }
}
