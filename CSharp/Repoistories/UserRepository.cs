using CSharp.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using E = CSharp.Entities;

namespace CSharp.Repoistories
{
    public class UserRepository
    {
        //作业
        //将之前ASP.NET项目中以下Repository方法用ADO.NET实现：
        //注册/登录
        //内容：
        //发布/修改
        //单页呈现
        //列表页呈现（包括：过滤/分页）
        //批量标记Message为已读
        //……
        //连接数据库 connection
        //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bang;Integrated Security=True";
        //#region 登录 注册保存
        //public int Save(User user)
        //{
        //    using (IDbConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        IDbCommand command = new SqlCommand();
        //        command.Connection = connection;
        //        command.CommandText =
        //            $"insert [User](Username,Password) " +
        //            $"values(N'{user.Name}',N'{user.Password}');" +
        //            "select @@identity";
        //        object id = command.ExecuteScalar();
        //        Console.WriteLine(id);
        //        return (int)id;
        //    }
        //}
        //#endregion

        //#region 登录  获取登录
        //internal void GetbyName(string name)
        //{
        //    using (IDbConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        IDbCommand command = new SqlCommand();
        //        command.Connection = connection;
        //        command.CommandText = $"select [Password]  from [User] where [UserName]=@name";
        //        IDataParameter pName = new SqlParameter("@name", name);
        //        command.Parameters.Add(pName);

        //        string dbPassWord = command.ExecuteScalar()?.ToString();

        //        if (dbPassWord == null)
        //        {
        //            Console.WriteLine("用户名不存在");
        //            return;
        //        }
        //        User user = new User() /*{Password="11" }*/;
        //        if (dbPassWord != user.Password)
        //        {
        //            Console.WriteLine("用户名或密码错误");
        //            return;
        //        }

        //    }
        //}
        //#endregion
        private static IList<User> users ;
        static UserRepository()
        {
            users = new List<User>
            {
                new User
                {
                    Id=1,
                    Name="消息",
                    Password="1234",
                    InviteCode="1111",
                },
            };
        }

        public UserRepository()
        {
        }

        public int ArticleCount { get; set; }

        public User Find(int id)
        {
            return users.Where(u => u.Id == id).SingleOrDefault();
        }

        public IList<User> Get(int pageIndex, int pageSize)
        {
            return users.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }

        void Delete()
        {

        }
       public void Save(User user )
        {
            users.Add(user);
        }

        public User GetByName(string name)
        {
            return users.Where(u => u.Name == name).SingleOrDefault();
        }
    }
}
