namespace Entity.Dtos.Rules
{
    public record RulesDtoForInsertion : RulesDto
    {
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; init; } = DateTime.UtcNow;
    }
}
