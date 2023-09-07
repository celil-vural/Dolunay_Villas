using Entity.Models;
using Entity.Models.RealEstateManagement.Highlights;
using Entity.Models.RealEstateManagement.RoomsForAddVillas;
using Entity.Models.RealEstateManagement.Rule;

namespace Entity.Dtos.RealEstateManagement.RealEstate
{
    public record RealEstateDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        #region Other
        public int Id { get; set; }
        public int VillaId { get; set; }
        public string PropertyTitle { get; set; } = string.Empty;
        public string PropertyDescription { get; set; } = string.Empty;
        public string AnnouncementNote { get; set; } = string.Empty;
        public string Contents { get; set; } = string.Empty;
        public int ReservationTrackingId { get; set; }
        public int RealEstateTypeId { get; set; }
        #endregion
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
        #region Mesafeler
        #endregion
        #region Features
        public ICollection<Entity.Models.RealEstateManagement.RealEstateFeatures.RealEstateFeatures> Features { get; set; } = new HashSet<Entity.Models.RealEstateManagement.RealEstateFeatures.RealEstateFeatures>();
        #endregion
        #region Highlights
        public ICollection<Highlight> Highlights { get; set; } = new HashSet<Highlight>();
        #endregion
        #region Rules
        public ICollection<Rules> Rules { get; set; } = new HashSet<Rules>();
        #endregion
        #region Fiyatlandırma
        public short DepositRate { get; set; }//0-100
        public short ForeignCurrency { get; set; }//0-3 1-Tl 2-Pound 3-Dollar 4-Euro
        public decimal ExchangeRate { get; set; }//  ForeignCurrency Tl ise 0
        public decimal EarningsRatio { get; set; }//Kazanç Oranı
        public string PriceNote { get; set; } = string.Empty;
        public string CalendarNote { get; set; } = string.Empty;
        #endregion
        #region Ekstra Ücretler
        public decimal DamageDeposit { get; set; }//Hasar Depozitosu
        public decimal CleaningFee { get; set; }//Temizlik Ücreti
        public decimal ElectricityWaterFee { get; set; } //Elektrik ve Su Ücreti
        #endregion
        #region Rooms
        public virtual ICollection<RoomsForAddVilla> Rooms { get; set; } = new List<RoomsForAddVilla>();
        #endregion
        #region Location
        public string Location { get; set; } = string.Empty;
        public string LocationNote { get; set; } = string.Empty;
        #endregion
        #region Create and Update
        public string CreatedByUser { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
        #endregion
        public virtual Villa Villa { get; set; } = new Villa();
    }
}
