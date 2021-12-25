// See https://aka.ms/new-console-template for more information
//Console.WriteLine("************** User Registration Problem Using Regex and Lambda Function ******************");
using UserRegistration_LambdaFunction;
bool isExit = false;
int options;
while (!isExit)
{
    Console.WriteLine("Select Number\n1).FirstNameValidate\n2).LastNameValidate\n3).EmailValidate\n4)PhoneValidate\n5)PasswordValidate\n6)LambaExpressionToValidateUserDetails");
    options = Convert.ToInt32(Console.ReadLine());
    RegexValidation regularExpression = new RegexValidation();

    switch (options)
    {
        case 1:
            Console.WriteLine("enter firstname");
            string firstName = Console.ReadLine();
            string result = regularExpression.FirstnameCheck(firstName);
            Console.WriteLine(result);
            break;
        case 2:
            Console.WriteLine("enter lastname");
            string lastName = Console.ReadLine();
            regularExpression.LastNameCheck(lastName);
            break;
        case 3:
            Console.WriteLine("enter email");
            string email = Console.ReadLine();
            string result1 = regularExpression.EmailCheck(email);
            Console.WriteLine(result1);
            break;
        case 4:
            Console.WriteLine("enter Phone Number");
            string phno = Console.ReadLine();
            string result2 = regularExpression.PhoneCheck(phno);
            Console.WriteLine(result2);
            break;
        case 5:

            Console.WriteLine("enter password");
            string password = Console.ReadLine();
            regularExpression.PasswordCheck(password);
            break;
        case 6:
           
            Console.WriteLine("enter firstname");
            string firstName1 = Console.ReadLine();
            string output1 = regularExpression.LambdaExpressionFirstnameCheck(firstName1);
            Console.WriteLine(output1);
            Console.WriteLine("enter lastname");
            string lastName1 = Console.ReadLine();
            string output2 = regularExpression.LambdaExpressionLastnameCheck(lastName1);
            Console.WriteLine(output2);
            Console.WriteLine("enter email");
            string email1 = Console.ReadLine();
            string output3 = regularExpression.LambdaExpressionEmailCheck(email1);
            Console.WriteLine(output3);
            Console.WriteLine("enter phno");
            string phno1 = Console.ReadLine();
            string output4 = regularExpression.LambdaExpressionPhoneNumberCheck(phno1);
            Console.WriteLine(output4);
            Console.WriteLine("enter password");
            string password1 = Console.ReadLine();
            string output5 = regularExpression.LambdaExpressionpasswordCheck(password1);
            Console.WriteLine(output5);
            break;

        default:
            Console.WriteLine("Invalid Option");
            break;
    }
}