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
            var result = Regex.IsMatch(email, Regex_Email);

            try
            {
                if (result == false)
                {
                    if (email == string.Empty)
                    {

                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE,
                                "Enter Email-Id it should not be null.");
                    }
                    else if (email == " ")
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_MESSAGE,
                                "Enter Email-Id it should not be blank.");
                    }
                    else if (result == false)
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_INPUT,
                                "Enter valid user Email-Id it should be like abc+100@gmail.com");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return Regex.IsMatch(email, Regex_Email);
        }
    }
}
