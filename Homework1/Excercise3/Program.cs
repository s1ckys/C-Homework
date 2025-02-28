//## Task 3:
//Create new console application called “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value.
//Please find example below:
//*Test Data:
//*Input the First Number: 5
//* Input the Second Number: 8
//* Expected Output:
//*After Swapping:
//*First Number: 8
//* Second Number: 5

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

int switchNumbers = firstParsedInput;
firstParsedInput = secondParsedInput;
secondParsedInput = switchNumbers;

Console.WriteLine($"First number is: {firstParsedInput}");
Console.WriteLine($"First number is: {secondParsedInput}");

