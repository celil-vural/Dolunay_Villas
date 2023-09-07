using Entity.Dtos.Villas;
using FluentValidation;

namespace Service.ValidationRules.FluentValidation.Villa
{
    public class VillaValidator : AbstractValidator<VillaDto>
    {
        public VillaValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Name must be less than 50 characters.");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Name must be more than 3 characters.");
            RuleFor(x => x.CreatedByUser).NotEmpty().WithMessage("Create by user must not empty.Please log out of the system and log in again. ");
            RuleFor(x => x.UpdatedByUser).NotEmpty().WithMessage("Update by user must not empty.Please log out of the system and log in again. ");
        }
    }
}
