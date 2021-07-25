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

        }
    }
}
