using Entity.Models.RealEstateManagement.RoomsForAddVillas;
using Microsoft.EntityFrameworkCore;

namespace Repository.Concrete.EntityFramework.Config.RealEstateManagement.RoomsForAddVillaConifg
{
    public class RoomsForAddVillaConfig : IEntityTypeConfiguration<RoomsForAddVilla>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<RoomsForAddVilla> builder)
        {
            builder.HasKey(r => r.Id);
            builder.HasOne(r => r.Villa)
            .WithMany()
            .HasForeignKey(r => r.VillaId)
            .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(r => r.Room)
            .WithMany()
            .HasForeignKey(r => r.RoomId)
            .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(r => r.BedType)
            .WithMany()
            .HasForeignKey(r => r.BedTypeId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
