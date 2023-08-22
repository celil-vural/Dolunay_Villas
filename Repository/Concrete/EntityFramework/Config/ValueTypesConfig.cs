using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ValueType = Entity.Models.RealEstateManagement.ValueType.ValueType;

namespace Repository.Concrete.EntityFramework.Config
{
    public class ValueTypesConfig : IEntityTypeConfiguration<ValueType>
    {
        public void Configure(EntityTypeBuilder<ValueType> builder)
        {
            builder.HasData(
                new ValueType
                {
                    Id = 1,
                    Name = "Yes/No"
                },
                new ValueType
                {
                    Id = 2,
                    Name = "Letter"
                },
                new ValueType
                {
                    Id = 3,
                    Name = "Numeric"
                },
                new ValueType
                {
                    Id = 4,
                    Name = "Multiple Selection"
                },
                new ValueType
                {
                    Id = 5,
                    Name = "One choice"
                }
            );
        }
    }
}
