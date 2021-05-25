using CSharp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class HelpMoney : Entity
    {
        //帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
        public DateTime time { get; set; }
        public int usable { get; set; }
        public int freeze { get; set; }
        public string kind { get; set; }
        public int change { get; set; }
        public string comment { get; set; }

        public void BMoney()
        {

        }

    }
}
