using Entity.Contracts;

namespace Entity.Models
{
    public class Rules : IEntity
    {
        public int Id { get; set; }
        public string Rule_Title_Tr { get; set; } = string.Empty;
        public string Rule_Title_En { get; set; } = string.Empty;
        public string IconString { get; set; } = string.Empty;
    }
}