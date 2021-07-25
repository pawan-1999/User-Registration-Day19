using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Day19
{
    class UserRegistrationValidation
    {
        #region UC-1
        public static string Regex_firstName = "^[A-Z][A-Za-z]{2,}$";

        public static bool validatefisrtName(string Firstname)
        {
            Console.WriteLine("First Name Validation is T/F :");
            return Regex.IsMatch(Firstname, Regex_firstName);
        }
        #endregion UC-1
    }
}
