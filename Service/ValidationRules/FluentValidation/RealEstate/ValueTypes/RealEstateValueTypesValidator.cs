using Entity.Dtos.RealEstateManagement.ValueTypes;
using FluentValidation;

namespace Service.ValidationRules.FluentValidation.RealEstate.ValueTypes
{
    public class RealEstateValueTypesValidator : AbstractValidator<ValueTypeDto>
    {
        public RealEstateValueTypesValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.");
            RuleFor(x => x.CreatedByUser).NotEmpty().WithMessage("Create by user must not empty.Please log out of the system and log in again. ");
            RuleFor(x => x.UpdatedByUser).NotEmpty().WithMessage("Update by user must not empty.Please log out of the system and log in again. ");
        }
    }
}
