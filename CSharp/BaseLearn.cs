using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class BaseLearn
    {
        //public static int GetMax(int[] array)
        //{
        //    return 55;
        //    //throw new NotImplementedException();//异常
        //}

        //public static int GetMix(int[] array)
        //{
        //    return -1;
        //}

        //为之前作业添加单元测试，包括但不限于：
        //数组中找到最大值
        public static int GetMax(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }//else contiune
            }
            return max;
        }

        //找到100以内的所有质数
        public static int GetPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                bool isprime = true;//isprime是质数还是不是质数
                for (int j = 2; j < i - 1; j++) //判断当前判断的数字是不是质数
                {
                    if (i % j == 0) //说明不是质数
                    {
                        isprime = false;//不是质数
                        break;
                    }
                }
                if (isprime)//是质数
                {
                    //Console.WriteLine(i);
                    return i;
                }
            }
            return -1;
        }
        //猜数字游戏
        public static void Guess() { }

        //二分查找
        public static int Target()
        {
            int[] array = { 2, 6, 9, 12, 16, 23, 44, 49, 55, 66 };
            int target = 2, left = 0, right = array.Length - 1;
            int middle = (left + right) / 2;
            while (left <= right)
            {
                middle = (left + right) / 2;
                if (target > array[middle])
                {
                    left = middle + 1;
                }
                else if (target < array[middle])
                {
                    right = middle - 1;
                }
                else//target=array[middle]
                {
                    Console.WriteLine(middle);
                    break;
                }
            }
            return -1;
        }
        //栈的压入弹出
    }
}
