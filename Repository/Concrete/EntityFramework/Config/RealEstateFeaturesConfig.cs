using Entity.Models.RealEstateManagement.RealEstateFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Concrete.EntityFramework.Config
{
    public class RealEstateFeaturesConfig : IEntityTypeConfiguration<RealEstateFeatures>
    {
        public void Configure(EntityTypeBuilder<RealEstateFeatures> builder)
        {
            builder.HasKey(r => r.Id);
            builder.HasOne(r => r.ParentRealEstateFeatures)
           .WithMany(r => r.SubRealEstateFeatures)
           .HasForeignKey(r => r.ParentRealEstateFeaturesId)
           .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(r => r.SubRealEstateFeatures)
            .WithOne(r => r.ParentRealEstateFeatures)
            .HasForeignKey(r => r.ParentRealEstateFeaturesId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
