﻿using Assignment2_200383477.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_200383477
{
    class Program
    {
        static void Main(string[] args)
        {
            /*task 1*/
            //this instantiates the object with "Class_name student_object= new Class_name"
            Employee employee = new Employee();

            // Setting values on the person object and calling from the student class
            employee.FirstName = "Maulika ";
            employee.LastName = "Desai";
            employee.EmployeePosition = "Developer";
            employee.EmployeeNumber = 200383477;
            employee.salary = 1500;
            Console.WriteLine("Employee Details - {0}", employee);
            Console.WriteLine(employee.ToString());
            Console.WriteLine("press any key to see string array");
            Console.ReadKey();
            
            /*task 2*/
            //Arrays are called here

            string[] strings = new string[] { "Maulika", "Desai", "Computer Programmer Analyst", "Georgian College", "Barrie" };
            int[] integer = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            /*task 3*/

            Arrays arrays = new Arrays();
            arrays.InterateOverStringArrayUsingFor();
            Console.WriteLine("press any key to see number array");
            Console.ReadKey();
            arrays.InterateOverIntegerArrayUsingFor();
            Console.WriteLine("press any key to see object array");
            Console.ReadKey();

            //The arrays having object called
            UsingMethods usingMethods = new UsingMethods();
            usingMethods.ParamArrayMethod("EmployeeNumber:200383477", "FirstName:Maulika", "LastName:Desai", "salary:1500");
            Console.ReadKey();
        }
    }
}
    

