using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserRegexTest
    {
        public Regex FirstNameRegex = new Regex(@"^[A-Z][a-zA-Z]{2,}$");
        public Regex LastNameRegex = new Regex(@"^[A-Z][a-zA-Z]{2,}$");
        public Regex EmailAddressRegex = new Regex(@"^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2})*$");
        public Regex MobileNumberRegex = new Regex(@"^[0-9]{2}\s[0-9]{10}$");
        public void ValidateFirstName(string FirstName)
        {
            Console.WriteLine("\nfirst name: "+FirstName);
            if(FirstNameRegex.IsMatch(FirstName))
                Console.WriteLine("valid first name");
            else
                Console.WriteLine("invalid first name");
        }

        internal void ValidateMobileNumber(string MobileNumber)
        {
            Console.WriteLine("\nmobile number: " + MobileNumber);
            if (MobileNumberRegex.IsMatch(MobileNumber))
                Console.WriteLine("valid mobile number");
            else
                Console.WriteLine("invalid mobile number");
        }

        public void ValidateEmailAddress(string EmailAddress)
        {
            Console.WriteLine("\nemail address: " + EmailAddress);
            if (EmailAddressRegex.IsMatch(EmailAddress))
                Console.WriteLine("valid email address");
            else
                Console.WriteLine("invalid email address");
        }

        public void ValidateLastName(string LastName)
        {
            Console.WriteLine("\nlast name: " + LastName);
            if (LastNameRegex.IsMatch(LastName))
                Console.WriteLine("valid last name");
            else
                Console.WriteLine("invalid last name");
        }
    }
}
