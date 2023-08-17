﻿using Entity.Dtos.RealEstateManagement.RealEstateFeatures;
using FluentValidation;

namespace Service.ValidationRules.FluentValidation.RealEstate.EstateFeatures
{
    public class RealEstateFeaturesUpdateValidator : AbstractValidator<RealEstateFeaturesDtoForUpdate>
    {
        public RealEstateFeaturesUpdateValidator()
        {
            RuleFor(x => x.Title_Tr).NotEmpty().WithMessage("Name tr is required.");
            RuleFor(x => x.Title_En).NotEmpty().WithMessage("Name en is required.");
            RuleFor(x => x.LocalIconId).GreaterThanOrEqualTo(0).When(
                dto => string.IsNullOrEmpty(dto.FontAwesomeIcon)).WithMessage("icon is required.");
            RuleFor(x => x.FontAwesomeIcon).NotEmpty().When(dto => dto.LocalIconId == null).WithMessage("icon is required.");
            RuleFor(x => x.FontAwesomeIcon).Empty().When(dto => dto.LocalIconId.HasValue).WithMessage("Fontawesome and LocalIcon must not be full at the same time.");
            RuleFor(x => x.LocalIconId).Null().When(dto => !string.IsNullOrEmpty(dto.FontAwesomeIcon)).WithMessage("Fontawesome and LocalIcon must not be full at the same time.");
            RuleFor(x => x.UpdatedByUser).NotEmpty().WithMessage("Update by user must not empty.Please log out of the system and log in again. ");
        }
    }
}
