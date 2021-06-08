using CSharp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class BMoney : Entity
    {
        public DateTime LatestTime { get; set; }//最近时间
        public int Usable { get; set; }//可用
        public int Freeze { get; set; }//冻结
        public string Kind { get; set; }//种类
        public int Change { get; set; }//变化
        public string Reason { get; set; }//理由
    }
}
