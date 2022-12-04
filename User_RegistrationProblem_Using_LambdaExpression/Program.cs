using System.Numerics;
using System;

namespace User_RegistrationProblem_Using_LambdaExpression
{
    public class Program: Exception
    {
        public Program(string message):base(message)
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("WelCome To UserRegistration Problem Using Lambda Expression !!!!!!!");

            Console.WriteLine("Please Enter Your Choice ");
            Console.WriteLine("1.FirstName.\n 2.LastName \n 3.EmailId \n 4.MobileNumber \n 5.Password \n 6.Exit");

            var Task =Console.ReadLine();

            switch(Task)
            {
                case "1":
                    try
                    {
                        Console.WriteLine("Please Enter First Name: ");
                        Regex1 name = new Regex1();
                        bool result = name.ValidateFirstName(Console.ReadLine(), Regex1.FirstName);
                        Console.WriteLine(result);
                        if(result==false)
                        {
                            throw new Program ("Please Maintain First Letter Capital With Minimum 2 character");
                        }
                    }
                    catch(Program e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "2":
                    try
                    {
                        Console.WriteLine("Please Enter Last Name: ");
                        Regex1 regex1 = new Regex1();
                        bool result = regex1.ValidateLastName(Console.ReadLine(),Regex1.LastName);
                        Console.WriteLine(result);
                        if (result == false)
                        {
                            throw new Program("Please Maintain First Letter Capital With Minimum 2 character");
                        }
                    }
                    catch (Program e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "3":
                    try
                    {
                        Console.WriteLine("Please Enter Email Id : ");
                        Regex1 regex1 = new Regex1();
                        bool result = regex1.ValidateEmailId(Console.ReadLine(),Regex1.EmailId);
                        Console.WriteLine(result);
                        if (result == false)
                        {
                            throw new Program("Must contain Alphabet and Numeric Combination only.\nEnding with proper domain address e.g. '@gmail.com");
                        }
                    }
                    catch (Program e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "4":
                    try
                    {
                        Console.WriteLine("Please Enter Mobile Number : ");
                        Regex1 regex1 = new Regex1();
                        bool result = regex1.ValidateMobileNumber(Console.ReadLine(),Regex1.MobileNumber);
                        Console.WriteLine(result);
                        if (result == false)
                        {
                            throw new Program("Starting with '91' and space and having exact 10 digits as Phone Number");
                        }
                    }
                    catch (Program e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "5":
                    try
                    {
                        Console.WriteLine("Please Enter Password : ");
                        Regex1 regex1 = new Regex1();
                        bool result = regex1.ValidatePassword(Console.ReadLine(),Regex1.Password);
                        Console.WriteLine(result);
                        if (result == false)
                        {
                            throw new Program("Must contain Alphanumeric combination.\nConsisting atleast 1 uppercase character, atleast 1 numeric value.\nAnd exactly one special character");
                        }
                    }
                    catch (Program e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "6":
                    break;
                default:
                    Console.WriteLine("Please Enter Valid Choice ");
                    break;
            }
        }
    }
}