using Domain.Enums;

namespace Domain.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(string firstName, string lastName, double workHours, int payPerHour, Manager responsible)
            : base(firstName, lastName, RoleEnum.Contractor, 0) 
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour; 
            return Salary;
        }

        public string CurrentPosition()
        {
            return Responsible.Role.ToString(); 
        }
    }
}