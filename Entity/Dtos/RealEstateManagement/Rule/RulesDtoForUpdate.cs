namespace Entity.Dtos.RealEstateManagement.Rule
{
    public record RulesDtoForUpdate : RulesDto
    {
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    }
}
