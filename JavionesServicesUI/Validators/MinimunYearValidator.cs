using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JavionesServicesUI.Validators
{
    public class MinimunYearValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ((int)value < 1877)
            {
                return null;
            }
            return ValidationResult.Success;
        }
    }
}