﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _004_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee { FirstName = "Ivan", LastName = "Ivanov", Salary = 94000, StartDate = DateTime.Parse("1/4/1992") },
                new Employee { FirstName = "Petr", LastName = "Petrov", Salary = 123000, StartDate = DateTime.Parse("12/3/1985") },
                new Employee { FirstName = "Andrey", LastName = "Andreev", Salary = 1000000, StartDate = DateTime.Parse("1/12/2005") }
            };

            var topSalaryEmployees = from e in employees
                                     where e.Salary > 100000
                                     select e;
            
            foreach (var item in topSalaryEmployees)
            {
                Console.WriteLine("FirstName = {0}, LastName = {1}",
                                   item.FirstName, item.LastName);
            }

            Console.ReadKey();
        }
    }
}
