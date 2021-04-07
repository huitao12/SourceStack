using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
  public  class Problem:Content
    {
        //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
        public string Title { get; set; }
        public string _Body { get; set; }
        private int _Reward;
        public DateTime PublishDateTime { get; set; }
        public User Author { get; set; }
        private string repoistory;
        public void Publish()
        {

        }
        public void Load(int id)
        {

        }
        public void Delete(int id)
        {

        }
        //  problem.Reward不能为负数
        internal int Reward
        {
            get { return _Reward; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("不能为负数");
                    return;
                }
                else
                {
                    _Reward = value;
                }
            }
        }

        // 一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
        //设计一种方式，保证：
        //  每一个Problem对象一定有Body赋值
        public Problem(string Body)
        {
            _Body = Body;
        }
        //  每一个User对象一定有Name和Password赋值


        private string[] keyword;
        public Problem(int length)
        {
            keyword = new string[length];
        }
        public string this[int index]
        {
            get
            {
                return keyword[index - 1];
            }
            set
            {
                keyword[index - 1] = value;
            }
        }
        public Problem()
        {

        }
        public override void consume()
        {
            Console.WriteLine("需要消耗其设置悬赏数量的帮帮币");
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
