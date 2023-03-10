using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationLamda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RegistrationLambda registrationLambda = new RegistrationLambda();
            registrationLambda.CheckFirstName("Ru");
            Console.ReadLine();
        }
    }
}
