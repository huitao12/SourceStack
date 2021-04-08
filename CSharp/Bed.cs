using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public struct Bed //由struct定义的是值类型
    {
        public int _number;//字段必须赋值
        public double Price { get; set; }//要给自动属性赋值
        //public Bed()//结构不能够包含显示的无参构造函数
        //{
        //}
        public Bed(int number)
        {
            _number = number;
            Price = 23.5;
        }
    }

    public class Beds //由class 定义的是引用类型
    {
        public int _number;
        public double Price { get; set; }
        public Beds()
        {

        }
    }
}
