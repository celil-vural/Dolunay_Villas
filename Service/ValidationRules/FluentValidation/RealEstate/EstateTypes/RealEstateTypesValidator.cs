using Entity.Dtos.RealEstateManagement.EstateTypes;
using FluentValidation;

namespace Service.ValidationRules.FluentValidation.RealEstate.EstateTypes
{
    public class RealEstateTypesValidator : AbstractValidator<EstateTypesDto>
    {
        public RealEstateTypesValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.");
            RuleFor(x => x.ShowCase).NotEmpty().WithMessage("Showcase is required.");
            RuleFor(x => x.Photo).NotEmpty().WithMessage("Photo is required.");
            RuleFor(x => x.CreatedByUser).NotEmpty().WithMessage("Create by user must not empty.Please log out of the system and log in again. ");
            RuleFor(x => x.UpdatedByUser).NotEmpty().WithMessage("Update by user must not empty.Please log out of the system and log in again. ");
        }
    }
}
