namespace Entity.Enums
{
    public enum Powers
    {
        CanManageUsers,
        CanManageRoles,
        CanManageVillas,
        CanManageDashboard
    }
    public static class PowersDictionary
    {
        public static readonly Dictionary<Powers, string> claimNames = new Dictionary<Powers, string>
        {
            { Powers.CanManageRoles, "CanManageRoles" },
            { Powers.CanManageUsers, "CanManageUsers" },
            { Powers.CanManageVillas, "CanManageVillas" },
            { Powers.CanManageDashboard, "CanManageDashboard" }
        };
    }
}
