string[] studentsG1 = new string[] {"Zdravko", "Petko", "Stanko", "Branko", "Trajko"};
string[] studentsG2 = new string[] {"Marko", "Darko", "Zarko", "Gjorgji", "Pero"};

Console.WriteLine("Enter student group: ( there are 1 and 2 )");
bool success = int.TryParse(Console.ReadLine(), out int groupNumber);
if (success)
{
    if (groupNumber == 1)
    {
        Console.WriteLine("The students in G1 are: ");
        foreach (string student in studentsG1)
        {
            Console.WriteLine(student);
        }
    }
    else if (groupNumber == 2)
    {
        Console.WriteLine("The students in G2 are: ");
        foreach (string student in studentsG2)
        {
            Console.WriteLine(student);
        }
    }
    else
    {
        Console.WriteLine("Please enter valid group number!");
    }
}
else
{
    Console.WriteLine("Please enter valid number!");
}
Console.ReadLine();