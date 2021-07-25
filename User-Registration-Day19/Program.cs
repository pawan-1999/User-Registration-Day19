using System;

namespace User_Registration_Day19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking Validation of User Input : ");
            Console.WriteLine("Enter the First Name :");
            string firstName = Console.ReadLine();
            Console.WriteLine(UserRegistrationValidation.validatefisrtName(firstName));
            Console.WriteLine("Enter the Last Name : ");
            string lastName = Console.ReadLine();
            Console.WriteLine(UserRegistrationValidation.validatelastName(lastName));
            Console.WriteLine("Enter the Email Id : ");
            string emailId = Console.ReadLine();
            Console.WriteLine(UserRegistrationValidation.validateEmail(emailId));
            Console.WriteLine("Enter the Phone No : ");
            string phoneNo = Console.ReadLine();
            Console.WriteLine(UserRegistrationValidation.validateph_No(phoneNo));

        }
    }
}
