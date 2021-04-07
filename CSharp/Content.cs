using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
   public abstract class Content
    {
        //Content中有一个字段：kind，记录内容的种类（problem/article/suggest等），只能被子类使用
        //确保每个Content对象都有kind的非空值
        //Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
        //其他方法和属性请自行考虑，尽量贴近一起帮的功能实现。
        protected string kind ;
        private DateTime createTime;
        public DateTime PublishTime
        {
            get { return createTime; } 
        }
        public User Author { get; set; }
        public string Title { get; set; }
        public int Reward { get; set; }
        public string Comment { get; set; }
        //public Content(string kind)
        //{
        //    this.kind = kind;
        //}
        public virtual void consume()
        {

        }
        //思考之前的Content类，该将其抽象成抽象类还是接口？为什么？并按你的想法实现。
        //一起帮里的求助总结、文章和意见建议，以及他们的评论，都有一个点赞（Agree）/ 踩（Disagree）的功能，赞和踩都会增减作者及评价者的帮帮点。能不能对其进行抽象？如何实现？
        public abstract void Agree();
        public abstract void Disagree();
        //引入两个子类EmailMessage和DBMessage，和他们继承的接口ISendMessage（含Send()方法声明），用Console.WriteLine()实现Send()。

    }
}
