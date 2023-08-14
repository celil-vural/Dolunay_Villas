using Entity.Contracts;

namespace Entity.Models
{
    public class Log : IEntity
    {
        public int Id { get; set; }
        public string Detail { get; set; } = string.Empty;
        public string Audit { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedByUser { get; set; } = string.Empty;
        public string CreatedByUserEmail { get; set; } = string.Empty;
        public string UpdatedByUser { get; set; } = string.Empty;
    }
}
