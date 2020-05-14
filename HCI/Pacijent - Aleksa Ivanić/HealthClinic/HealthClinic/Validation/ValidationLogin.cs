using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HealthClinic.Validation
{

    class StringToDoubleValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            try
            {
                var s = value as String;
                return new ValidationResult(true, null);
            }
            catch
            {
                return new ValidationResult(false, "Unknown error occured.");
            }
        }
    }

    public class ValidationLogin : ValidationRule

    {
        public int Min
        {
            get;
            set;
        }

        public int Max
        {
            get;
            set;
        }

        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
           
                String s = (String)value;
                int d = s.Length;
                if (d < Min) return new ValidationResult(false, "Value too small.");
                if (d > Max) return new ValidationResult(false, "Value too large.");
                return new ValidationResult(true, null);
            
        }
    }
}
