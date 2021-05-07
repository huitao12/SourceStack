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

        public  IList<Comment> Comment { get; set; }

        public IList<Appraise> Appraise { get; set; }

        public IList<Keyword> keyword { get; set; }

    }
}
