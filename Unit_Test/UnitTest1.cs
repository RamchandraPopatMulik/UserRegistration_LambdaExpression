using User_RegistrationProblem_Using_LambdaExpression;

namespace Unit_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       public void Check_FirstName()
        {
            Regex1 regex1 = new Regex1();
            bool result = regex1.ValidateFirstName("Ramchandra",Regex1.FirstName);
            Assert.IsTrue(result);
        }
        public void Check_LastName()
        {
            Regex1 regex1 = new Regex1();
            bool resultlast = regex1.ValidateLastName("Mulik", Regex1.LastName);
            Assert.IsTrue(resultlast);
        }
        public void Check_EmailId()
        {
            Regex1 regex1 = new Regex1();
            bool resultemail = regex1.ValidateEmailId("mulikram2016@gmail.com", Regex1.EmailId);
            Assert.IsTrue(resultemail);
        }
        public void Check_MobileNumber()
        {
            Regex1 regex1 = new Regex1();
            bool resultmobile = regex1.ValidateMobile("91 9604340676", Regex1.MobileNumber);
            Assert.IsTrue(resultmobile);
        }
        public void Check_Password()
        {
            Regex1 regex1 = new Regex1();
            bool resultpass = regex1.ValidatePassword("Ram@1234", Regex1.MobileNumber);
            Assert.IsTrue(resultpass);
        }
    }
}