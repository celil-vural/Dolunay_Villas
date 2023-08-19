using Entity.Contracts;

namespace Entity.Models.RealEstateManagement
{
    public class RealEstate : IEntity
    {
        public int Id { get; set; }
        public string PropertyTitle { get; set; } = string.Empty;
        public string PropertyDescription { get; set; } = string.Empty;
        public string AnnouncementNote { get; set; } = string.Empty;
        public string Contents { get; set; } = string.Empty;
        public int ReservationTrackingId { get; set; }
        public int RealEstateTypeId { get; set; }

        #region Özellikler
        public int RegionId { get; set; }
        public string RibbonText { get; set; } = string.Empty;
        public string RibbonText2 { get; set; } = string.Empty;
        public int RoomsCount { get; set; }//0-15
        public int BedroomsCount { get; set; }//1-15
        public int BedsCount { get; set; }//1-15
        public int Capacity { get; set; }//1-30
        public int HeatingOptionId { get; set; }
        public int BathroomCount { get; set; }//1-10
        public TimeSpan CheckinTime { get; set; }//30 ar dakka arayla 7-20.30
        public TimeSpan CheckoutTime { get; set; }//30 ar dakka arayla 7-20.30
        public int FloorCount { get; set; }//1-15
        public bool IsAirConditioned { get; set; }//Klima 
        public bool IsCarPark { get; set; }//Otopark
        public bool IsInternet { get; set; }//İnternet
        public string AspNetUsersId { get; set; } = string.Empty;
        #endregion
        #region Yüzme Havuzu
        public string SwimmingPool { get; set; } = string.Empty;//Ortak,Özel,Yok
        public string? SwimmingPoolType { get; set; } = string.Empty;//Kare,Oval,Dikdörtgen
        public bool IsFullyProtectedPool { get; set; } = false;//Tam Korunaklı
        public string? PoolDepth { get; set; } = string.Empty;//1.5m,2m,2.5m
        public string? PoolLength { get; set; } = string.Empty;//10m,15m,20m
        public string? PoolWidth { get; set; } = string.Empty;//5m,10m,15m
        #endregion
        #region Kapalı Havuz
        public bool IsIndoorPool { get; set; } = false;//Kapalı Havuz varmı/yokmu
        public string? IndoorPoolDepth { get; set; } = string.Empty;//1.5m,2m,2.5m
        public string? IndoorPoolLength { get; set; } = string.Empty;//10m,15m,20m
        public string? IndoorPoolWidth { get; set; } = string.Empty;//5m,10m,15m
        #endregion
        #region Çocuk Havuzu
        public bool IsKiddiePool { get; set; } = false;//Çocuk Havuzu varmı/yokmu
        public string? KiddiePoolDepth { get; set; } = string.Empty;//1.5m,2m,2.5m
        public string? KiddiePoolLength { get; set; } = string.Empty;//10m,15m,20m
        public string? KiddiePoolWidth { get; set; } = string.Empty;//5m,10m,15m
        #endregion
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }


    }
}
