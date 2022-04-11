using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_20_MSTestingREGEXUserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User need to valid First Name \n ");
            Validation validation = new Validation();
            validation.FirstNameValidation("Ronit");
            Console.ReadLine();
            
        }
    }
}
