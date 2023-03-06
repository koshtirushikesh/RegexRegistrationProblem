using System;
using System.Text.RegularExpressions;

namespace RegexProblem
{
    public class RegexPatten
    {
        public string ValidateNameFirstName(string firstName)
        {
            string NamePatten = "^[A-Z][a-z]{3,}?";
            try
            {
                if (firstName.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "First Name should not be Empty");
                }
                if (Regex.IsMatch(firstName, NamePatten))
                {
                    Console.WriteLine("First Name is Valid");
                    return "First Name is Valid";
                }
                else
                {
                    Console.WriteLine("First Name not Valid");
                    return "First Name is not Valid";
                }
            }catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "First Name should not be Null");
            }
        }
        public string ValidateNameLastName(string lastName)
        {
            string NamePatten = "^[A-Z][a-z]{3,}?";
            try
            {
                if (lastName.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Last Name should not be Empty");
                }
                if (Regex.IsMatch(lastName, NamePatten))
                {
                    Console.WriteLine("Last Name is Valid");
                    return "Last Name is Valid";
                }
                else
                {
                    Console.WriteLine("Last Name is not Valid ");
                    return "Last Name is not Valid";
                }
            }
            catch(NullReferenceException) 
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Last Name should not be Null");
            }
        }

        public string ValidateEmail(string email)
        {
            //abc.xyz@bl.co.in
            string emailPatten = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
            try
            {
                if (email.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Email should not be Empty");
                }
                if (Regex.IsMatch(email, emailPatten))
                {
                    Console.WriteLine("Email is Valid");
                    return "Email is Valid";
                }
                else
                {
                    Console.WriteLine("Email not Valid ");
                    return "Email is Valid";
                }
            }
            catch(NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Email should not be Null");
            }
        }

        public string ValidateMobileNumber(string mobileNumber)
        {
            string mobileNumberPatten = @"[0-9]{1,2}[ ][0-9]{10}"; /*@"[0-9]{1,2}\s[0-9]{10}"*/
            try
            {
                if (mobileNumber.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Mobile Number should not be Empty");
                }
                if (Regex.IsMatch(mobileNumber, mobileNumberPatten))
                {
                    Console.WriteLine("Mobile Number is Valid");
                    return "Mobile Number is Valid";
                }
                else
                {
                    Console.WriteLine("Mobile Number not Valid");
                    return "Mobile Number not Valid";
                }
            }
            catch(NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Mobile Number should not be Null");
            }
        }

        public string ValidatePasswordRoule1(string password)
        {
            string passwordPatten = @"[A-Z a-z 0-9]{8,}";
            if (Regex.IsMatch(password, passwordPatten))
            {
                Console.WriteLine("Password is Valid");
                return "Password is Valid";
            }
            else
            {
                Console.WriteLine("Password not Valid ");
                return "Password not Valid";
            }
        }

        public string ValidatePasswordRoule2(string password)
        {
            string passwordPatten = "(?=.*[A-Z])[A-Za-z0-9]{8,}";
            if (Regex.IsMatch(password, passwordPatten))
            {
                Console.WriteLine("Password is Valid");
                return "Password is Valid";
            }
            else
            {
                Console.WriteLine("Password not Valid ");
                return "Password not Valid";
            }
        }
        public string ValidatePasswordRoule3(string password)
        {
            string passwordPatten = "(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9]{8,}";
            if (Regex.IsMatch(password, passwordPatten))
            {
                Console.WriteLine("Password is Valid");
                return "Password is Valid";
            }
            else
            {
                Console.WriteLine("Password not Valid ");
                return "Password not Valid";
            }
        }

        public string ValidatePasswordRoule4(string password)
        {
            string passwordPatten = "^(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[!@#$%^&*()_+=-]).{8,}$"; // "(?=.*[A-Z])(?=.*[0-9])(?=.*[*#@$!^_-])[A-Za-z0-9]{8,}"
            
            if (Regex.IsMatch(password, passwordPatten))
            {
                Console.WriteLine("Password is Valid");
                return "Password is Valid";
            }
            else
            {
                Console.WriteLine("Password not Valid ");
                return "Password not Valid";
            }
        }

    }
}
