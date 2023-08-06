namespace Entity.Dtos.Rules
{
    public record RulesDtoForInsertion : RulesDto
    {
        public DateTime CreatedAt { get; init; } = DateTime.Now;
        public DateTime UpdatedAt { get; init; } = DateTime.Now;
    }
}
