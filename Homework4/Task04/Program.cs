using Task04;

Car[] Cars = new Car[]
    {
        new Car("Hyundai", 120),
        new Car("Mazda", 130),
        new Car("Ferrari", 200),
        new Car("Porsche", 190)
    };

Driver[] Drivers = new Driver[]
{
        new Driver("Bob", 3),
        new Driver("Greg", 4),
        new Driver("Jill", 2),
        new Driver("Anne", 5)
};

void RaceCars(Car car1, Car car2)
{
    int car1Speed = car1.CalculateSpeed();
    int car2Speed = car2.CalculateSpeed();

    if (car1Speed > car2Speed)
    {
        Console.WriteLine($"The {car1.Model} driven by {car1.Driver.Name} won with a speed of {car1Speed}!");
    }
    else if (car2Speed > car1Speed)
    {
        Console.WriteLine($"The {car2.Model} driven by {car2.Driver.Name} won with a speed of {car2Speed}!");
    }
    else
    {
        Console.WriteLine("It's a tie!");
    }
}

int GetChoice(int maxOption)
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= maxOption)
        {
            return choice - 1;
        }
        else
        {
            Console.WriteLine($"Invalid input. Please enter a number between 1 and {maxOption}.");
        }
    }
}

int GetSecondChoice(int firstCarIndex, int maxOption)
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int secondCarIndex) && secondCarIndex >= 1 && secondCarIndex <= maxOption)
        {
            if (secondCarIndex - 1 == firstCarIndex)
            {
                Console.WriteLine("Cannot use the same car twice. Please choose again!");
            }
            else
            {
                return secondCarIndex - 1;
            }
        }
        else
        {
            Console.WriteLine($"Invalid input. Please enter a number between 1 and {maxOption}.");
        }
    }
}


bool raceAgain = true;

while (raceAgain)
{
    Console.WriteLine("Choose a car no.1:");
    for (int i = 0; i < Cars.Length; i++)
    {
        Console.WriteLine($"{i + 1}: {Cars[i].Model}");
    }
    int car1Index = GetChoice(Cars.Length); ;

    Console.WriteLine("Choose Driver for car no.1:");
    for (int i = 0; i < Drivers.Length; i++)
    {
        Console.WriteLine($"{i + 1}: {Drivers[i].Name}");
    }
    int driver1Index = GetChoice(Drivers.Length);
    Cars[car1Index].Driver = Drivers[driver1Index];

    Console.WriteLine("Choose a car no.2:");
    for (int i = 0; i < Cars.Length; i++)
    {
        if (i != car1Index)
            Console.WriteLine($"{i + 1}: {Cars[i].Model}");
    }
    int car2Index = GetSecondChoice(car1Index, Cars.Length);

    Console.WriteLine("Choose Driver for car no.2:");
    for (int i = 0; i < Drivers.Length; i++)
    {
        Console.WriteLine($"{i + 1}: {Drivers[i].Name}");
    }
    int driver2Index = GetChoice(Drivers.Length);
    Cars[car2Index].Driver = Drivers[driver2Index];

    RaceCars(Cars[car1Index], Cars[car2Index]);

    for (; ; )
    {
        Console.WriteLine("Do you want to race again? (Yes/No)");
        string userExit = Console.ReadLine();
        if (userExit.ToLower() == "no")
        {
            raceAgain = false;
            break;
        }
        else if (userExit.ToLower() == "yes")
        {
            raceAgain = true;
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter Yes/No!\n");
            continue;
        }
    }
}

Console.WriteLine("Thanks for racing!");
    

