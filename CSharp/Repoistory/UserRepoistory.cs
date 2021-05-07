using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace CSharp.Repoistory
{
   public  class UserRepoistory
    {
        #region 
        //作业
        //将之前ASP.NET项目中以下Repository方法用ADO.NET实现：

        //注册/登录
        //内容：
        //发布/修改
        //单页呈现
        //列表页呈现（包括：过滤/分页）
        //批量标记Message为已读
        //……
        #endregion
        //连接数据库 connection
        string connectionString =@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bang;Integrated Security=True";

        public void Save(User user)//注册
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"insert [User](Username,Password) values(N'{user.Name}',N'{user.Password}')";
                command.ExecuteNonQuery();
            }
        }

        public void GetbyName(string name)//登录
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"select [Password]  from [User] where [UserName]=@name";
                DbParameter pName = new SqlParameter("@name", name);
                command.Parameters.Add(pName);

                string dbPassWord = command.ExecuteScalar()?.ToString();

                if (dbPassWord == null)
                {
                    Console.WriteLine("用户名不存在");
                    return;
                }
                //User user = new User();
                //if (dbPassWord != user.Password)
                //{
                //    Console.WriteLine("用户名或密码错误");
                //    return;
                //}

            }
        }
    }
}
