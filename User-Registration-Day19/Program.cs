using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace User_Registration_Day19
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRegistrationValidation obj = new UserRegistrationValidation();

            Console.WriteLine("Checking Validation of User Input : ");

            #region UC-1
            Console.WriteLine("Enter the First Name :");
            string firstName = Console.ReadLine();
            obj.FirstName = firstName;
            #endregion UC-1

            #region UC-2
            Console.WriteLine("Enter the Last Name : ");
            string lastName = Console.ReadLine();
            obj.LastName = lastName;
            #endregion UC-2

            #region UC-3 
            Console.WriteLine("Enter the Email Id : ");
            string email_Id = Console.ReadLine();
            obj.Email_Id = email_Id;
            #endregion UC-3 

            #region UC-4
            Console.WriteLine("Enter the Phone No : ");
            string phoneNo = Console.ReadLine();
            obj.PhoneNumber = phoneNo;
            #endregion UC-4

            #region UC 5-8
            Console.WriteLine("Enter the Password : ");
            string password = Console.ReadLine();
            obj.Password = password;
            #endregion UC 5-8

            #region UC-9
            SampleEmail obj1 = new SampleEmail(); 
            Console.WriteLine("Enter Email Id : ");
            string email = Console.ReadLine();
            obj1.Email = email;
            #endregion UC-9

            ValidationContext context = new ValidationContext(obj, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(obj, context, results, true);

            if (!valid)
            {
                foreach (ValidationResult TotalResult in results)
                {
                    Console.WriteLine("Error Msg : {0}{1}", TotalResult.ErrorMessage, Environment.NewLine);
                }
            }

        }
    }
}
