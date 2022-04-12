using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_20_MSTestingREGEXUserRegistration
{
    public class Validation
    {
        public string FirstNameValidation(string FirstName)
        {
            string pattern = "^[A-Z][a-z]{2,}$"; // Creating REGEX pattern
            if (Regex.IsMatch(FirstName, pattern)) //For checking regex are valid or invalid
            {
                Console.WriteLine("The First name is : " + FirstName);
                return "Valid";
            }
            else
            {
                Console.WriteLine("Invalid Name : " + FirstName);
                return "Invalid";
            }

        }
        public string LastNameValidation(string LastName)
        {
            string pattern = "^[A-Z][a-z]{2,}$"; // Creating REGEX pattern
            if (Regex.IsMatch(LastName, pattern)) //For checking regex are valid or invalid
            {
                Console.WriteLine("The Last name is : " + LastName);
                return "Valid";
            }
            else
            {
                Console.WriteLine("Invalid Name : " + LastName);
                return "Invalid";
            }
        }
        public string EmailValidation(string Email)
        {
            string pattern = "^[0-9a-zA-Z]+[./+_-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9-]+[.][a-zA-Z]{2,}([.][a-zA-Z]{2,}){0,1}$"; // Creating REGEX pattern
            if (Regex.IsMatch(Email, pattern)) //For checking regex are valid or invalid
            {
                Console.WriteLine("This is my Email id : " + Email);
                return "Valid";
            }
            else
            {
                Console.WriteLine("Invalid email : " + Email);
                return "Invalid";
            }
        }
        public string MobileNumberValidation(string Number)
        {
            string pattern = "^[0-9]{1,3}[ ][0-9]{10}$"; // Creating REGEX pattern
            if (Regex.IsMatch(Number, pattern)) //For checking regex are valid or invalid
            {
                Console.WriteLine("My number id is : " + Number);
                return "Valid";
            }
            else
            {
                Console.WriteLine("Invalid number : " + Number);
                return "Invalid";
            }
        }
        public string Password(string pswd)
        {

            string pattern = "^(?=.*[A-Z])[A-Za-z]{8,}$"; // Creating REGEX pattern

            if (Regex.IsMatch(pswd, pattern)) //For checking regex are valid or invalid
            {
                Console.WriteLine("My password id is : " + pswd);
                return "Valid";
            }
            else
            {
                Console.WriteLine("Invalid password : " + pswd);
                return "Invalid";
            }
        }
    }
}
