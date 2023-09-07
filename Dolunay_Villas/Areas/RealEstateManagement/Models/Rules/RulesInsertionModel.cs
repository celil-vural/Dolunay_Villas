using Entity.Dtos.Icon;
using Entity.Dtos.RealEstateManagement.Rule;

namespace Dolunay_Villas.Areas.RealEstateManagement.Models.Rules
{
    public class RulesInsertionModel
    {
        public RulesDtoForInsertion DtoForInsertion { get; set; } = new();
        public IEnumerable<IconDto>? LocalIcons { get; set; } = new HashSet<IconDto>();
        public HashSet<string>? FontAwesomeIcons { get; set; } = new();
    }
}
