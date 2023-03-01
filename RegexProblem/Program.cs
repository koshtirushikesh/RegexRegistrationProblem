using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegexPatten regexPatten = new RegexPatten();
            regexPatten.ValidateNameFirstName("Rushi");
            regexPatten.ValidateNameLastName("Koshti");
            regexPatten.ValidateEmail("abc@yahoo.com");
            regexPatten.ValidateMobileNumber("91 7021734837");
            regexPatten.ValidatePasswordRoule1("password");
            regexPatten.ValidatePasswordRoule2("pasSword");
            regexPatten.ValidatePasswordRoule3("pasSwor1");
            regexPatten.ValidatePasswordRoule4("1234@Rus");
            Console.ReadLine();
        }
    }
}
