using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    class Program
    {
        static string Regex_password = "^(?=.*[A-Z])(?=.*\\d)(?=[\\w]*[\\W][\\w]*$)[\\S]{8,}$";
        public static string Regex_name = "^[A-Z]{1}[a-z]{2,}$";
        public static string Regex_email = "^[0-9A-Za-z]+([._+-]*[0-9A-Za-z]+)*[@][0-9A-Za-z]+.([a-zA-Z]{2,3})*(.[a-zA-Z]{2})?$";
        public static string Regex_phone = "^[1-9]{1}[0-9]{1}\\s[1-9]{1}[0-9]{9}$";
        static Patterns patterns = new Patterns();

        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the First name :");
            string firstName = Console.ReadLine();
            if (patterns.IsValidFirstName(firstName, Regex_name) == true)
                Console.Write("valid");
            else
                Console.WriteLine("invalid");
            Console.ReadKey();


            Console.WriteLine("Enter the last name :");
            string lastName = Console.ReadLine();
            if (patterns.IsValidFirstName(lastName, Regex_name) == true)
                Console.Write("valid");
            else
                Console.WriteLine("invalid");
            Console.ReadKey();


            Console.WriteLine("Enter the email  :");
            string Email = Console.ReadLine();
            if (patterns.IsValidFirstName(Email, Regex_email) == true)
                Console.Write("valid");
            else
                Console.WriteLine("invalid");
            Console.ReadKey();


            Console.WriteLine("Enter the password :");
            string passWord = Console.ReadLine();
            if (patterns.IsValidPasswordRule(passWord, Regex_password) == true)
                Console.Write("valid");
            else
                Console.WriteLine("invalid");
            Console.ReadKey();

            Console.WriteLine("Enter the Phone number :");
            string phoneNo = Console.ReadLine();
            if (patterns.IsValidPasswordRule(phoneNo, Regex_phone) == true)
                Console.Write("valid");
            else
                Console.WriteLine("invalid");
            Console.ReadKey();
        }
    }
}
    

