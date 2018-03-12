using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_200383477.models
{
    class Struct
    {


        public struct Mouse
        {
            public string s;
            public readonly string value1;
            public readonly string value2;

            public Mouse(string value1, string value2, string value3) : this() => new Mouse() { s = value1 + value2 + value3 };

        }

    }
}
