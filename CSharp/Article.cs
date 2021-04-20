using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{    //文章 
    public class Article : Content 
    {
        public string name { get; set; }
        public Article()
        {
        }
        public void Search(string keword)
        {

        }
        public override void consume()
        {
            Console.WriteLine("需要消耗一个帮帮币");
        }

        public override void Agree()
        {
            throw new NotImplementedException();
        }

        public override void Disagree()
        {
            throw new NotImplementedException();
        }

        //一篇文章可以有多个评论
        public  IList<Comment> Comment { get; set; }

        //每个文章和评论都有一个评价
        public IList<Appraise> Appraise { get; set; }

        //一篇文章可以有多个关键字，一个关键字可以对应多篇文章
        public IList<Keyword> keyword { get; set; }

    }
}
