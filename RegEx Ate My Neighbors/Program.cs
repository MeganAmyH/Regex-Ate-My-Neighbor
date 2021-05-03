using System;
using System.Text.RegularExpressions;

namespace RegEx_Ate_My_Neighbors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that will recognize invalid inputs using regular expressions.

            //Write a method that will validate names. Names can only have alphabets, they should start with a capital letter, and have a maximum of length of 30.

            Regex name = new Regex("^[A-Z]{1}[a-z]{1,29}$");
            string input1;

            Console.WriteLine("Enter your name: ");
            input1 = Console.ReadLine();

            while (name.Match(input1).Success == false)
            {
                Console.WriteLine("Invalid. Please enter your name. ");
                input1 = Console.ReadLine();
            }
            Console.WriteLine("Validated!");

            //Write a method that will validate emails. An email should be in the following format:
            //{combo of alphanumeric characters, with a length between 5 and 30, and no special characters}@{alphanumeric characters,
            //with a length between 5 & 10.{domain can be a combonation of alphanumeric characters with a length of 2 or 3}

            Regex email = new Regex("^([A-Za-z0-9]{5-30})+@([A-Za-z0-9]{5-10})+.({A-Za-z]{2-3})$");

            string input2;
            Console.WriteLine("Enter your email: ");
            input2 = Console.ReadLine();

            while (email.Match(input2).Success == false)
            {
                Console.WriteLine("Invalid. Please enter your email. ");
                input2 = Console.ReadLine();
            }
            Console.WriteLine("Validated!");

            // Write a method that will validate phone numbers. A phone number should be in the following format:
            //{area code of 3 digits}-{3 digits}-{4 digits}
            Regex phoneExp = new Regex(@"^\d{3}-\d{3}-\d{4}$");
            string input3;

            Console.Write("Enter a phone number: (example: 111-222-3333)");
            input3 = Console.ReadLine();

            while (phoneExp.Match(input3).Success == false)
            {
                Console.WriteLine("Invalid input. Try again.");
                Console.Write("Enter a phone number: ");
                input3 = Console.ReadLine();
            }

            Console.WriteLine("Validated!");

            //Write a method that will validate date based on the following format: {dd/mm/yyyy}

            Regex birthDate = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            string input4;

            Console.WriteLine("Enter your birthdate in dd/mm/yyyy format: ");
            input4 = Console.ReadLine();

            while (birthDate.Match(input4).Success == false)
            {
                Console.WriteLine("Invalid input. Try again.");
                Console.WriteLine("Please enter your birthdate in dd/mm/yyyy format: ");
            }
            Console.WriteLine("Validated!");
        }
    }
}
