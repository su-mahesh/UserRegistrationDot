using System;

namespace UserRegistration
{
    class UserRegistration
    {
        static void Main(string[] args)
        { 
            UserRegexTest userRegexTest = new UserRegexTest();
            string FirstName = "Mahesh";
            string LastName = "Kangude";
            string EmailAddress = "maheshkangude@gmail.com";
            string MobileNumber = "91 8483996231";
            string Password = "sdnc*Kjn8dc";

            userRegexTest.ValidateFirstName(FirstName);
            userRegexTest.ValidateLastName(LastName);
            userRegexTest.ValidateEmailAddress(EmailAddress);
            userRegexTest.ValidateMobileNumber(MobileNumber);
            userRegexTest.ValidatePassword(Password);
        }
    }
}

