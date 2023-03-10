using System;
using System.Collections.Generic;
using System.Linq;

namespace UserRegistrationLamda
{
    public class RegistrationLambda
    {
        List<RegistrationModel> registrationPattenList = new List<RegistrationModel>();
        public RegistrationLambda()
        {
            RegistrationModel registration = new RegistrationModel();
            registrationPattenList.Add(registration);
        }
        public void CheckFirstName(string firstName)
        {
            if (registrationPattenList.Any(x => x.FirstNamePatten.IsMatch(firstName)))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void CheckLastName(string lastName)
        {
            if (registrationPattenList.Any(x => x.LastNamePatten.IsMatch(lastName)))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public void CheckEmail(string eMail)
        {
            if (registrationPattenList.Any(x => x.EmailPatten.IsMatch(eMail)))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public void CheckobileNum(string mobileNum)
        {
            if (registrationPattenList.Any(x => x.MobileNumPatten.IsMatch(mobileNum)))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public void CheckPassword1(string password)
        {
            if (registrationPattenList.Any(x => x.Password1Patten.IsMatch(password)))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void CheckPassword2(string password)
        {
            if (registrationPattenList.Any(x => x.Password2Patten.IsMatch(password)))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public void CheckPassword3(string password)
        {
            if (registrationPattenList.Any(x => x.Password3Patten.IsMatch(password)))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public void CheckPassword4(string password)
        {
            if (registrationPattenList.Any(x => x.Password4Patten.IsMatch(password)))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }

}
