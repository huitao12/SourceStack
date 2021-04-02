using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class User
    {
        #region 类和对象
        //https://17bang.ren/Article/305
        //作业
        //观察“一起帮”的：
        //注册 / 登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
        //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
        //帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
        //为这些类的字段和方法设置合适的访问修饰符。
        #endregion
        public User Invitedby { get; set; }

        public void Register()
        {

        }

        public void Login()
        {

        }
        //将之前User / Problem / HelpMoney类的字段封装成属性，其中：
        //  user.Password在类的外部只能改不能读
        private string _Password;
        internal string Password
        {
            set { _Password = value; }
            //private get { }
        }
        //  如果user.Name为“admin”，输入时修改为“系统管理员”
        private string _name;
        internal string name
        {
            get { return _name; }
            set
            {
                if (value == "admin")
                {
                    _name="系统管理员";
                }
                else
                {
                    _name = value;
                }
            }
        }
        //  problem.Reward不能为负数
        //调用这些类的有参 / 无参构造函数，生成这些类的对象，调用他们的方法
        // 一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
        //设计一种方式，保证：
        //  每一个Problem对象一定有Body赋值
        //  每一个User对象一定有Name和Password赋值
        public User(string name,string Psaaword)
        {
            name = _name;
            Password = _Password;
        }






    }
}
