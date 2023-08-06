namespace Entity.Dtos.Rooms
{
    public class RoomsDtoForUpdate : RoomsDto
    {
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
