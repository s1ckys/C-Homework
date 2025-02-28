//## Task 1
//Create new console application called“RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.
//* Test Data:
//  *Enter the First number: 10
//  * Enter the Second number: 15
//  * Enter the Operation: +
//*Expected Output:
//*The result is: 25



Console.Write("Enter the First number: ");
string firstInput = Console.ReadLine();
bool firstSuccessParse = int.TryParse(firstInput, out int firstParsedInput);
if (!firstSuccessParse || firstInput == null)
{
    Console.WriteLine("The input is not a number... please enter a valid number!");
}

Console.Write("Enter the Second number: ");
string secondInput = Console.ReadLine();
bool secondSuccessParse = int.TryParse(secondInput, out int secondParsedInput);
if (!secondSuccessParse || secondInput == null)
{
    Console.WriteLine("The input is not a number... please enter a valid number!");
}

Console.Write("Enter the Operation (+, -, *, /): ");
string operation = Console.ReadLine();
bool validOperation = true;

int sum = 0;
switch (operation)
{
    case "+":
        {
            sum = firstParsedInput + secondParsedInput;
            Console.WriteLine(sum);
            break;
        }
    case "-":
        {
            sum = firstParsedInput - secondParsedInput;
            Console.WriteLine(sum);
            break;
        }
    case "*":
        {
            sum = firstParsedInput * secondParsedInput;
            Console.WriteLine(sum);
            break;
        }
    case "/":
        {
            sum = firstParsedInput / secondParsedInput;
            Console.WriteLine(sum);
            break;
        }
    default:
        validOperation = false;
        Console.WriteLine("Invalid operation! Please enter one of +, -, *, /.");
        break;
}

if (validOperation)
{
    Console.WriteLine($"The result is: {sum}");
}






