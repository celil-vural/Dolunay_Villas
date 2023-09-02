using Entity.Models.RealEstateManagement.HeatingOptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Concrete.EntityFramework.Config.RealEstateManagement.HeatingOptions
{
    public class HeatingOptionConfig : IEntityTypeConfiguration<HeatingOption>
    {
        public void Configure(EntityTypeBuilder<HeatingOption> builder)
        {
            builder.HasData(
                new HeatingOption
                {
                    Id = 1,
                    Title_Tr = "Doğalgaz",
                    Title_En = "Natural Gas",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedByUser = "Default",
                    UpdatedByUser = "Default"
                },
                new HeatingOption
                {
                    Id = 2,
                    Title_Tr = "Klima",
                    Title_En = "Air Conditioner",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedByUser = "Default",
                    UpdatedByUser = "Default"
                },
                new HeatingOption
                {
                    Id = 3,
                    Title_Tr = "Soba",
                    Title_En = "Stove",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedByUser = "Default",
                    UpdatedByUser = "Default"
                },
                new HeatingOption
                {
                    Id = 4,
                    Title_Tr = "Şömine",
                    Title_En = "Fire Place",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedByUser = "Default",
                    UpdatedByUser = "Default"
                },
                new HeatingOption
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
