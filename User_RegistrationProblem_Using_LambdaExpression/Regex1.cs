using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace User_RegistrationProblem_Using_LambdaExpression
{
    public class Regex1
    {
        public const string FirstName = "^[A-Z]{1}[a-z]{3,}$";
        public const string LastName = "^[A-Z]{1}[a-z]{3,}$";
        public const string EmailId = "^[a-z0-9A-Z]+([.][a-zA-Z0-9]+)?[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,2})?$";
        public const string MobileNumber = "^[9]{1}[1]{1}[ ]{1}[0-9]{10}$";
        public const string Password = "(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+]).{8,}$";


        //Func<string, string, bool> Test = (x, y) => x>y;
        public bool ValidateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname, FirstName);
        }
        public bool ValidateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, LastName);
        }
        public bool ValidateEmailId(string email)
        {
           return Regex.IsMatch(email, EmailId);
        }
        public bool ValidateMobile(string mobile)
        {
            return Regex.IsMatch(mobile, MobileNumber);
        }
        public bool ValidatePassword(string pass)
        {
            return Regex.IsMatch(pass, Password);
        }
    }
}
