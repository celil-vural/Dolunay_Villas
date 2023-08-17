﻿using Entity.Dtos.RealEstateManagement.HeatingOptions;
using FluentValidation;

namespace Service.ValidationRules.FluentValidation.RealEstate.HeatingOptions
{
    public class RealEstateHeatingOptionsInsertionValidation : AbstractValidator<HeatingOptionsDtoForInsertions>
    {
        public RealEstateHeatingOptionsInsertionValidation()
        {
            RuleFor(x => x.Title_Tr).NotEmpty().WithMessage("Name tr is required.");
            RuleFor(x => x.Title_En).NotEmpty().WithMessage("Name en is required.");
            RuleFor(x => x.CreatedByUser).NotEmpty().WithMessage("Create by user must not empty.Please log out of the system and log in again. ");
        }
    }
}
