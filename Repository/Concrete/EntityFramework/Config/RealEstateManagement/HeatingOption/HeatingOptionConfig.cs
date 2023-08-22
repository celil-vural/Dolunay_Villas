using Entity.Models.RealEstateManagement.HeatingOption;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Concrete.EntityFramework.Config.RealEstateManagement.HeatingOption
{
    public class HeatingOptionConfig : IEntityTypeConfiguration<HeatingOptions>
    {
        public void Configure(EntityTypeBuilder<HeatingOptions> builder)
        {
            builder.HasData(
                new HeatingOptions
                {
                    Id = 1,
                    Title_Tr = "Doğalgaz",
                    Title_En = "Natural Gas",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedByUser = "Default",
                    UpdatedByUser = "Default"
                },
                new HeatingOptions
                {
                    Id = 2,
                    Title_Tr = "Klima",
                    Title_En = "Air Conditioner",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedByUser = "Default",
                    UpdatedByUser = "Default"
                },
                new HeatingOptions
                {
                    Id = 3,
                    Title_Tr = "Soba",
                    Title_En = "Stove",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedByUser = "Default",
                    UpdatedByUser = "Default"
                },
                new HeatingOptions
                {
                    Id = 4,
                    Title_Tr = "Şömine",
                    Title_En = "Fire Place",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedByUser = "Default",
                    UpdatedByUser = "Default"
                },
                new HeatingOptions
                {
                    Id = 5,
                    Title_Tr = "Yerden Isıtma",
                    Title_En = "Underfloor Heating",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedByUser = "Default",
                    UpdatedByUser = "Default"
                }
            );
        }
    }
}
