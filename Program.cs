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
                Console.WriteLine("Please enter a name: (leave empty to exit): ");
                string input = Console.ReadLine() ?? "";
                if (input == "")
                {
                    break;
                }
                Employee currentEmployee = new Employee(input, "Smith");
                // Add currentEmployee, not a string
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