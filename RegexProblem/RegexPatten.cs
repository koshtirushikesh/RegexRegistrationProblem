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

        public void ValidateFirstName(string firstName)
        {
            string firstNamePatten = "^[A-Z][a-z]{3,}?";

            if(Regex.IsMatch(firstName, firstNamePatten)) 
            {
                Console.WriteLine("First Name is Valid");
            }else
            {
                Console.WriteLine("First Name not Valid ");
            }
        }

        
    }
}
