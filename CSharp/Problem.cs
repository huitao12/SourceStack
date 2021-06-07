using CSharp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class Problem : Content
    {
        public string Title { get; set; }

        private int _Reward;
        public DateTime PublishDateTime { get; set; }
    
        public int Reward
        {
            get { return _Reward; }
            set
            {
                if (value < 0)
                {
                    //Console.WriteLine("不能为负数");
                    //return;
                    throw new Exception("参数越界");
                }
                else
                {
                    _Reward = value;
                }
            }
        }

     
    }
}
