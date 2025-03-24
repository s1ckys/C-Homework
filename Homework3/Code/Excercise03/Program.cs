while (true)
{
    Console.WriteLine("Please enter your birthdate:");
    bool success = DateTime.TryParse(Console.ReadLine(), out DateTime dateOfBirth);
    if (success)
    {
        int age = AgeCalculator(dateOfBirth);
        Console.WriteLine($"Your age is {age}");
        break;
    }else 
    {
        Console.WriteLine("Invalid input!Please enter a valid date!\n");
    }
}
    int AgeCalculator(DateTime dateOfBirth)
    {
        DateTime currentDateTime = DateTime.Today;
    int age = currentDateTime.Year - dateOfBirth.Year;
    if(dateOfBirth.Date > currentDateTime.AddYears(-age))
    {
        age--;
    }
    return age;
    }