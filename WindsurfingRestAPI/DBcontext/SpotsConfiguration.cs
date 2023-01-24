using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WindsurfingRestAPI.Entities;

namespace WindsurfingRestAPI.DBcontext
{
    public class SpotsConfiguration : IEntityTypeConfiguration<Spot>
    {

        public void Configure(EntityTypeBuilder<Spot> builder)
        {
            builder
                 .HasMany<Windsurfer>(s => s.Windsurfers)
                 .WithMany(c => c.Spots);
        }
    }
}
