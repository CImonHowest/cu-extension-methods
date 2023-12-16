using System;
using System.Collections.Generic;

namespace ProgrammingExpert.ExtensionMethods.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 10;

            bool greater = i.IsGreaterThan(j);

            Console.WriteLine($"Is {i} greater than {j}? Answer: {greater}");


            List<string> emails = new List<string>
            {
                "simon@simonsoenens.be",
                "simon@pompo@.be",
                "simon@simonsoenens.testje"
            };

            foreach (var email in emails)
            {
                Console.WriteLine($"Is {email} a valid email address? Answer: {email.IsValidEmail()}");
            }   

            Console.ReadLine();

        }
    }
}
