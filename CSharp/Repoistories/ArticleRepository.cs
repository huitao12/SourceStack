using CSharp.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using E = CSharp.Entities;

namespace CSharp.Repoistories
{
    public class ArticleRepository
    {
        //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bang;Integrated Security=True";

        //public void Svae(Article article)//发布
        //{
        //    using (IDbConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        IDbCommand command = new SqlCommand();
        //        command.Connection = connection;
        //        command.CommandText = $"insert Article(Title) values(N'{article.Title}')";
        //        command.ExecuteNonQuery();
        //    }
        //}


        //public Article GetById(int id)//单页呈现
        //{
        //    Article article = new Article();
        //    using (IDbConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        IDbCommand command = new SqlCommand();
        //        command.Connection = connection;
        //        command.CommandText = $"select [Userame],Id from Article where Id={id} ";
        //        IDataReader reader = command.ExecuteReader();
        //        reader.Read();
        //        while (reader.Read())
        //        {
        //            for (int i = 0; i < reader.FieldCount; i++)
        //            {
        //                Console.WriteLine(reader[i]+" ");
        //            }
        //            Console.WriteLine();
        //        }

        //    }

        //    return article;
        //}

        private static IList<E.Article> articles;
        static ArticleRepository()
        {
            articles = new List<Article>
            {
                new Article
                {
                    Id=1,
                    Title=@"知乎，这一次是真的决定离开",
                    Body=@"  起因查了一下，从2015年7月知乎首答：5年多的时间，9万+的关注，8万+的收藏，15万+的赞同，勉勉强强算一个小V吧：忽然发现，
                            从赞/关注/收藏的比例来看，很多同学对我关注胜于赞同。大概就是：不赞同我的观点，但感兴趣我这个人，或者我写的东西大家愿
                            意收藏起来慢慢看。当然我也知道：“以后再看”≈“不看”，^_^离开知乎的诱因是昨天晚上，我的一个小号突然：申诉无果：看标题
                            就知道，这是纯粹的技术文章。 其实最初我是不想发布到知乎的，因为太“干”，看的人肯定很少。而且确实是我在开始做培训班之后，
                            “呕心沥血”整理出来",
                   Author= new User
                   {
                     Id = 1,
                     Name = "大飞哥",
                   },
                   PublishTime=new DateTime(2020,2,2,2,2,2),
                },
                new Article
                {
                    Id=2,
                    Title=@"高阶：泛型/集合/Lambda/异常/IO/多线程",
                    Body=@" 泛型可以有泛型方法/类等，同C#可以有约束public class Student<T extends IMajor>extends Person {子类继承时：public 
                            class OnlineStudent<T extends IMajor>extends Student<T>{协变/逆变通配符：？实现extends：协变（out）super：逆变
                            （in）Optional 类对应NullableOptional<Integer> age =",
                   Author= new User
                   {
                     Id = 2,
                     Name = "小哥",
                   },
                   PublishTime=new DateTime(2020,3,3,3,3,3),
                },
                  new Article
                {
                    Id=3,
                    Title=@"异步：方法和TPL:async/await/Parallel",
                    Body=@" 封装我们要把上面这个Task封装成方法，怎么办？最重要的一点，这个方法要能返回生成的random，后面的代码要用！public static
                            Task<int>getRandom(){return Task<int>.Run(() =>{Thread.Sleep(500); //模拟耗时return new Random().Next();});}
                            @@想一想@@：应该如何调用这个方法？（提示：不要直接getRandom().Result） 假如我们还需要进一步的封装，添加",
                   Author= new User
                   {
                     Id = 3,
                     Name = "大哥",
                   },
                   PublishTime=new DateTime(2020,4,4,4,4,4),
                },
                new Article
                {
                    Id=4,
                    Title=@"HTTP协议：Get&Post / 无状态 / 安全漏洞",
                    Body=@" 常见面试题：GET和POSTHTTP协议客户端和服务器端交互的信息分为：：Request/Response：实际上，用户在浏览器中输入URL，回车，
                            浏览器就会向服务器发送一个请求（Request）；然后，服务器就会响应（Response）这个请求，将相应的HTML文件返回给浏览器。Header/Body：
                            无论是Request和Response，除了URL和Html文件，还有一些额外的信息，存放在他们的Header中。GET和POST就是定义在Request的Header中的，
                            向服务器说明，用何种方式方法",
                   Author= new User
                   {
                     Id = 4,
                     Name = "大哥",
                   },
                   PublishTime=new DateTime(2020,4,4,4,4,4),
                },
                new Article
                {
                    Id=5,
                    Title=@"SQL：稳得一匹，以及其他语言：",
                    Body=@" PHP梗：最好的语言简单/免费/开源脚本语言Javascript：生于仓促，兴于风口VBScript：主要适用于ASPTypeScript：JavaScript的改良版，
                            但是……语言发展的趋势 简单：远离硬件和底层，更接近人类的自然语言 ",
                   Author= new User
                   {
                     Id = 5,
                     Name = "大哥",
                   },
                   PublishTime=new DateTime(2020,4,4,4,4,4),
                },
            };
        }

        public ArticleRepository()
        {
        }

        public int ArticleCount { get; set; }

        public Article Find(int id)
        {
            return articles.Where(a => a.Id == id).SingleOrDefault();
        }

        public IList<Article> Get(int pageIndex, int pageSize)
        {
            return articles.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
        }
        public IList<Article> Get()
        {
            return articles;
        }
        //void Delete()
        //{

        //}
       public void Save(Article article)
        {
            articles.Add(article);
        }
    }
}


