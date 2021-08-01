using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace User_Registration_Day19
{
    class SampleEmail
    {
        #region UC-9
        [Required(ErrorMessage = "User {0} is required")]
        [RegularExpression("^[A-Za-z]+([-.+#^*][0-9]+)?[0-9]*[@][A-Za-z0-9]+[.][A-Za-z]{2,}([.][a-zA-Z]{2,})?$", ErrorMessage = "Invalid Input for Email Id")]
        [DataType(DataType.Text)]
        public string Email { get; set; }
        #endregion UC-9
    }
}
