// Import correct packages
using System;
using System.IO;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Util
    {
        // Add List parameter to method
        public static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
            }
        }

        public static void MakeCSV(List<Employee> employees)
        {
            // Check to see if folder exists
            if (!Directory.Exists("data"))
            {
                // If not, create it
                Directory.CreateDirectory("data");
            }
        }
    }
}