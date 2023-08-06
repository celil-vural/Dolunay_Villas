namespace Entity.Enums
{
    public enum Powers
    {
        CanManageUsers,
        CanManageRoles,
        CanManageVillas,
        CanManageDashboard,
        CanManagerealEstateHeatingOptions,
        CanManageRealEstateRules,
        CanManageRealEstateRoomFeatures,
        CanManageRealEstateRooms
    }
    public static class PowersDictionary
    {
        public static readonly Dictionary<Powers, string> claimNames = new Dictionary<Powers, string>
        {
            { Powers.CanManageRoles, "CanManageRoles" },
            { Powers.CanManageUsers, "CanManageUsers" },
            { Powers.CanManageVillas, "CanManageVillas" },
            { Powers.CanManageDashboard, "CanManageDashboard" },
            { Powers.CanManagerealEstateHeatingOptions, "CanManagerealEstateHeatingOptions" },
            { Powers.CanManageRealEstateRules, "CanManageRealEstateRules" },
            { Powers.CanManageRealEstateRoomFeatures, "CanManageRealEstateRoomFeatures" },
            { Powers.CanManageRealEstateRooms, "CanManageRealEstateRooms" },
        };
    }
}
