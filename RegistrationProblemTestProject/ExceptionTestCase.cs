using RegexProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationProblemTestProject
{
    public class ExceptionTestCase
    {
        RegexPatten regex = new RegexPatten();
        [Test]
        public void Given_Empty_FirstName_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                regex.ValidateNameFirstName(string.Empty);
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual("First Name should not be Empty", ex.Message);
            }
            
        }
        [Test]
        public void Given_NULL_FirstName_Should_Throw_UserRegistrationException()
        {
            try
            {
                regex.ValidateNameFirstName(null);
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual("First Name should not be Null", ex.Message);
            }
        }
        [Test]
        public void Given_Empty_LastName_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                regex.ValidateNameLastName(string.Empty);
            }
            catch(UserRegistrationCustomException ex)
            {
                Assert.AreEqual("Last Name should not be Empty", ex.Message);
            }
        }
        [Test]
        public void Given_NULL_LastName_Should_Throw_UserRegistrationException()
        {
            try
            {
                regex.ValidateNameLastName(null);
            }
            catch(UserRegistrationCustomException ex)
            {
                Assert.AreEqual("Last Name should not be Null", ex.Message);
            }
        }
        [Test]
        public void Given_Empty_Email_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                regex.ValidateEmail(string.Empty);
            }
            catch(UserRegistrationCustomException ex)
            {
                Assert.AreEqual("Email should not be Empty" ,ex.Message);
            }
        }
        [Test]
        public void Given_NULL_Email_Should_Throw_UserRegistrationException()
        {
            try
            {
                regex.ValidateEmail(null);
            }
            catch(UserRegistrationCustomException ex)
            {
                Assert.AreEqual("Email should not be Null",ex.Message);
            }
        }
        [Test]
        public void Given_Empty_Mobile_Should_Throw_UserRegistrationException_Indicat()
        {
            try
            {
                regex.ValidateMobileNumber(string.Empty);
            }
            catch(UserRegistrationCustomException ex)
            {
                Assert.AreEqual("Mobile Number should not be Empty", ex.Message);
            }
        }
        [Test]
        public void Given_NULL_MobileNumber_Should_Throw_UserRegistrationException()
        {
            try
            {
                regex.ValidateMobileNumber(null);
            }
            catch(UserRegistrationCustomException ex)
            {
                Assert.AreEqual("Mobile Number should not be Null",ex.Message);
            }
        }
    }
}
