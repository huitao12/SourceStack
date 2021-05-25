using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace CSharp.Entities
{
    [Index("CreateTime", IsUnique = true)]
    public sealed class User : Entity, ISendMessage, IChat //让USer无法被继承
    {
        //public int Id { get; set; }

        //[Key]设置主键
        [Required(ErrorMessage = "*用户名不能为空")]
        public string Name { get; set; }
        public bool IsMale { get; set; }
        public string Introduction { get; set; }

        [MinLength(4, ErrorMessage = "*密码至少4个字符")]//不能为空
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public User Invitedby { get; set; }

        [StringLength(4, MinimumLength = 4, ErrorMessage = "*邀请码只能是4位数字")]
        public string InviteCode { get; set; }

        [NotMapped]//不映射到数据库
        public int FailedTry { get; set; }//添加尝试登陆失败次数

        public DateTime? CreateTime { get; set; }
        public int BCredit { get; set; }

        public void Register()
        {
            Invitedby.BCredit += 10;
        }









        #region
        //#region 类和对象
        ////https://17bang.ren/Article/305
        ////作业
        ////观察“一起帮”的：
        ////注册 / 登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
        ////求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
        ////帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
        ////为这些类的字段和方法设置合适的访问修饰符。
        //#endregion
        //public User Invitedby { get; set; }

        //public void Register()
        //{

        //}

        //public void Login()
        //{

        //}
        //public User()
        //{

        //}
        void ISendMessage.Send()
        {
            Console.WriteLine("ISendMessage");
        }

        public void Send()
        {
            Console.WriteLine("IChat");
        }

        //void IChat.Send()
        //{
        //    Console.WriteLine("IChat");
        //}





        ////将之前User / Problem / HelpMoney类的字段封装成属性，其中：
        ////  user.Password在类的外部只能改不能读
        //private string _Password;
        //internal string Password
        //{
        //    set { _Password = value; }
        //    get { return _Password; }
        //}

        ////  problem.Reward不能为负数
        ////调用这些类的有参 / 无参构造函数，生成这些类的对象，调用他们的方法
        //// 一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
        ////设计一种方式，保证：
        ////  每一个Problem对象一定有Body赋值
        ////  每一个User对象一定有Name和Password赋值
        ////public User(string name, string Psaaword)
        ////{
        ////    name = this.name;
        ////    Password = _Password;
        ////}

        ////User类中添加一个Tokens属性，类型为TokenManager
        //public TokenManager Tokens { get; set; }


        ////作业：
        ////确保文章（Article）的标题不能为null值，也不能为一个或多个空字符组成的字符串，而且如果标题前后有空格，也予以删除
        ////  如果user.Name为“admin”，输入时修改为“系统管理员”
        ////设计一个适用的机制，能确保用户（User）的昵称（Name）不能含有admin、17bang、管理员等敏感词。
        //private string name;
        //internal string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        if (value.Contains("admin") || value.Contains("17bang") || value.Contains("管理员"))
        //        {
        //            Console.WriteLine("你输入的名字有敏感词");
        //        }
        //        else
        //        {
        //            name = value;
        //        }
        //    }
        //}








        #endregion

    }
}
