// to run the file use `dotnet run`
// to nodemon use `dotnet watch`
// for gitignore use `dotnet new gitignore

using System;
using System.Collections.Generic; // allows for using dictionaries and lists

namespace CatWorx.BadgeMaker
{
    class Program
    {
        // Update the method return type
        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                // Move the initial prompt inside the loop, so it repeats for each employee
                Console.WriteLine("Enter first name (leave empty to exit): ");

                // change input to firstName
                string firstName = Console.ReadLine() ?? "";
                if (firstName == "")
                {
                    break;
                }

                // add a Console.ReadLine() for each value
                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine() ?? "";
                Console.Write("Enter ID: ");
                int id = Int32.Parse(Console.ReadLine() ?? "");
                Console.Write("Enter Photo URL:");
                string photoUrl = Console.ReadLine() ?? "";
                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
            }

            return employees;
        }

        // Change the type of the employees parameter
        static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                // each item in employees is now an Employee instance
                Console.WriteLine(employees[i].GetFullName());
            }
        }

        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployees();
            PrintEmployees(employees);
        }
    }
}