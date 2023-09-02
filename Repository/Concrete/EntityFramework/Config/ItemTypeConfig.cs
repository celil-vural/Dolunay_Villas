using Entity.Models.RealEstateManagement.ItemType;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Concrete.EntityFramework.Config
{
    public class ItemTypeConfig : IEntityTypeConfiguration<ItemType>
    {
        public void Configure(EntityTypeBuilder<ItemType> builder)
        {
            builder.HasData(
                new ItemType
                {
                    Id = 1,
                    Name = "Structural Product"
                },
                new ItemType
                {
                    Id = 2,
                    Name = "Built-in Furniture"
                },
                new ItemType
                {
                    Id = 3,
                    Name = "Electronic Product"
                },
                new ItemType
                {
                    Id = 4,
                    Name = "Bed"
                },
                new ItemType
                {
                    Id = 5,
                    Name = "Furniture"
                },
                new ItemType
                {
                    Id = 6,
                    Name = "Floor"
                }
            );
        }
    }
}
