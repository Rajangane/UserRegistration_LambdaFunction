﻿using System;
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
        const string LASTNAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        const string EMAIL_PATTEREN = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";

        ///UC1 : method to check firstname with exception handling
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

        ////UC2 : method to check lastname with exception handling
        public string LastNameCheck(string lastName)
        {
            try
            {
                if (string.IsNullOrEmpty(lastName))
                    throw new RegexCustomException(RegexCustomException.InvalidUserdetails.EMPTY_NAME, "LastName Could not be Empty or null");
                if (Regex.IsMatch(lastName, LASTNAME_PATTERN))
                    Console.WriteLine("Last Name Validated");
                else
                    throw new RegexCustomException(RegexCustomException.InvalidUserdetails.INVALID_NAME, "Last name starts with Cap and has minimum 3 characters ");
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
        ////UC3 : method to check email id with exception handling
        public string EmailCheck(string email)
        {
            try
            {
                if (string.IsNullOrEmpty(email))
                    throw new RegexCustomException(RegexCustomException.InvalidUserdetails.EMPTY_EMAIL, "Email Could not be Empty or null");
                if (Regex.IsMatch(email, EMAIL_PATTEREN))
                    return "email is Validated";
                else
                    throw new RegexCustomException(RegexCustomException.InvalidUserdetails.INVALID_EMAIL, "E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl & co) and 2 optional(xyz & in) with precise @ and.positions");
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
