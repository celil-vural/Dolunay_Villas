using Entity.Dtos.RealEstateManagement.ItemTypes;
using FluentValidation;

namespace Service.ValidationRules.FluentValidation.RealEstate.ItemTypes
{
    public class RealEstateItemTypesValidator : AbstractValidator<ItemTypeDto>
    {
        public RealEstateItemTypesValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name tr is required.");
            RuleFor(x => x.CreatedByUser).NotEmpty().WithMessage("Create by user must not empty.Please log out of the system and log in again.");
            RuleFor(x => x.UpdatedByUser).NotEmpty().WithMessage("Update by user must not empty.Please log out of the system and log in again.");
        }
    }
}
