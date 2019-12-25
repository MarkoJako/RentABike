using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentABike.Models
{
    public class AtLeast16YearsOld : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            var age = DateTime.Today.Year - customer.Birthdate.Year;

            if(age>16)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Customer should be at least 16 years old");
            }

        }

        
    }
}