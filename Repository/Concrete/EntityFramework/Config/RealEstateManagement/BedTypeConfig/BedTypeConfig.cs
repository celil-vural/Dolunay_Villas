using Entity.Models.RealEstateManagement.BedTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Concrete.EntityFramework.Config.RealEstateManagement.BedTypeConfig
{
    public class BedTypeConfig : IEntityTypeConfiguration<BedType>
    {
        public void Configure(EntityTypeBuilder<BedType> builder)
        {
            builder.HasKey(b => b.Id);
            builder.HasOne(b => b.ValueType)
                   .WithMany(vt => vt.BedTypes)
                   .HasForeignKey(b => b.ValueTypeId)
                   .IsRequired();
            builder.HasData(
                new BedType
                {
                    Id = 1,
                    Title_Tr = "TV",
                    Title_En = "TV",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedByUser = "Default",
                    UpdatedByUser = "Default",
                    LocalIconId = null,
                    FontAwesomeIcon = "fa-solid fa-tv",
                    ItemTypeId = 3,
                    ValueTypeId = 1,
                },
                new BedType
                {
                    Id = 2,
                    Title_Tr = "Jakuzi",
                    Title_En = "Jacuzzi",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedByUser = "Default",
                    UpdatedByUser = "Default",
                    LocalIconId = null,
                    FontAwesomeIcon = "fa-solid fa-tv",
                    ItemTypeId = 1,
                    ValueTypeId = 3,
                },
                new BedType
                {
                    Id = 3,
                    Title_Tr = "Elbise dolabı",
                    Title_En = "Dress cabinet",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedByUser = "Default",
                    UpdatedByUser = "Default",
                    LocalIconId = null,
                    FontAwesomeIcon = "fa-solid fa-person-dress",
                    ItemTypeId = 2,
                    ValueTypeId = 1,
                },
               new BedType
               {
                   Id = 4,
                   Title_Tr = "Banyo/WC",
                   Title_En = "Bathroom/WC",
                   CreatedAt = DateTime.Now,
                   UpdatedAt = DateTime.Now,
                   CreatedByUser = "Default",
                   UpdatedByUser = "Default",
                   LocalIconId = null,
                   FontAwesomeIcon = "fa-solid fa-person-dress",
                   ItemTypeId = 1,
                   ValueTypeId = 3,
               }
            );
        }
    }
}