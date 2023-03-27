using Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Contractor : Employee
    {
        protected double WorkHours { get; set; }
        protected int PayPerHour { get; set; }
        public object Responsible { get; set; }

        public Contractor(string firstName, string lastName, double workHours, int payPerHour, object responsible) : base(firstName, lastName)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }
        public override double GetSalary()
        {
            return Salary = WorkHours * PayPerHour;
        }
        public void CurrentPosition()
        {
        }
    }
}
