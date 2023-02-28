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
            regexPatten.ValidateName("Rushi","Koshti");
            regexPatten.ValidateEmail("abc.xyz@bl.co.in");
            regexPatten.ValidateMobileNumber("91 7021734837");
            regexPatten.ValidatePasswordRoule1("password");
            regexPatten.ValidatePasswordRoule2("pasSword");
            regexPatten.ValidatePasswordRoule3("pasSword1");
            regexPatten.ValidatePasswordRoule4("pasSword@_123");
            Console.ReadLine();

        }
    }
}
