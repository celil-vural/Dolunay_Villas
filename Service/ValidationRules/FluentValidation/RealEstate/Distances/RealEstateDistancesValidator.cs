using Entity.Dtos.RealEstateManagement.Distances;
using FluentValidation;

namespace Service.ValidationRules.FluentValidation.RealEstate.Distances
{
    public class RealEstateDistancesValidator : AbstractValidator<DistancesDto>
    {
        public RealEstateDistancesValidator()
        {
            RuleFor(x => x.Title_Tr).NotEmpty().WithMessage("Title tr is required");
            RuleFor(x => x.Title_En).NotEmpty().WithMessage("Title en is required");
            RuleFor(x => x.LocalIconId).GreaterThanOrEqualTo(0).When(dto => string.IsNullOrEmpty(dto.FontAwesomeIcon)).WithMessage("icon is required.");
            RuleFor(x => x.FontAwesomeIcon).NotEmpty().When(dto => dto.LocalIconId == null).WithMessage("icon is required.");
            RuleFor(x => x.FontAwesomeIcon).Empty().When(dto => dto.LocalIconId.HasValue).WithMessage("Fontawesome and LocalIcon must not be full at the same time.");
            RuleFor(x => x.LocalIconId).Null().When(dto => !string.IsNullOrEmpty(dto.FontAwesomeIcon)).WithMessage("Fontawesome and LocalIcon must not be full at the same time.");
            RuleFor(x => x.CreatedByUser).NotEmpty().WithMessage("Create by user must not empty.Please log out of the system and log in again. ");
            RuleFor(x => x.UpdatedByUser).NotEmpty().WithMessage("Update by user must not empty.Please log out of the system and log in again. ");
            //RuleForEach(x => x.Distances).SetValidator(new RealEstateDistanceValidator());
        }
    }
}
