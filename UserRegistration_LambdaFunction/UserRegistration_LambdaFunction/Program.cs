// See https://aka.ms/new-console-template for more information
//Console.WriteLine("************** User Registration Problem Using Regex and Lambda Function ******************");
using UserRegistration_LambdaFunction;
bool isExit = false;
int options;
while (!isExit)
{
    Console.WriteLine("Select Number\n1).FirstNameValidaterdValidate");
    options = Convert.ToInt32(Console.ReadLine());
    switch (options)
    {
        case 1:
            RegexValidation regularExpression = new RegexValidation();
            Console.WriteLine("enter firstname");
            string firstName = Console.ReadLine();
            string result = regularExpression.FirstnameCheck(firstName);
            Console.WriteLine(result);
            break;

        default:
            Console.WriteLine("Invalid Option");
            break;
    }
}