using Entity.Contracts;

namespace Entity.Models.Reservation
{
    public class ReservationTrackingArea : IEntity
    {
        public int Id { get; set; }
        public string AreaName { get; set; } = string.Empty;
        public string AreaDescription { get; set; } = string.Empty;
        public string AreaNote { get; set; } = string.Empty;
        public string AreaContents { get; set; } = string.Empty;
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
