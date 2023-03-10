using System.Text.RegularExpressions;

namespace UserRegistrationLamda
{
    public class RegistrationModel
    {
        public Regex FirstNamePatten = new Regex(@"^[A-Z][a-z]{3,}?");
        public Regex LastNamePatten = new Regex(@"^[A-Z][a-z]{3,}?");
        public Regex EmailPatten = new Regex(@"^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$");
        public Regex MobileNumPatten = new Regex(@"[0-9]{1,2}[ ][0-9]{10}");
        public Regex Password1Patten = new Regex(@"[A-Z a-z 0-9]{8,}");
        public Regex Password2Patten = new Regex(@"(?=.*[A-Z])[A-Za-z0-9]{8,}");
        public Regex Password3Patten = new Regex(@"(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9]{8,}");
        public Regex Password4Patten = new Regex(@"""^(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[!@#$%^&*()_+=-]).{8,}$""");
    }
}
