using Entity.Dtos.RealEstateManagement.Highlights;
using FluentValidation;

namespace Service.ValidationRules.FluentValidation.RealEstate.Highlights
{
    public class RealEstateHighlightsUpdateValidatior : AbstractValidator<HighlightsDtoForUpdate>
    {
        public RealEstateHighlightsUpdateValidatior()
        {
            RuleFor(x => x.Title_Tr).NotEmpty().WithMessage("Name tr is required.");
            RuleFor(x => x.Title_En).NotEmpty().WithMessage("Name en is required.");
            RuleFor(x => x.UpdatedByUser).NotEmpty().WithMessage("Update by user must not empty.Please log out of the system and log in again.");
        }
    }
}
