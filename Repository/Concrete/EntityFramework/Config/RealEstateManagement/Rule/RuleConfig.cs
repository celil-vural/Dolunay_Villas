using Entity.Models.RealEstateManagement.Rule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Concrete.EntityFramework.Config.RealEstateManagement.Rule
{
    public class RuleConfig : IEntityTypeConfiguration<Rules>
    {
        public void Configure(EntityTypeBuilder<Rules> builder)
        {
            builder.HasData(
                new Rules
                {
                    Id = 1,
                    Title_Tr = "Bebeklere Uygun (0-2)",
                    Title_En = "Suitable for Babies (0-2)",
                    LocalIconId = null,
                    FontAwesomeIcon = "fa-solid fa-baby",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedByUser = "Default",
                },
                new Rules
                {
                    Id = 2,
                    Title_Tr = "Çocuklara Uygun (2-12)",
                    Title_En = "Suitable for Children (2-12)",
                    LocalIconId = null,
                    FontAwesomeIcon = "fa-solid fa-children",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedByUser = "Default",
                },
                new Rules
                {
                    Id = 3,
                    Title_Tr = "Sigara İçilmez",
                    Title_En = "No Smoking",
                    LocalIconId = null,
                    FontAwesomeIcon = "fa-solid fa-ban-smoking",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedByUser = "Default",
                }
            );
        }
    }
}
