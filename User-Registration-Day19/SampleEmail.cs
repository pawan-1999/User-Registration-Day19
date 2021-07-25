using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Day19
{
    class SampleEmail
    {
        public static string Regex_Email = "^[A-Za-z]+([-.+#^*][0-9]+)?[0-9]*[@][A-Za-z0-9]+[.][A-Za-z]{2,}([.][a-zA-Z]{2,})?$";

        public static bool validateEmail(string email)
        {
            Console.WriteLine("Email Id Validation is T/F :");
            return Regex.IsMatch(email, Regex_Email);
        }
    }
}
