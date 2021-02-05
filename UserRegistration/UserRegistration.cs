using System;

namespace UserRegistration
{
    class UserRegistration
    {
        static void Main(string[] args)
        { 
            UserRegexTest userRegexTest = new UserRegexTest();
            String FirstName = "Mahesh";
            String LastName = "Kangude";

            userRegexTest.ValidateFirstName(FirstName);
            userRegexTest.ValidateLastName(LastName);
        }
    }
}
