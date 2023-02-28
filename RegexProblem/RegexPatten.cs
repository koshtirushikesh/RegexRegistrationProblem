using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    internal class RegexPatten
    {

        public void ValidateName(string firstName,string lastName)
        {
            string NamePatten = "^[A-Z][a-z]{3,}?";

            if(Regex.IsMatch(firstName, NamePatten)) 
            {
                Console.WriteLine("First Name is Valid");
            }else
            {
                Console.WriteLine("First Name not Valid ");
            }
            if(Regex.IsMatch(lastName, NamePatten))
            {
                Console.WriteLine("Last Name is Valid");
            }
            else
            {
                Console.WriteLine("Last Name not Valid ");
            }
        }

        public void ValidateEmail(string email)
        {
            //abc.xyz@bl.co.in
            string emailPatten = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";

            if (Regex.IsMatch(email, emailPatten))
            {
                Console.WriteLine("Email is Valid");
            }
            else
            {
                Console.WriteLine("Email not Valid ");
            }
        }

        public void ValidateMobileNumber(string mobileNumber)
        {
            string mobileNumberPatten = @"[0-9]{1,2}[ ][0-9]{10}"; /*@"[0-9]{1,2}\s[0-9]{10}"*/
            if (Regex.IsMatch(mobileNumber, mobileNumberPatten))
            {
                Console.WriteLine("Mobile Number is Valid");
            }
            else
            {
                Console.WriteLine("Mobile Number not Valid ");
            }
        }

        public void ValidatePasswordRoule1(string password)
        {
            string passwordPatten = @"[A-Z a-z 0-9]{8,}";
            if (Regex.IsMatch(password, passwordPatten))
            {
                Console.WriteLine("Password is Valid");
            }
            else
            {
                Console.WriteLine("Password not Valid ");
            }
        }

        public void ValidatePasswordRoule2(string password)
        {
            string passwordPatten = "(?=.*[A-Z])[A-Za-z0-9]{8,}";
            if (Regex.IsMatch(password, passwordPatten))
            {
                Console.WriteLine("Password is Valid");
            }
            else
            {
                Console.WriteLine("Password not Valid ");
            }
        }
        public void ValidatePasswordRoule3(string password)
        {
            string passwordPatten = "(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9]{8,}";
            if (Regex.IsMatch(password, passwordPatten))
            {
                Console.WriteLine("Password is Valid");
            }
            else
            {
                Console.WriteLine("Password not Valid ");
            }
        }

    }
}
