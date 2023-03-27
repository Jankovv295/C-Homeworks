using Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Make a new class CEO that inherits from Employee that will have a property Employees ( an array of Employees), Shares property ( int ), SharesPrice ( double )
//The shares price should not be accessed from outside of the class
//There should be a method called AddSharesPrice() that will accept a double number and it will change the SharesPrice. This is the only way to change SharesPrice

//The CEO should have a method called PrintEmployees() that will print all employees that work for his company.
//The CEO should override the GetSalary method to return Salary + Shares * SharesPrice
//Create a new instance of CEO and call: ceoName.PrintInfo(), ceoName.PrintEmployees() and ceoName.GetSalary() to check if everything is working.


namespace ConsoleApp1.Models
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; } 
        public CEO() { }
        public CEO(string firstName, string lastName, double salary, Employee[] employees, int shares)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Employees = employees;
           Shares = shares;
            Role = RoleEnum.Other;
        }
        public void AddSharesPrice(double number)
        {
            SharesPrice = number;
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
            return Salary + Shares * SharesPrice;
        }
    }
}

