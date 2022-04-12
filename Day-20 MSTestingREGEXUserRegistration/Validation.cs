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
    }
}
