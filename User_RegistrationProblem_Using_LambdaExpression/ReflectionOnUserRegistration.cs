using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace User_RegistrationProblem_Using_LambdaExpression
{
    public class ReflectionOnUserRegistration
    {
        public static void ReflectionTest()
        {
            Type type = Type.GetType("User_RegistrationProblem_Using_LambdaExpression.Program");
            Console.WriteLine($"Full Name is : {0}",type.FullName);
            Console.WriteLine($"Class Name is : {0}",type.Name);
            MethodInfo[] methods = type.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name+" "+method.Name);
            }
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}
