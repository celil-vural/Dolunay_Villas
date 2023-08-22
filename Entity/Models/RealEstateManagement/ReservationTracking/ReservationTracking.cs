using Entity.Contracts;
using Entity.Models.Reservation;

namespace Entity.Models.RealEstateManagement.ReservationTracking
{
    public class ReservationTrackingForVilla : IEntity
    {
        public int Id { get; set; }
        public string AspNetUserId { get; set; } = string.Empty;
        public string CaregiverNameSurname { get; set; } = string.Empty;
        public string CaregiverPhoneNumber { get; set; } = string.Empty;
        public int ReservationTrackingAreaId { get; set; }
        public string TrackedPlaceName { get; set; } = string.Empty;
        public string OriginalNameOfTheVilla { get; set; } = string.Empty;
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public AspNetUser User { get; set; } = new();
        public ReservationTrackingArea ReservationTrackingArea { get; set; } = new();
    }
}
