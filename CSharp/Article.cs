using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class Article : Content 
    {
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
    }
}
