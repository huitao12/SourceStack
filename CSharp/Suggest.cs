using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
   public class Suggest:Content
    {
        public Suggest()
        {

        }

        public override void Agree()
        {
            throw new NotImplementedException();
        }

        public override void consume()
        {
            Console.WriteLine("不需要消耗帮帮币");
        }

        public override void Disagree()
        {
            throw new NotImplementedException();
        }
    }
}

