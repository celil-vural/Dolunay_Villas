using Entity.Models.RealEstateManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Concrete.EntityFramework.Config
{
    public class LocationTypesConfig : IEntityTypeConfiguration<LocationType>
    {
        public void Configure(EntityTypeBuilder<LocationType> builder)
        {
            builder.HasData(
                new LocationType
                {
                    Id = 1,
                    LocationTypeName = "Yer",
                    CreatedByUser = "Default"
                },
                new LocationType
                {
                    Id = 2,
                    LocationTypeName = "İşletme",
                    CreatedByUser = "Default"
                },
                new LocationType
                {
                    Id = 3,
                    LocationTypeName = "Eğlence",
                    CreatedByUser = "Default"
                }
            );
        }
    }
}
