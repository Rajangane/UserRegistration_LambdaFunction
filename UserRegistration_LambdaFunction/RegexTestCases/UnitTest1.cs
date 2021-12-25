using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration_LambdaFunction;
using static UserRegistration_LambdaFunction.RegexCustomException;
using static UserRegistration_LambdaFunction.RegexValidation;

namespace RegexTestCases
{
    [TestClass]
    public class UnitTest1
    {
        RegexValidation regex = new RegexValidation();

        [TestMethod]
        //First Name Validation
        public void Check_FirstName_Validate()
        {
            string actual = regex.FirstnameCheck("Pratiksha");
            Assert.AreEqual("First Name Validated", actual);
        }
        
        [TestMethod]
        //Last Name Validation
        public void Check_LastName_Validate()
        {
            string actual = regex.LastNameCheck("Rajangane");
            Assert.AreEqual("Last Name Validated", actual);
        }
        //Email Validation
        [TestMethod]
        public void Check_Email_Validate()
        {
            string actual = regex.EmailCheck("pratiksha@gmail.com");
            Assert.AreEqual("email is Validated", actual);
        }
        //Phone number Validation
        [TestMethod]
        public void Check_Phno_Validate()
        {
            string actual = regex.PhoneCheck("91 6360000028");
            Assert.AreEqual("phno is Validated", actual);
        }
        //Password Validation
        [TestMethod]
        public void Check_Password_Validate()
        {
            string actual = regex.PasswordCheck("Pratik#52");
            Assert.AreEqual("password is Validated", actual);
        }

    }
}