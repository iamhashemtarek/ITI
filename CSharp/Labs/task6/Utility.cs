using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal static class Utility
    {
        public static void printArrOfEmployees(Employee[] employees) 
        {
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i].ToString());
            }
        }
    }
}
