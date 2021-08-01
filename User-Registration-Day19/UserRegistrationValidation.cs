using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Day19
{
    class UserRegistrationValidation
    {
        #region UC-1

        [Required(ErrorMessage = "User {0} is required")]
        [RegularExpression("^[A-Z][A-Za-z]{2,}$", ErrorMessage = "Invalid input minimum 1 upper case and 2 chars are required")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }
        
        #endregion UC-1

        #region UC-2

        [Required(ErrorMessage = "User {0} is required")]
        [RegularExpression("^[A-Z][A-Za-z]{2,}$", ErrorMessage = "Invalid Input minimum 1 upper case and 2 chars are required")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        #endregion UC-2

        #region UC-3
        [Required(ErrorMessage = "User {0} is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email_Id { get; set; }
        #endregion UC-3

        #region UC-4
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }
        #endregion UC-4

        #region UC 5-8
        [Required(ErrorMessage = "User {0} is required")]
        [RegularExpression("((?=.*[0-9])(?=.*[A-Z])(?=.*[@#$%]).[A-Z0-9a-z@#$%]{8,})", ErrorMessage = "Invalid input minimum 1 upper case, one special char, one nummeric value and 8 chars are required")]
        [DataType(DataType.Text)]
        public string Password { get; set; }
        #endregion UC 5-8
    }
}