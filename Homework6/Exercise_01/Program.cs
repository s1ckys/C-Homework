//Give the user an option to input numbers
//* After inputing each number ask them if they want to input another with a Y/N question
//* Store all numbers in a QUEUE
//* When the user is done adding numbers print the number in the order that the user entered them from the QUEUE

Console.WriteLine("Please input number and I will put them in a queue!");
Queue<int> queue = new Queue<int>();

void inputNumber()
{
    while (true)
    {
        bool success = int.TryParse(Console.ReadLine(), out int number);
        if (success)
        {
            queue.Enqueue(number);
            break;
        }
        else
        {
            Console.WriteLine("Please enter a valid number!");
            continue;
        }
    }
}

void main()
{
    inputNumber();
    while (true)
    {
        Console.WriteLine("Do you want to add another number ? Y/N");
        string userAnswer = Console.ReadLine();
        if (userAnswer.ToUpper() == "Y")
        {
            Console.WriteLine("Input number:");
            inputNumber();
        }
        else if (userAnswer.ToUpper() == "N")
        {
            Console.WriteLine();
            Console.WriteLine("The numbers in your queue are:\n");
            foreach(int item in queue)
            {
                Console.WriteLine(item);
            }
            break;
        }
        else
        {
            Console.WriteLine("You input is inncorect! Please enter a valid input Y/N!");
            continue;
        }
    }
}

main();