using CSharp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class Problem : Content
    {
        public string Title { get; set; }

        public DateTime PublishDateTime { get; set; }

        //一篇求助可以对应多个关键字
        public IList<Keyword> Keywords { get; set; }
        //一篇求助可以对应多个评论
        public IList<Comment> Comments { get; set; }

        private int _Reward;
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
