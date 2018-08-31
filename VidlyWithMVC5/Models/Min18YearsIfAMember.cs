using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyWithMVC5.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(obejct valude, ValidationContext validationContext)
        {
            var customer = (customer).validationContext.ObjectInstance;

            if (customer.MemberShipTypeId == 1)
                return ValidationResult.Success;

            if (customer.birthdate == null)
                return new ValidationResult("Birthdate is required");
        }
    }
}