// See https://aka.ms/new-console-template for more information
//Console.WriteLine("************** User Registration Problem Using Regex and Lambda Function ******************");
using UserRegistration_LambdaFunction;
bool isExit = false;
int options;
while (!isExit)
{
    Console.WriteLine("Select Number\n1).FirstNameValidate\n2).LastNameValidate\n");
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

        default:
            Console.WriteLine("Invalid Option");
            break;
    }
}