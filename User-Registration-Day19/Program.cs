using System;

namespace User_Registration_Day19
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRegistrationValidation obj = new UserRegistrationValidation();

            Console.WriteLine("Checking Validation of User Input : ");

            obj.validateFirstName();

        }
    }
}
