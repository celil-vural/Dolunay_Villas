using Entity.Models.RealEstateManagement.BedTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Concrete.EntityFramework.Config.RealEstateManagement.BedType
{
    public class BedTypeConfig : IEntityTypeConfiguration<BedTypes>
    {
        public void Configure(EntityTypeBuilder<BedTypes> builder)
        {
            builder.HasData(
                new BedTypes
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
                    ItemTypeKey = 3,
                    ValueTypeKey = 1,
                },
                new BedTypes
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
                    ItemTypeKey = 1,
                    ValueTypeKey = 3,
                },
                new BedTypes
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
                    ItemTypeKey = 2,
                    ValueTypeKey = 1,
                },
               new BedTypes
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
                   ItemTypeKey = 1,
                   ValueTypeKey = 3,
               }
            );
        }
    }
}
