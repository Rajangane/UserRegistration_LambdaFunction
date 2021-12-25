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
        //Invalid FirstName Exception
        [TestMethod]
        public void Given_InvalidFirstname_ThrowException()
        {
            try
            {
                string actual = regex.FirstnameCheck("Pratiksha28");
            }
            catch (RegexCustomException ex)
            {
                Assert.AreEqual("First name starts with Cap and has minimum 3 characters", ex.Message);
            }
        }
        // EmpltyOrNUll Firstname Exception
        [TestMethod]
        public void Given_NUllFirstname_ThrowException()
        {
            try
            {
                string actual = regex.FirstnameCheck(null);
            }
            catch (RegexCustomException ex)
            {
                Assert.AreEqual("FirstName Could not be Empty or null", ex.Message);
            }
        }
        //Invalid Last Name Exception
        [TestMethod]
        public void Given_InvalidLastname_ThrowException()
        {
            try
            {
                string actual = regex.LastNameCheck("Rajangane@");
            }
            catch (RegexCustomException ex)
            {
                Assert.AreEqual("Last name starts with Cap and has minimum 3 characters", ex.Message);
            }
        }
        //Invalid Email Exception
        [TestMethod]
        public void Given_InvalidEmail_ThrowException()
        {
            try
            {
                string actual = regex.EmailCheck("abc.xyz@gmail");
            }
            catch (RegexCustomException ex)
            {
                Assert.AreEqual("E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl & co) and 2 optional(xyz & in) with precise @ and.positions", ex.Message);
            }
        }
        //Inavlid Phone Number Exception
        [TestMethod]
        public void Given_InvalidPHNo_ThrowException()
        {
            try
            {
                string actual = regex.PhoneCheck("+91 111111111111111");
            }
            catch (RegexCustomException ex)
            {
                Assert.AreEqual("Phone Number Should Have 10 digits and [+91 ] is Mandatory - E.g. 91 6360789564 - Country code follow by space and 10 digit number", ex.Message);
            }
        }
        //Invalid Password Exception
        [TestMethod]
        public void Given_InvalidPassword_ThrowException()
        {
            try
            {
                string actual = regex.PasswordCheck("445555555555555555");
            }
            catch (RegexCustomException ex)
            {
                Assert.AreEqual("Password Have minimum 8 Characters, Should have at least 1 Upper Case and Should have at least 1 numeric number and Has exactly 1 Special Character", ex.Message);
            }
        }



    }
}