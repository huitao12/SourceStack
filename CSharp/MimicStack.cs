using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class MimicStack
    {
        //自己实现一个模拟栈（MimicStack）类，入栈出栈数据均为int类型，包含如下功能：
        //出栈Pop()，弹出栈顶数据
        //入栈Push()，可以一次性压入多个数据
        //出 / 入栈检查，
        //如果压入的数据已超过栈的深度（最大容量），提示“栈溢出”
        //如果已弹出所有数据，提示“栈已空”

        private int top;
        private int buttom;
        private object[] arr=new object[5];
     

        public void Push(Object element)
        {
            if (top <= arr.Length - 1)
            {
                element = arr[top];
                top++;
            }
            else
            {
                Console.WriteLine("栈溢出");
            }
        }


        public void Pop()
        {
            if (top != buttom)
            {
                top--;
                Console.WriteLine(arr[top]);
            }
            else
            {
                Console.WriteLine("栈已空");
            }
        }
    }
}
