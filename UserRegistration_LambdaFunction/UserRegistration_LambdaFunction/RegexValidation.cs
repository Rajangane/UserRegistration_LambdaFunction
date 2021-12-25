using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_LambdaFunction
{
    public class RegexValidation
    {
        const string FIRSTNAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";

        ////UC1 ==> method to check firstname with exception handling
        public string FirstnameCheck(string firstName)
        {
            try
            {
                if (string.IsNullOrEmpty(firstName))
                    throw new RegexCustomException(RegexCustomException.InvalidUserdetails.EMPTY_NAME, "FirstName Could not be Empty or null");
                if (Regex.IsMatch(firstName, FIRSTNAME_PATTERN))
                    return "First Name Validated";
                else
                    throw new RegexCustomException(RegexCustomException.InvalidUserdetails.INVALID_NAME, "First name starts with Cap and has minimum 3 characters");
            }
            catch (RegexCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}
