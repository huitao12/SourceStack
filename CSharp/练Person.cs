﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class 练Person
    {
        public 练Person()
        {

        }
        protected internal int Age { get; set; }
        public 练Person(string name)
        {
            Name = name;  
        }
        public 练Person(int  age)
        {
            Age = age;
        }
        internal string Name { get; set; }
        internal void eat()
        {
            Console.WriteLine("吃饭去了……");
        }
    }
}
