using Domain.Enums;

namespace Domain.Models
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; private set; }
        private double SharesPrice { get; set; }

        public CEO(string firstName, string lastName, int shares, Employee[] employees)
            : base(firstName, lastName, RoleEnum.CEO, 1500) 
        {
            Shares = shares;
            Employees = employees;
            SharesPrice = 0; 
        }

        public void AddSharesPrice(double amount)
        {
            SharesPrice = amount;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("Employees:");
            foreach (var employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }

        public override double GetSalary()
        {
            return Salary + (Shares * SharesPrice);
        }
    }
}