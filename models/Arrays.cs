using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_200383477.models
{

    class Arrays
    {
        //The string arrays having details 
        string[] strings = new string[] { "Maulika", "Desai", "Computer Programmer", "Georgian College", "Barrie" };
        int[] integer = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


    
        public void ArrayOfObjects()
        {
            Employee[] employees = new Employee[5];
            employees[0] = new Employee("Maulika", "Desai", "Manager", 1, 456.56);
            employees[1] = new Employee("Komal", "Bhanderi", "Crew Member", 2, 343.34);



            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i].ToString());
            }
        }


        public void InterateOverStringArrayUsingFor()
        {
            //for loop
            for (int x = 0; x < strings.Length; x++)
            {
                Console.WriteLine(strings[x]);
            }

            //for each loop
            foreach (string element in strings)
            {
                System.Console.WriteLine(element);
            }

            //do-while loop
            int s = 0;
            do
            {
                s++;
                Console.WriteLine(strings[s]);
            }
            while (s < strings.Length)
        }

        //The integer arrays 
        public void InterateOverIntegerArrayUsingFor()
        {
            //for loop
            for (int x = 0; x < integer.Length; x++)
            {
                Console.WriteLine(integer[x]);
            }

            //for each loop
            foreach (int element in integer)
            {
                System.Console.WriteLine(element);
            }

            //do-while loop
            int i = 0;
            do
            {
                i++;
                Console.WriteLine(integer[i]);
            }
            while (i < integer.Length)
        }
    }
}
