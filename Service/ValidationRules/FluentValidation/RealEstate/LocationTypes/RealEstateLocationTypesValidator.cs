using Entity.Dtos.RealEstateManagement.LocationTypes;
using FluentValidation;

namespace Service.ValidationRules.FluentValidation.RealEstate.LocationTypes
{
    public class RealEstateLocationTypesValidator : AbstractValidator<LocationTypeDto>
    {
        public RealEstateLocationTypesValidator()
        {
            RuleFor(x => x.LocationTypeName).NotEmpty().WithMessage("Type Name is required");
            RuleFor(x => x.CreatedByUser).NotEmpty().WithMessage("Create by user must not empty.Please log out of the system and log in again. ");
            RuleFor(x => x.UpdatedByUser).NotEmpty().WithMessage("Update by user must not empty.Please log out of the system and log in again. ");
        }
    }
}
