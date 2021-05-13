using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Patterns
    {
        public static string Regex_name = "^[A-Z]{1}[a-z]{2,}$";


        public void IsValidFirstName()
        {
            Boolean flag;
            Console.WriteLine("Enter the first name");

            do
            {
                string firstname = Console.ReadLine();
                flag = (Regex.IsMatch(firstname, Regex_name));
                if (flag == true)
                    Console.WriteLine("valid");
                else
                    Console.WriteLine("Invalid, Type again");
            }
            while (flag == false);

        }
    }
}
