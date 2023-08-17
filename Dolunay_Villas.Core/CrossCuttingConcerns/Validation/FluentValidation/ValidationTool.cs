﻿using FluentValidation;

namespace Dolunay_Villas.Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public static class ValidationTool
    {
        public static void FluentValidate<T>(IValidator<T> validator, T entity)
        {
            var result = validator.Validate(entity);
            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    throw new ValidationException(error.ErrorMessage);
                }
            }
        }
    }
}
