using Entity.Contracts;

namespace Entity.Models
{
    public class Log : IEntity
    {
        public int Id { get; set; }
        public string Detail { get; set; }
        public string Audit { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedByUser { get; set; }
        public string CreatedByUserEmail { get; set; }
        public string UpdatedByUser { get; set; }
    }
}
