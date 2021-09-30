using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MakerHub.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakerHub.DAL.Configurations
{
    class AggroConfig : IEntityTypeConfiguration<Aggrometre>
    {
        public void Configure(EntityTypeBuilder<Aggrometre> builder)
        {
            builder.Property(x => x.Humidity).IsRequired();
            builder.Property(x => x.test).IsRequired();

            // unique index
            builder.HasIndex(x => x.Id).IsUnique();
        }
    }
}
