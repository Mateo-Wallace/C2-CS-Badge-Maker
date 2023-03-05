// to run the file use `dotnet run`
// to nodemon use `dotnet watch`
// for gitignore use `dotnet new gitignore

using System;
using System.Collections.Generic; // allows for using dictionaries and lists

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is our employee-getting code now
            List<string> employees = GetEmployees();

            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }

        static List<string> GetEmployees()
        {
            List<string> employees = new List<string>();
            while (true)
            {
                Console.WriteLine("Please enter a name: (leave empty to exit): ");
                string input = Console.ReadLine() ?? "";
                if (input == "")
                {
                    break;
                }

                employees.Add(input);
            }
            // This is important!
            return employees;
        }
    }
}