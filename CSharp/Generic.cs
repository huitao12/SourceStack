using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Generic<T> where T : IComparable
    {
        //作业：
        //改造Entity类，让其Id可以为任意类型
        //用泛型改造二分查找、堆栈和双向链表
        public void Dchotomy(T[] array, T target)
        {
            int left = 0, right = array.Length - 1;
            bool result = false;
            int middle = (left + right) / 2;
            while (left <= right)
            {
                //compareTo是将当前对象与参数 o 这个对象比
                //如果你觉得这个时候应该是当前对象大，就返回个正值
                //如果你觉得这个时候应该是 o 大，就返回个负值
                //如果你觉得这个时候应该是一样大，就返回个0
                middle = (left + right) / 2;
                if (target.CompareTo(array[middle]) > 0) //CompareTo判断大小  如果target比array[middle]大
                {
                    left = middle + 1;
                }
                else if (target.CompareTo(array[middle]) < 0)
                {
                    right = middle - 1;
                }
                else//target=array[middle]
                {
                    result = true;
                    break;
                }
            }
            if (result)
            {
                Console.WriteLine(middle);
            }
            else
            {
                Console.WriteLine("没找到");
            }
        }

        //用泛型改造“取数组中最大值”（提示：IComparable）
        public void GetMax(T[] grade,T max) {
            //double[] grade = { 32.3, 54.6, 76.7, 26.7, 98.01, 23.7, 14.1, 111 };
            //double max = T[0];
            for (int i = 0; i<grade.Length; i++)
        {
            if (grade[i].CompareTo(max)>0)
            {
                max = grade[i];
            }//else contiune
        }
        Console.WriteLine(max);
        }
        //用代码演示泛型接口的协变/逆变

    }
}
