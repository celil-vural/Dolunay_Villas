using Entity.Dtos.Icon;
using Entity.Dtos.RealEstateManagement.Rules;

namespace Dolunay_Villas.Areas.RealEstateManagement.Models.Rules
{
    public class RulesUpdateModel
    {
        public RulesDtoForUpdate RulesDtoForUpdate { get; set; } = new();
        public IEnumerable<IconDto>? LocalIcons { get; set; }
        public HashSet<string>? FontAwesomeIcons { get; set; }
    }
}
