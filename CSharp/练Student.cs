using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class 练Student:练Person
    {
        public void Greet(string name)
        {

            Console.WriteLine($"傻子{name}");
        }
    }
}
