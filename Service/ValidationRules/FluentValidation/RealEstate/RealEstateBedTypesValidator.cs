using Entity.Dtos.RealEstateManagement.BedTypes;
using FluentValidation;

namespace Service.ValidationRules.FluentValidation.RealEstate
{
    public class RealEstateBedTypesValidator : AbstractValidator<BedTypesDto>
    {
        public RealEstateBedTypesValidator()
        {
            RuleFor(x => x.Title_Tr).NotEmpty().WithMessage("Name tr is required.");
            RuleFor(x => x.Title_En).NotEmpty().WithMessage("Name en is required.");
            RuleFor(x => x.ItemTypeKey).NotEmpty().WithMessage("Item type is required.");
            RuleFor(x => x.ValueTypeKey).NotEmpty().WithMessage("Value type is required.");
            RuleFor(dto => dto.FontAwesomeIcon).NotEmpty().When(dto => dto.LocalIconId == null).WithMessage("Icon is required when LocalIconId is not provided.");
            RuleFor(dto => dto.LocalIconId).NotEmpty().When(dto => !string.IsNullOrEmpty(dto.FontAwesomeIcon)).WithMessage("Icon is required.");
        }
    }
}
