using Entity.Models.RealEstateManagement.EstateType;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Concrete.EntityFramework.Config
{
    public class EstateTypesConfig : IEntityTypeConfiguration<EstateTypes>
    {
        public void Configure(EntityTypeBuilder<EstateTypes> builder)
        {
            builder.HasKey(r => r.Id);
            builder.HasOne(r => r.ParentEstateTypes)
           .WithMany(r => r.SubEstateTypes)
           .HasForeignKey(r => r.ParentEstateTypesId)
           .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(r => r.SubEstateTypes)
            .WithOne(r => r.ParentEstateTypes)
            .HasForeignKey(r => r.ParentEstateTypesId)
            .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(r => r.Photo)
               .WithMany()
               .HasForeignKey(e => e.PhotoId)
               .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
