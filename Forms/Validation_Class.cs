using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Restaurant_Project
{

    class Validation_Class
    {
        static Regex validate_emailaddress = email_validation();
        static Regex validate_name = name_validation();
        // regex function for email validation

        public static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
              + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
              + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        // regex function name validation
        public static Regex name_validation()
        {
            string pattern = @"[\p{L} ]+$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        public bool validattion(string name)
        {
            bool validate = true;

            if (validate_name.IsMatch(name) != true)
            {
               validate = false;
               
            }

                return validate;

        }
       
    
    }
}
