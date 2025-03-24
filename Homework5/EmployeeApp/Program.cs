using Domain.Models;
using Domain.Enums;

Employee employee = new Employee("Petko", "Petkovski", RoleEnum.Other, 600);
employee.PrintInfo();

double salary = employee.GetSalary();

SalesPerson salesPerson = new SalesPerson("Stefan", "Stefanovski", 0);
salesPerson.AddSuccessRevenue(2500);
Console.WriteLine(salesPerson.GetSalary());

Manager manager = new Manager("Nikola", "Nikolovski", 600);
manager.PrintInfo(); 
manager.AddBonus(100);
Console.WriteLine(manager.GetSalary());
manager.AddBonus(150);
Console.WriteLine(manager.GetSalary());


Manager manager1 = new Manager("Mona", "Monalisa", 1000);
Manager manager2 = new Manager("Igor", "Igorsky", 1200);
SalesPerson salesPerson1 = new SalesPerson("Lea", "Leova", 0);
Contractor contractor1 = new Contractor("Bob", "Bobert", 160, 10, manager1);
Contractor contractor2 = new Contractor("Rick", "Rickert", 120, 12, manager2);


Employee[] company = new Employee[]
{
    contractor1,
    contractor2,
    manager1,
    manager2,
    salesPerson1
};

CEO ceo = new CEO("Ron", "Ronsky", 100, company);
ceo.AddSharesPrice(14);

Console.WriteLine();
Console.WriteLine("CEO:");
ceo.PrintInfo();
Console.WriteLine($"Salary of CEO is: {ceo.GetSalary()}");
ceo.PrintEmployees();