using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Login_Registration_ASP_NET_CORE_RAZOR.Model
{
    public class DORValidate:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            DateTime currentDate = DateTime.Now;
            if (Convert.ToDateTime(value) < currentDate)
            {
                return new ValidationResult("REgistration date cannot be past date");
            }
            return ValidationResult.Success;
        }
        
    }
}
