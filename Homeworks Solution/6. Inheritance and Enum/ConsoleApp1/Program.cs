

//Extend the exercise for Employees with two more Employees. ??

//A new method called CurrentPosition should return the department of the manager that is responsible for this Contractor // Department??

using ConsoleApp1.Models;
using Domain.Classes;

Manager peco = new Manager("Peco ", "Pecevski", 2300);
Manager bob = new Manager("Bob", "Bobovski", 2800);


Employee[] arrOfEmployees = { new Contractor("Jill", "Jilovski", 175, 8, peco), new Contractor("Martin", "Martinovski", 165, 9, bob), new Manager("Goran", "Pandev", 4500), new Manager("Kristijan", "Markovski", 3000), new SalesPerson("Mario", "Mariovski") };

//Contractor sime = new Contractor("Sime", "Smilevski", 200, 12, bob);
//if (sime.Responsible is Manager manager)
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine($"Responsible: {manager.FirstName} {manager.LastName}");
//    Console.ForegroundColor = ConsoleColor.White;
//}




CEO viktor = new CEO("Viktor", "Jankov", 5000, arrOfEmployees, 130);

Console.WriteLine(viktor.GetInfo());
viktor.PrintEmployees();
viktor.AddSharesPrice(20);
Console.WriteLine(viktor.GetSalary());