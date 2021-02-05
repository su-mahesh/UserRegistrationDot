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

            userRegexTest.ValidateFirstName(FirstName);
            userRegexTest.ValidateLastName(LastName);
            userRegexTest.ValidateEmailAddress(EmailAddress);

        }
    }
}
