using Entity.Models.RealEstateManagement.ItemType;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Concrete.EntityFramework.Config
{
    public class ItemTypesConfig : IEntityTypeConfiguration<ItemTypes>
    {
        public void Configure(EntityTypeBuilder<ItemTypes> builder)
        {
            builder.HasData(
                new ItemTypes
                {
                    Id = 1,
                    Name = "Structural Product"
                },
                new ItemTypes
                {
                    Id = 2,
                    Name = "Built-in Furniture"
                },
                new ItemTypes
                {
                    Id = 3,
                    Name = "Electronic Product"
                },
                new ItemTypes
                {
                    Id = 4,
                    Name = "Bed"
                },
                new ItemTypes
                {
                    Id = 5,
                    Name = "Furniture"
                },
                new ItemTypes
                {
                    Id = 6,
                    Name = "Floor"
                }
            );
        }
    }
}
