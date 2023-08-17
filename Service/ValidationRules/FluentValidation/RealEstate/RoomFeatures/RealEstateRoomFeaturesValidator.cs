using Entity.Dtos.RealEstateManagement.RoomFeatures;
using FluentValidation;

namespace Service.ValidationRules.FluentValidation.RealEstate.RoomFeatures
{
    public class RealEstateRoomFeaturesValidator : AbstractValidator<RoomFeaturesDto>
    {
        public RealEstateRoomFeaturesValidator()
        {
            RuleFor(x => x.Title_Tr).NotEmpty().WithMessage("Name tr is required.");
            RuleFor(x => x.Title_En).NotEmpty().WithMessage("Name en is required.");
            RuleFor(x => x.CreatedByUser).NotEmpty().WithMessage("Create by user must not empty.Please log out of the system and log in again. ");
            RuleFor(x => x.UpdatedByUser).NotEmpty().WithMessage("Update by user must not empty.Please log out of the system and log in again. ");
        }
    }
}
