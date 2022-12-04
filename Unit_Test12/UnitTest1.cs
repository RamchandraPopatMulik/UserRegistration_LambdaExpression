using System.Text.RegularExpressions;
using User_RegistrationProblem_Using_LambdaExpression;

namespace Unit_Test12
{
    [TestClass]
    public class UnitTest12
    {
        [TestMethod]
        public void Check_FirstName()
        {
            Regex1 regex1 = new Regex1();
            bool result = regex1.ValidateFirstName("Ramchandra");
            Assert.IsTrue(result);
        }
        public void Check_LastName()
        {
            Regex1 regex1 = new Regex1();
            bool resultlast = regex1.ValidateLastName("Mulik");
            Assert.IsTrue(resultlast);
        }
        public void Check_EmailId()
        {
            Regex1 regex1 = new Regex1();
            bool resultemail = regex1.ValidateEmailId("mulikram2016@gmail.com");
            Assert.IsTrue(resultemail);
        }
        public void Check_MobileNumber()
        {
            Regex1 regex1 = new Regex1();
            bool resultmobile = regex1.ValidateMobile("91 9604340676");
            Assert.IsTrue(resultmobile);
        }
        public void Check_Password()
        {
            Regex1 regex1 = new Regex1();
            bool resultpass = regex1.ValidatePassword("Ram@1234");
            Assert.IsTrue(resultpass);
        }
    }
}
