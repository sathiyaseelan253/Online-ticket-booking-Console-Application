using System;
using System.Text.RegularExpressions;

namespace Project_Console_Application
{
    class Validation
    {
        public bool ValidateEmail(string email)
        {
           
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (regex.IsMatch(email))
                return true;
            
            else
                Console.WriteLine("Email is not in Correct format");
                return false;

           
           
        }
        public bool ValidateContactNumber(string contactNumber)
        {

            Regex regex = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            if (regex.IsMatch(contactNumber))
                return true;

            else
                Console.WriteLine("Should contain 10 digits numbers");
            return false;

           
        }
        public bool PasswordValidation(string contactNumber)
        {

            Regex regex = new Regex(@"^(?=.*[A-Z])(?=.*\d)(?!.*(.)\1\1)[a-zA-Z0-9@]{6,12}$");
            if (regex.IsMatch(contactNumber))
            {
                while (true)
                {
                    Console.WriteLine("Reenter the password");
                    string rePass = Console.ReadLine();
                    if (contactNumber.Equals(rePass))
                    {
                        Console.WriteLine("Both are Matched");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Password mismatch");
                        continue;
                    }

                }
                return true;
            }
               

            else
                Console.WriteLine("Not in Correct format(Length >=6) should contain A-Z and any digits  0-9 and a-z ");
            return false;



        }
    }
}
