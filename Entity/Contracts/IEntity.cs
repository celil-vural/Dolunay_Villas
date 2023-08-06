namespace Entity.Contracts
{
    public interface IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedByUser { get; set; }
        public string UpdatedByUser { get; set; }
    }
}
