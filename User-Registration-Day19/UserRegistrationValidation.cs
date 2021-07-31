using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Day19
{
    public class UserRegistrationValidation
    {
        #region UC-1
        public string Regex_firstName = "^[A-Z][A-Za-z]{2,}$";

        public  bool validatefisrtName(string Firstname)
        {
            var result = Regex.IsMatch(Firstname, Regex_firstName);
            try
            {
                if (result == false)
                {
                    if (Firstname == string.Empty)
                    {

                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE,
                                "Enter first name it should not be blank.");
                    }
                    else if (Firstname == " ")
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_MESSAGE,
                                "Enter first name it should not be blank.");
                    }
                    else if (result == false)
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_INPUT,
                                "Enter valid user name it should start with Capital letter.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return Regex.IsMatch(Firstname, Regex_firstName);
        }
        #endregion UC-1


        #region UC-2
        public static string Regex_lastName = "^[A-Z][A-Za-z]{2,}$";

        public  bool validatelastName(string Lastname)
        {
            var result = Regex.IsMatch(Lastname, Regex_lastName);
            try
            {
                if (result == false)
                {
                    if (Lastname == string.Empty)
                    {

                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE,
                                "Enter last name it should not be blank.");
                    }
                    else if (Lastname == " ")
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_MESSAGE,
                                "Enter last name it should not be blank.");
                    }
                    else if (result == false)
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_INPUT,
                                "Enter valid user last name it should start with Capital letter.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Regex.IsMatch(Lastname, Regex_lastName);
        }
        #endregion UC-2


        #region UC-3
        public static string Regex_Email = "^[A-Z0-9a-z]{1,}([.#$^+-][A-Za-z0-9]+)*[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";

        public  bool validateEmail(string email)
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
                                "Enter valid user Email-Id it should be like abc.glt123@gmail.com");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return Regex.IsMatch(email, Regex_Email);
        }
        #endregion UC-3


        #region UC-4
        public static string Regex_ph_No = "^([1-9]{1,2}[ ])?[6-9][0-9]{9}$";

        public  bool validatePh_No(string Ph_no)
        {
            var result = Regex.IsMatch(Ph_no, Regex_ph_No);
            try
            {
                if (result == false)
                {
                    if (Ph_no == string.Empty)
                    {

                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE,
                                "Enter Phone Number it should not be null.");
                    }
                    else if (Ph_no == " ")
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_MESSAGE,
                                "Enter Phone Number it should not be blank.");
                    }
                    else if (result == false)
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_INPUT,
                                "Enter valid user Phone Number it should follow with county code and space and 10 digits number");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return Regex.IsMatch(Ph_no, Regex_ph_No);
        }
        #endregion UC-4


        #region UC-8
        public static string Regex_password = "((?=.*[0-9])(?=.*[A-Z])(?=.*[@#$%]).[A-Z0-9a-z@#$%]{8,})";

        public  bool validatePassword(string Password)
        {
            var result = Regex.IsMatch(Password, Regex_password);

            try
            {
                if (result == false)
                {
                    if (Password == string.Empty)
                    {

                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE,
                                "Enter Password it should not be null.");
                    }
                    else if (Password == " ")
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_MESSAGE,
                                "Enter Password it should not be blank.");
                    }
                    else if (result == false)
                    {
                        throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_INPUT,
                                "Enter valid user Password It should Contain at least one upper case, one lower case, numeric value, special char and minimum 8 charcater ");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return Regex.IsMatch(Password, Regex_password);
        }
        #endregion UC-8
    }
}