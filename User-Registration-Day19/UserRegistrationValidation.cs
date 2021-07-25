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

        #region UC-4
        public static string Regex_ph_No = "^([1-9]{1,2}[ ])?[6-9][0-9]{9}$";

        public static bool validateph_No(string Ph_no)
        {
            Console.WriteLine("Phone No Validation is T/F :");
            return Regex.IsMatch(Ph_no, Regex_ph_No);
        }
        #endregion UC-4

        #region UC-8
        public static string Regex_password = "((?=.*[0-9])(?=.*[A-Z])(?=.*[@#$%]).[A-Z0-9a-z@#$%]{8,})";

        public static bool validatepassword(string Password)
        {
            Console.WriteLine("Password Validation is T/F :");
            return Regex.IsMatch(Password, Regex_password);
        }
<<<<<<<<< Temporary merge branch 1
        #endregion UC-6
=========
        #endregion UC-7
>>>>>>>>> Temporary merge branch 2

    }
}