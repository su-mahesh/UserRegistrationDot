using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserRegexTest
    {
        public Regex FirstNameRegex = new Regex(@"^[A-Z][a-zA-Z]{2,}$");
        public void ValidateFirstName(string firstName)
        {
            if(FirstNameRegex.IsMatch(firstName))
                Console.WriteLine("valid first name");
            else
                Console.WriteLine("invalid first name");
        }


    }
}
