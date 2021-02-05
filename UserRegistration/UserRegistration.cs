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
            
            string[] EmailList = {"abc@yahoo.com","abc-100@yahoo.com",  "abc.100@yahoo.com",
                                "abc111@abc.com",  "abc-100@abc.net",  "abc.100@abc.com.au",  "abc@1.com",
                                "abc@gmail.com.com",  "abc+100@gmail.com",
                                "abc",   "abc@.com.my",  "abc123@gmail.a",  "abc123@.com",
                                "abc123@.com.com",  ".abc@abc.com",  "abc()*@gmail.com",  "abc@%*.com",
                                "abc..2002@gmail.com",  "abc.@gmail.com",  "abc@abc@gmail.com",
                                "abc@gmail.com.1a",  "abc@gmail.com.aa.au"};

            userRegexTest.ValidateFirstName(FirstName);
            userRegexTest.ValidateLastName(LastName);
            userRegexTest.ValidateEmailAddress(EmailAddress);
            userRegexTest.ValidateMobileNumber(MobileNumber);
            userRegexTest.ValidatePassword(Password);

            foreach (string SampleEmailAddress in EmailList)
            {
                userRegexTest.ValidateEmailAddress(SampleEmailAddress);

            }
        }
    }
}

