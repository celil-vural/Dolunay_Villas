using Entity.Models.RealEstateManagement.Regions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Repository.Concrete.EntityFramework.Config
{
    public class RegionConfig : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.HasKey(r => r.Id);
            builder.HasOne(r => r.ParentRegion)
           .WithMany(r => r.SubRegions)
           .HasForeignKey(r => r.ParentRegionID)
           .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(r => r.SubRegions)
            .WithOne(r => r.ParentRegion)
            .HasForeignKey(r => r.ParentRegionID)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
