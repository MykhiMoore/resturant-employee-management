using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resturant_employee_management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant resturant = new Restaurant();

            resturant.AddEmployee(new Employee(1, "jake", "jones", "Manager", 9000, DateTime.Parse("2022-01-15")));
            resturant.AddEmployee(new Employee(2, "john", "james", "chef", 30000, DateTime.Parse("2022-11-15")));
            resturant.AddEmployee(new Employee(3, "justin", "biber", "assisstant manager", 70000, DateTime.Parse("2022-10-19")));
            resturant.AddEmployee(new Employee(4, "shawn", "taylor", "waiter", 30000, DateTime.Parse("2022-04-12")));

            resturant.DisplayAllEmployees();

            Console.ReadLine();

        }



    }
}
