using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_200383477.models
{
    class UsingMethods
    {

        //arrays with objects 
        public void ParamArrayMethod(params string[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                string[] keys = list[i].Split(':');
                string key = keys[0];
                string value = keys[1];

                Console.WriteLine($"{key} = {value}");
            }
            Console.WriteLine();
        }
    }
}
