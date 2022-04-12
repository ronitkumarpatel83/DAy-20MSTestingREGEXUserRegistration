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
            int n = 1;
            while (n == 1)
            {
                Console.WriteLine("1.First Name\n2.Last Name\n3.Email Validation\n4.Mobile Format");
                Console.WriteLine("5.Password");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("User need to valid First Name \n ");
                        Validation firstname = new Validation();
                        firstname.FirstNameValidation("Ronit");
                        break;
                    case 2:
                        Console.WriteLine("User need to valid Last Name \n");
                        Validation lastname = new Validation();
                        lastname.LastNameValidation("Patel");
                        break;
                    case 3:
                        Console.WriteLine("Email Validation");
                        Validation email = new Validation();
                        email.EmailValidation("ronitkumarpatel83@gmail.com");
                        break ;
                    case 4:
                        Console.WriteLine("Mobile Format");
                        Validation mobile = new Validation();
                        mobile.MobileNumberValidation("91 7008427274");
                        break;
                    case 5:
                        Console.WriteLine("1.Password minimum 8 character");
                        string a = Console.ReadLine();                       
                        Validation password = new Validation();
                        password.Password(a);
                        break;
                    default: 
                        Console.WriteLine("Enter a valid key");
                        break ;
                }

                Console.WriteLine("\n Press 1 to Continue or Press any other key to Exit");
                n = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
