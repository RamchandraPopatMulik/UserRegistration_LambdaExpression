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
        public Func<string, string, bool> ValidateFirstName = (name, FirstName) => Regex.IsMatch(name,FirstName);
        public Func<string, string, bool> ValidateLastName = (name, LastName) => Regex.IsMatch(name, LastName);
        public Func<string, string, bool> ValidateEmailId = (name, EmailId) => Regex.IsMatch(name, EmailId);
        public Func<string, string, bool> ValidateMobile = (name, MobileNumber) => Regex.IsMatch(name, MobileNumber);
        public Func<string, string, bool> ValidatePassword = (name, Password) => Regex.IsMatch(name, Password);
    }
}
