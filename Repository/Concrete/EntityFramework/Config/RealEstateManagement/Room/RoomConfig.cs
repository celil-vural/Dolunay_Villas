using Entity.Models.RealEstateManagement.Room;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Concrete.EntityFramework.Config.RealEstateManagement.Room
{
    public class RoomConfig : IEntityTypeConfiguration<Rooms>
    {
        public void Configure(EntityTypeBuilder<Rooms> builder)
        {
            builder.HasData(
                new Rooms
                {
                    Id = 1,
                    Title_Tr = "1. Yatak Odası",
                    Title_En = "1. Bedroom",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedByUser = "Default",
                },
                new Rooms
                {
                    Id = 2,
                    Title_Tr = "2. Yatak Odası",
                    Title_En = "2. Bedroom",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedByUser = "Default",
                },
                new Rooms
                {
                    Id = 3,
                    Title_Tr = "3. Yatak Odası",
                    Title_En = "3. Bedroom",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedByUser = "Default",
                },
                new Rooms
                {
                    Id = 4,
                    Title_Tr = "4. Yatak Odası",
                    Title_En = "4. Bedroom",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedByUser = "Default",
                },
                new Rooms
                {
                    Id = 5,
                    Title_Tr = "Açık Mutfak",
                    Title_En = "Open Kitchen",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedByUser = "Default",
                },
                new Rooms
                {
                    Id = 6,
                    Title_Tr = "Mutfak",
                    Title_En = "Kitchen",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedByUser = "Default",
                },
                new Rooms
                {
                    Id = 7,
                    Title_Tr = "Salon",
                    Title_En = "Saloon",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedByUser = "Default",
                }
            );
        }
    }
}
