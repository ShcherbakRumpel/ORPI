using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ORPI.Web.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORPI.Web.DAL.Configuration
{
    public class AgencyConfiguration : IEntityTypeConfiguration<Agency>
    {
        public void Configure(EntityTypeBuilder<Agency> builder)
        {
            builder.HasKey(s => new { s.AgencyId });

            builder.HasMany(s => s.AdFiles)
                .WithOne(s => s.Agency)
                .HasForeignKey(s => s.AgencyId);
        }
    }
}
