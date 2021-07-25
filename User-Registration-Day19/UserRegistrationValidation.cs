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

        #region UC-2
        public static string Regex_lastName = "^[A-Z][A-Za-z]{2,}$";

        public static bool validatelastName(string Lastname)
        {
            Console.WriteLine("Last Name Validation is T/F :");
            return Regex.IsMatch(Lastname, Regex_lastName);
        }
        #endregion UC-2

        #region UC-3
        public static string Regex_Email = "^[A-Z0-9a-z]{1,}([.#$^+-][A-Za-z0-9]+)*[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";

        public static bool validateEmail(string email)
        {
            Console.WriteLine("Email Id Validation is T/F :");
            return Regex.IsMatch(email, Regex_Email);
        }
        #endregion UC-3
    }
}
