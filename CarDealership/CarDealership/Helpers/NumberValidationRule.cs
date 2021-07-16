using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CarDealership.Helpers
{
    class NumberValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            int result = 0;
            bool canConvert = int.TryParse(value as string, out result);
            return new ValidationResult(canConvert, "This field must not contain letters");
        }
    }
}
