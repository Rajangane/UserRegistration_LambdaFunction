using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration_LambdaFunction
{
    public class RegexCustomException : Exception
    {
        public enum InvalidUserdetails
        {
            EMPTY_NAME,
            EMPTY_EMAIL,
            EMPTY_PHONE_NO,
            EMPTY_PASSWORD,
            INVALID_NAME,
            INVALID_EMAIL,
            INVALID_PHONE_NO,
            INVALID_PASSWORD
        }
        public readonly InvalidUserdetails error;
        /// <summary>
        /// creating a constructor and passing string message and exception type 
        /// </summary>
        /// <param name="error"></param>
        /// <param name="message"></param>
        public RegexCustomException(InvalidUserdetails error, string message) : base(message)
        {
            this.error = error;
        }
    }
}

