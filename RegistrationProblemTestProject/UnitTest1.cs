using RegexProblem;
namespace RegistrationProblemTestProject
{
    public class Tests
    {
        RegexPatten regexPatten = new RegexPatten();
        [Test]
        public void GivenFirstCapitalLetterFirstName_WhenAnalysed_ShouldReturnValidName()
        {
            string expectedResult = "First Name is Valid";
            string actualResult = regexPatten.ValidateNameFirstName("Rushi");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GivenFirstCapitalLetterLastName_WhenAnalysed_ShouldReturnValidName()
        {
            string expectedResult = "Last Name is Valid";
            string actualResult = regexPatten.ValidateNameLastName("Koshti");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GivenFirstSmallLetterFirstName_WhenAnalysed_ShouldReturnNotValidName()
        {
            string expectedResult = "First Name is not Valid";
            string actualResult = regexPatten.ValidateNameFirstName("rushi");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GivenFirstSmallLetterLastName_WhenAnalysed_ShouldReturnNotValidName()
        {
            string expectedResult = "Last Name is not Valid";
            string actualResult = regexPatten.ValidateNameLastName("koshti");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GivenEmailId_WhenAnalysed_ShouldReturnEmailValid()
        {
            string expectedResult = "Email is Valid";
            string actualResult = regexPatten.ValidateEmail("abc@yahoo.com");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GivenMobile10Number_WhenAnalysed_ShouldReturnMobileNumberValid()
        {
            string expectedResult = "Mobile Number is Valid";
            string actualResult = regexPatten.ValidateMobileNumber("91 7021734837");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GivenMobile9Number_WhenAnalysed_ShouldReturnMobileNumberNotValid()
        {
            string expectedResult = "Mobile Number not Valid";
            string actualResult = regexPatten.ValidateMobileNumber("91 702173483");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Given8Letters_WhenAnalyed_ShouldReturnValidPassWord()
        {
            string expectedResult = "Password is Valid";
            string actualResult = regexPatten.ValidatePasswordRoule1("qwertyui");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Given7Letters_WhenAnalyed_ShouldReturnNotValidPassWord()
        {
            string expectedResult = "Password not Valid";
            string actualResult = regexPatten.ValidatePasswordRoule1("qwertyu");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Given8LettersOneUpperCase_WhenAnalyed_ShouldReturnValidPassWord()
        {
            string expectedResult = "Password is Valid";
            string actualResult = regexPatten.ValidatePasswordRoule2("qwerTyui");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Given8Letters_WhenAnalyed_ShouldReturnNotValidPassWord()
        {
            string expectedResult = "Password not Valid";
            string actualResult = regexPatten.ValidatePasswordRoule2("qwertyui");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Given8LettersOneUpperCaseAndNumberCase_WhenAnalyed_ShouldReturnValidPassWord()
        {
            string expectedResult = "Password is Valid";
            string actualResult = regexPatten.ValidatePasswordRoule3("qwerTyu1");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Given8LettersOneUpperCase_WhenAnalyed_ShouldReturnNotValidPassWord()
        {
            string expectedResult = "Password not Valid";
            string actualResult = regexPatten.ValidatePasswordRoule3("qwertyui");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Given8LettersOneUpperCaseOneNumberCaseOneSpecialCharacter_WhenAnalyed_ShouldReturnValidPassWord()
        {
            string expectedResult = "Password is Valid";
            string actualResult = regexPatten.ValidatePasswordRoule4("qwerTy*1");
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Given8LettersOneUpperCaseOneNumberCase_WhenAnalyed_ShouldReturnNotValidPassWord()
        {
            string expectedResult = "Password not Valid";
            string actualResult = regexPatten.ValidatePasswordRoule4("qwertyu1");
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}