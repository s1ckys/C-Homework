//## Task 2
//Create new console application called “AverageNumber” that takes four numbers as input to calculate and print the average.
//* Test Data:
//  *Enter the First number: 10
//  * Enter the Second number: 15
//  * Enter the third number: 20
//  * Enter the four number: 30
//* Expected Output:
//*The average of 10, 15, 20 and 30 is: 18

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

Console.Write("Enter the Third number: ");
string thirdInput = Console.ReadLine();
bool thirdSuccessParse = int.TryParse(thirdInput, out int thirdParsedInput);
if (!thirdSuccessParse || thirdInput == null)
{
    Console.WriteLine("The input is not a number... please enter a valid number!");
}

Console.Write("Enter the Fourth number: ");
string fourthInput = Console.ReadLine();
bool fourthSuccessParse = int.TryParse(fourthInput, out int fourthParsedInput);
if (!fourthSuccessParse || fourthInput == null)
{
    Console.WriteLine("The input is not a number... please enter a valid number!");
}

int avg = (firstParsedInput + secondParsedInput + thirdParsedInput + fourthParsedInput) / 4;

Console.WriteLine($"The avarage of the {firstParsedInput}, {secondParsedInput}, {thirdParsedInput} and {fourthParsedInput} is {avg}");