using Entity.Dtos.RealEstateManagement.DistanceRuler;
using FluentValidation;

namespace Service.ValidationRules.FluentValidation.RealEstate.DistanceRuler
{
    public class RealEstateDistanceRulerValidator : AbstractValidator<DistanceRulerDto>
    {
        public RealEstateDistanceRulerValidator()
        {
            RuleFor(x => x.PlaceName).NotEmpty().WithMessage("Place name is required");
            RuleFor(x => x.LocationTypeId).NotEmpty().WithMessage("Location Type is required");
            RuleFor(x => x.RegionId).NotEmpty().WithMessage("Region is required");
            RuleFor(x => x.DistanceId).NotEmpty().WithMessage("Distance is required");
            RuleFor(x => x.Coordinates).NotEmpty().WithMessage("Coordinates is required");
            RuleFor(x => x.CreatedByUser).NotEmpty().WithMessage("Create by user must not empty.Please log out of the system and log in again. ");
            RuleFor(x => x.UpdatedByUser).NotEmpty().WithMessage("Update by user must not empty.Please log out of the system and log in again. ");
            //RuleForEach(x => x.Distances).SetValidator(new RealEstateDistanceValidator());
        }
    }
}
