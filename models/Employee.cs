using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_200383477.models
{
    class Employee
    {

        public Employee() { }
        public Employee(string fname, string lname, string position, int employeeNumber, double salary)
        {
            FirstName = fname;
            LastName = lname;
            EmployeePosition = position;
            EmployeeNumber = employeeNumber;
            Salary = salary;

        }

        //sets the property for first name of the employee and returns it
        public String FirstName { get; set; }
        //sets the property for last name of the employee and returns it
        public String LastName { get; set; }
        //sets the property for position of the employee and returns it
        public String EmployeePosition { get; set; }
        //sets the property for employee number of the employee and returns it
        public int EmployeeNumber { get; set; }
        //sets the property for salary of the employee and returns it
        public Double Salary { get; set; }

        //this property returns the data into a string of objects
        public override string ToString()
        {
            return "\nEmployee Name: " + FirstName + LastName + " \nPosition: " + EmployeePosition + " \nEmployee Number: " + EmployeeNumber + " \nWeekly Salary: $" + Salary;
        }
    }
}
