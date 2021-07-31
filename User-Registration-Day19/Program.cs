using System;

namespace User_Registration_Day19
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRegistrationValidation obj = new UserRegistrationValidation();


            Console.WriteLine("Checking Validation of User Input : ");


            #region UC-1
            bool Result = false;
            while (Result != true) 
            {
                Console.WriteLine("Enter the First Name :");
                string firstName = Console.ReadLine();
                Result = obj.validatefisrtName(firstName);
            }
            #endregion UC-1


            #region UC-2
            Result = false;
            while (Result != true)
            {
                Console.WriteLine("Enter the Last Name : ");
                string lastName = Console.ReadLine();
                Result=obj.validatelastName(lastName);
            }
            #endregion UC-2


            #region UC-3
            Result = false;
            while (Result != true)
            {
                Console.WriteLine("Enter the Email Id : ");
                string emailId = Console.ReadLine();
                Result = obj.validateEmail(emailId);
            }
            #endregion UC-3


            #region UC-4
            Result = false;
            while (Result != true)
            {
                Console.WriteLine("Enter the Phone No : ");
                string phoneNo = Console.ReadLine();
                Result = obj.validatePh_No(phoneNo);
            }
            #endregion UC-4


            #region UC 5-8
            Result = false;
            while (Result != true)
            {
                Console.WriteLine("Enter the Password : ");
                string password = Console.ReadLine();
                Result = obj.validatePassword(password);
            }
            #endregion UC 5-8


            #region UC-9
            Result = false;
            while (Result != true)
            {
                Console.WriteLine("Enter the Email Id : ");
                string emailId = Console.ReadLine();
                Result = SampleEmail.validateEmail(emailId);
            }
            #endregion UC-9
        }
    }
}
