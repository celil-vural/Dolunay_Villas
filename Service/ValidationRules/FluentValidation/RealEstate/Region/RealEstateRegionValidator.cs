using Entity.Dtos.RealEstateManagement.Region;
using FluentValidation;

namespace Service.ValidationRules.FluentValidation.RealEstate.Region
{
    public class RealEstateRegionValidator : AbstractValidator<RegionDtoForInsertion>
    {
        public RealEstateRegionValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.");
            RuleFor(x => x.CreatedByUser).NotEmpty().WithMessage("Create by user must not empty.Please log out of the system and log in again. ");
            RuleFor(x => x.UpdatedByUser).NotEmpty().WithMessage("Update by user must not empty.Please log out of the system and log in again. ");
        }
    }
}
