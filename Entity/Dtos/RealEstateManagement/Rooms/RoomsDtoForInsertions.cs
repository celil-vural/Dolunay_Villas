namespace Entity.Dtos.RealEstateManagement.Rooms
{
    public class RoomsDtoForInsertions : RoomsDto
    {
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
    }
}
