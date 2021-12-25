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

    }
}