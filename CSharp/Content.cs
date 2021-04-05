using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
   public class Content
    {
        //Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
        //确保每个Content对象都有kind的非空值
        //Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
        //其他方法和属性请自行考虑，尽量贴近一起帮的功能实现。
        protected string kind ;
        private DateTime createTime;
        public DateTime PublishTime{get;}
        public User Author { get; set; }
        public string Title { get; set; }
        public int Reward { get; set; }
        public string Comment { get; set; }
        //public Content(string kind)
        //{
        //    this.kind = kind;
        //}
    }
}
