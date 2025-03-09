int[] numberArray = new int[] {};
int sum = 0;

Console.WriteLine("Input 6 integers and get the sum of all the even integers.\n");
bool successInputOfAllInts = true;
for(int i = 0; i<=5; i++)
{
    Console.WriteLine("Enter integer no." + (i + 1));
    bool success = int.TryParse(Console.ReadLine(), out int number);
    if (success)
    {
        Array.Resize(ref numberArray, numberArray.Length + 1);
        numberArray[i] = number;
    }
    else
    {
        Console.WriteLine("Please enter a valid number!!");
        successInputOfAllInts = false;
        break;
    }
}

if (successInputOfAllInts)
{
    foreach (int item in numberArray)
    {
        if (item % 2 == 0)
        {
            sum += item;
        }
    }

    Console.WriteLine("The result is " + sum);
}
Console.ReadLine();