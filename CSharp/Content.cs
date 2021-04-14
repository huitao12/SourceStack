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
        protected string kind;
        private string _title;

        private DateTime createTime { get; }
        public DateTime PublishTime { get; }

        public Content()
        {
            createTime = DateTime.Now;
        }
        public User Author { get; set; }
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

        //之前的Content类，其中的CreateTime（创建时间）和PublishTime（发布时间）都是只读的属性，想一想他们应该在哪里赋值比较好，并完成相应代码
        //在Content之外封装一个方法，可以修改Content的CreateTime和PublishTime
        public Content(DateTime createTime, DateTime PublishTime)
        {
            this.PublishTime = PublishTime;
            this.createTime = createTime;
        }
        //确保文章（Article）的标题不能为null值，也不能为一个或多个空字符组成的字符串，而且如果标题前后有空格，也予以删除
        public string Title
        {
            get { return _title; }
            set
            {
                if (_title.Contains("") || _title.Contains(null) || _title.Contains("   "))
                {
                    _title = _title.Trim(); //.Trim去掉前后两端的空格
                }
                _title = value;
            }
        }


    }
}
