using CSharp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using static CSharp.Person;

namespace CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {



            #region EF
            //SqlDbContext context = new SqlDbContext();

            ////利用EF，插入3个User对象
            //User user = new User
            //{
            //    Name = "灰灰",
            //    Password = "121"
            //};
            //User user1 = new User
            //{
            //    Name = "黑鬼",
            //    Password = "1211",
            //};
            //User user2 = new User
            //{
            //    Name = "桌子",
            //    Password = "1212"
            //};
            //context.Users.Add(user);
            //context.Add(user1);
            //context.Add<User>(user2);

            //通过主键找到其中一个User对象
            //User user = context.Find<User>(11);
            //Console.WriteLine(user.Name);

            ////修改该User对象的Name属性，将其同步到数据库
            //user.Name = "板凳";

            ////不加载User对象，仅凭其Id用一句Update SQL语句完成上题
            //User user1 = new User() { Id = 11 };
            //context.Attach<User>(user1);//默认Unchanged
            //user1.Name = "小胖";//好处  之改动这一列


            //////删除该用户
            //context.Remove<User>(user1);

            //context.SaveChanges();//保存改动，存到数据库


            //Database属性从何而来？
            //var db = context.Database;

            ////类似于Update-Database: apply all pending migrations
            ////本身不生成Migrations
            //db.Migrate();

            ////Enusure：存在才删除，不存在才创建
            //db.EnsureDeleted();
            ////Create数据库的同时建立表结构，
            //db.EnsureCreated();


















            UserRepository l = new UserRepository();
            l.GetbyName("鬼娃");

            //UserRepoistory p = new UserRepoistory();
            //p.Save(new User() { Name = "阿萨", Password = "111" ,Invitedby="小"});

            //ArticleRepository article = new ArticleRepository();
            //article.Svae(new Article() { Title = "阿斯顿" });
            //new ArticleRepository().Svae(new Article() { Title = "阿斯顿" });


            //ArticleRepository article1 = new ArticleRepository();
            //article1.GetById(1);
            #endregion

            #region 运算符和表达式作业
            //https://17bang.ren/Article/292
            //1.输出两个整数 / 小数的和 / 差 / 积 / 商
            //int a = 22, b = 23;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);

            //double a = 22.5, b = 33.5;
            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);

            //2.电脑计算并输出：[(23 + 7)x12-8]÷6的小数值（挑战：精确到小数点以后2位）
            //需求？？？怎么精确小数？？
            //double grade = (float)((23 + 7) * 12 - 8) / 6;
            //string i = grade.ToString("0.00");
            //Console.WriteLine(i);

            //3.想一想以下语句输出的结果：
            //int i = 15;
            // Console.WriteLine(i++);
            // i -= 5;
            // Console.WriteLine(i);
            // Console.WriteLine(i >= 10);
            // Console.WriteLine("i值的最终结果为：" + i);
            // int j = 20;
            // Console.WriteLine($"{i}+{j}={i + j}");
            //4. 想一想如下代码的结果是什么，并说明原因：
            //int a = 10;
            // Console.WriteLine(a > 9 && (!(a < 11) || a > 10));
            //假 (!(a < 11) || a > 10) 为假

            // 5.a为何值时，结果为true？
            //bool result = (a + 3 > 12) && a < 3.14 * 4 && a != 11;
            //a=10
            #endregion
            #region 分支 if...else
            //https://17bang.ren/Article/263
            //作业
            //观察一起帮登录页面，用if...else ...完成以下功能。
            //用户依次由控制台输入：验证码、用户名和密码：
            //1如果验证码输入错误，直接输出：“*验证码错误”；
            //2如果用户名不存在，直接输出：“*用户名不存在”；
            //3如果用户名或密码错误，输出：“*用户名或密码错误”
            //4以上全部正确无误，输出：“恭喜！登录成功！”

            //if (Console.ReadLine()!="q121")
            //{
            //    Console.WriteLine("验证码错误");
            //}
            //else
            //{
            //    Console.WriteLine("验证码正确");
            //    if (Console.ReadLine() != "青蛙")
            //    {
            //        Console.WriteLine("用户名不存在");
            //    }
            //    else
            //    {
            //        //Console.WriteLine("用户名存在");
            //        if (Console.ReadLine() != "1212")
            //        {
            //            Console.WriteLine("用户名或密码错误");
            //        }
            //        else
            //        {
            //            Console.WriteLine("恭喜！登录成功！");
            //        }
            //    }
            //}
            #endregion
            #region 数组
            //https://17bang.ren/Article/294
            //作业：
            //将源栈同学姓名 / 昵称分别：
            //按进栈时间装入一维数组，
            //string[] name = new string[] { "陈国栋", "夏康平", "周丁浩", "胡涛", "韩家宝","龚廷义" };
            //按座位装入二维数组，
            //并输出共有多少名同学。
            //string[,] seat = new string[3, 3];
            //seat[0, 0] = "陈国栋";
            //seat[0, 1] = "夏康平";
            //seat[0, 2] = "周丁浩";
            //seat[1, 0] = "胡涛";
            //seat[1, 1] = "韩家宝";
            //seat[1, 2] = "龚廷义";
            //Console.WriteLine(seat.Length);
            #endregion
            #region 循环
            //https://17bang.ren/Article/438
            //作业：
            //分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9
            //int i = 0;
            //while (i < 5)
            //{
            //    i++;
            //    Console.WriteLine(i);
            //}
            //int i = 1;
            //while (i<=9)
            //{
            //    Console.WriteLine(i);
            //    i += 2;
            //}


            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 1; i <= 9; i++)
            //{
            //    Console.WriteLine(i);
            //    i += 1;
            //}

            //用for循环输出存储在一维 / 二维数组里的源栈所有同学姓名 / 昵称
            //string[] name = new string[] { "陈国栋", "夏康平", "周丁浩", "胡涛", "韩家宝","龚廷义" };
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}


            //string[,] seat = new string[3, 3];
            //seat[0, 0] = "陈国栋";
            //seat[0, 1] = "夏康平";
            //seat[0, 2] = "周丁浩";
            //seat[1, 0] = "胡涛";
            //seat[1, 1] = "韩家宝";
            //seat[1, 2] = "龚廷义";
            ////console.writeline(seat.length);

            //for (int i = 0; i < seat.GetLength(0); i++)
            //{
            //    for (int j = 0; j < seat.GetLength(1); j++)
            //    {
            //        Console.WriteLine(seat[i,j]);
            //    }
            //}

            //让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值
            //int sum = 0;
            //for (int i = 1; i < 100; i+=2)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //int[] a = { 2, 5, 33, 54, 6, 7, 93 }; //练习输出数据和
            //int sum = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    sum += a[i];
            //}
            //Console.WriteLine(sum);

            //将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //double[] grade = { 32.3, 54.6, 76.7, 26.7, 98.01, 23.7, 14.1, 111};
            //double max = grade[0], min = grade[0];
            //for (int i = 0; i < grade.Length; i++)
            //{
            //    if (grade[i]>max)
            //    {
            //        max = grade[i];
            //    }//else contiune
            //    if (grade[i]<min)
            //    {
            //        min = grade[i];
            //    }
            //}
            //Console.WriteLine(max);
            //Console.WriteLine(min);

            // 找到100以内的所有质数（只能被1和它自己整除的数）
            //for (int i = 2; i < 100; i++)
            //{
            //    bool a = true;
            //    for (int j = 2; j < i - 1; j++)//判断当前判断的数字是不是质数
            //    {
            //        if (i % j == 0)//说明不是质数
            //        {
            //            a = false;
            //            break;
            //        }
            //    }
            //    if (a)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //生成一个数组从小到大排序
            //int[] array = { 32, 43, 12, 3, 46, 87, 54, 89, 14, 22 ,999};
            //for (int i = 1; i < array.Length; i++)
            //{
            //    for (int j = 0; j < array.Length-i; j++)
            //    {
            //        if (array[j] > array[j + 1])
            //        {
            //            int temp = array[j];
            //            array[j] = array[j + 1];
            //            array[j + 1] = temp;
            //        }
            //    }
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}


            //生成一个元素（值随机）从小到大排列的数组
            //Random r = new Random();
            //int[] array = new int[10]; int temp;  //int[10]指数组存十个
            //for (int i = 0; i < array.Length; i++)
            //{
            //    temp = r.Next(1, 500);
            //    array[i] = temp;
            //}//生产随机数
            //for (int i = 1; i < array.Length; i++) //进行冒泡排序
            //{
            //    for (int j = 0; j < array.Length - i; j++)
            //    {
            //        if (array[j] > array[j + 1])
            //        {
            //            temp = array[j];
            //            array[j] = array[j + 1];
            //            array[j + 1] = temp;
            //        }
            //    }
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + ",");
            //}


            //设立并显示一个多维数组的值，元素值等于下标之和。Console.Write()
            //int[,] age =new int[5,5];
            //for (int i = 0; i < age.GetLength(0); i++)   //数组类里面有个GetLength(?)方法，是用来获取数组指定维数中的元素个数。
            //{
            //    for (int j = 0; j < age.GetLength(1); j++)
            //    {
            //        age[i, j] = i + j;
            //        Console.Write(age[i,j]+"  ");
            //    }
            //    Console.WriteLine();
            //}

            //二分查找：在有序数组里面找到某个值
            //int[] array = { 2, 6, 9, 12, 16, 23, 44, 49, 55,66 };
            //int target = 2, left = 0, right = array.Length - 1;
            //bool result = false;
            //int middle = (left + right) / 2;
            //while (left<=right)
            //{
            //    middle = (left + right) / 2;
            //    if (target>array[middle])
            //    {
            //         left= middle+1;
            //    }
            //    else if (target<array[middle])
            //    {
            //        right = middle-1;
            //    }
            //    else//target=array[middle]
            //    {
            //        result = true;
            //        break;
            //    }
            //}
            //if (result)
            //{
            //    Console.WriteLine(middle);
            //}
            //else
            //{
            //    Console.WriteLine("没找到");
            //}


            #endregion
            #region 声明/调用/返回值
            //https://17bang.ren/Article/299
            //作业
            //1将之前作业封装成方法（自行思考参数和返回值），并调用执行。且以后作业，如无特别声明，皆需使用方法封装。

            //2计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()

            //3完成“猜数字”游戏，方法名GuessMe()：
            //   随机生成一个大于0小于1000的整数
            //   用户输入一个猜测值，系统进行判断，告知用户猜测的数是“大了”，还是“小了”
            //   没猜中可以继续猜，但最多不能超过10次
            //      如果5次之内猜中，输出：你真牛逼！
            //      如果8次之内猜中，输出：不错嘛！
            //      10次还没猜中，输出：(～￣(OO)￣)ブ
            #endregion
            #region 方法进阶：值/引用传递
            //https://17bang.ren/Article/303
            //作业
            //利用ref调用Swap()方法交换两个同学的床位号
            //static void Swap(ref int location, ref int locations)
            //{
            //    int temp = location;
            //    location = locations;
            //    locations = temp;
            //}
            //将登陆的过程封装成一个方法LogOn()，调用之后能够获得：
            //true / false，表示登陆是否成功
            //string，表示登陆失败的原因
            //static string LogIn(string code, string name, string password,out bool i)
            //{
            //    if (code != "q121")
            //    {
            //        return "验证码错误";
            //    }//else continue
            //    if (name != "青蛙")
            //    {
            //        return "用户名不存在";
            //    }//else continue
            //    if (password != "1212")
            //    {
            //        return "用户名或密码错误";
            //    }//else contnue
            //    return "true";
            //}



            #endregion
            #region 参数：重载/可选/params
            //https://17bang.ren/Article/641
            //作业
            //1定义一个生成数组的方法：int[] GetArray()，其元素随机生成从小到大排列。利用可选参数控制：
            //2最小值min（默认为1）
            //3相邻两个元素之间的最大差值gap（默认为5）
            // 元素个数length（默认为10个）


            //static int[] GetArray(int min = 1, int gap = 5, int length = 10)
            //{
            //    int[] array = new int[length];
            //    Random random = new Random();
            //    //array[0] = random.Next(10, 100);
            //    for (int i = min; i < array.Length; i++)
            //    {
            //        //array[i] += gap;
            //        //array = GetArray(min);

            //        array[i] = random.Next(gap) + array[i - 1];
            //        Console.WriteLine(array[i]);
            //        //array[i] += gap;

            //    }
            //    //Console.WriteLine(array);
            //    return array;
            //}
            //4实现二分查找，方法名BinarySeek(int[] numbers, int target)：
            //  传入一个有序（从大到小 / 从小到大）数组和数组中要查找的元素
            //  如果找到，返回该元素所在的下标；否则，返回 - 1
            //static int BinarySeek(int[] numbers)
            //{
            //    int left = 0, right = numbers.Length - 1, middle;
            //    int target = 55;
            //    while (left <= right)
            //    {
            //        middle = (left + right) / 2;
            //        if (target > numbers[middle])
            //        {
            //            left = middle + 1;
            //        }
            //        else if (target < numbers[middle])
            //        {
            //            right = middle - 1;
            //        }
            //        else
            //        {
            //            return middle;
            //        }
            //    }
            //    return -1;
            //}


            #endregion
            #region 类和对象
            //https://17bang.ren/Article/305
            //作业
            //观察“一起帮”的：
            //注册 / 登录功能，定义一个User类，包含字段：Name（用户名）、Password（密码）和 邀请人（InvitedBy），和方法：Register()、Login()
            //求助版块，定义一个类Problem，包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
            //帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法
            //为这些类的字段和方法设置合适的访问修饰符。

            #endregion
            #region 引用类型和值类型
            //https://17bang.ren/Article/708
            //作业：
            //用代码和调试过程演示：
            //值类型参数的值传递
            //int a = 12;
            //int b = a;
            //b = 23;
            //Console.WriteLine(a);
            //值类型参数的引用传递
            //User lx = new User() ;
            //lx.names = "刘晓";

            //User ht = lx;
            //ht.names = "胡涛";
            //Console.WriteLine(lx.names );
            //引用类型参数的值传递(不是同一个变量就说明他是值传递)
            //User csharp = new User();
            //csharp.agreeCount = 20;
            //Agree(csharp);
            //Console.WriteLine(csharp.agreeCount);

            //引用类型参数的引用传递
            //User zlz = new User();
            //zlz.age = 163;
            //zlz = Stature(/*ref*/ zlz);//用return如果不zlz=就会输出原本的值
            //Console.WriteLine(zlz.age);

            //return代替引用类型的引用传递
            //思考：为什么需要区分引用类型和值类型？
            //引用类型的对象不会放到栈里面，对象是比较大的 放到栈里面会占用栈的资源，大的对象移动会消耗很多的资源，与其移动对象不如移其地址（提高程序运行性能）

            #endregion
            #region 构造函数/属性/索引器/析构函数
            //https://17bang.ren/Article/709
            //作业：
            //将之前User / Problem / HelpMoney类的字段封装成属性，其中：
            //  user.Password在类的外部只能改不能读
            //User lxx = new User();
            //lxx.Password = "q12";
            //Console.WriteLine(lxx.Password); //不能读
            //  如果user.Name为“admin”，输入时修改为“系统管理员”
            //lxx.name = "admin";
            //Console.WriteLine(lxx.name);
            //  problem.Reward不能为负数
            //Problem lx = new Problem();
            //lx.Reward = -1;
            //Console.WriteLine(lx.Reward);
            //调用这些类的有参 / 无参构造函数，生成这些类的对象，调用他们的方法
            // 一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
            //设计一种方式，保证：
            //  每一个Problem对象一定有Body赋值
            //  每一个User对象一定有Name和Password赋值
            //Problem key = new Problem(10);
            //key[1] = "sql";
            //key[2] = "c#";
            //Console.WriteLine(lxx.setPsaaword());


            #endregion
            #region 静态和实例
            //https://17bang.ren/Article/710
            //作业：
            //定义一个仓库（Repoistory）类，用于存取对象，其中包含：
            //一个int类型的常量version
            //一个静态只读的字符串connection，以后可用于连接数据库
            //思考Respoitory应该是static类还是实例类更好
            //考虑求助（Problem）的以下方法 / 属性，哪些适合实例，哪些适合静态，然后添加到类中：
            //Publish()：发布一篇求助，并将其保存到数据库
            //Load(int Id)：根据Id从数据库获取一条求助
            //Delete(int Id)：根据Id删除某个求助
            //repoistory：可用于在底层实现上述方法和数据库的连接操作等
            //设计一个类FactoryContext，保证整个程序运行过程中，无论如何，外部只能获得它的唯一的一个实例化对象。（提示：设计模式之单例）
            //想一想，为什么Publish()方法不是放置在User类中呢？用户（user）发布（Publish）一篇文章（article），不正好是user.Publish(article)么？
            //自己实现一个模拟栈（MimicStack）类，入栈出栈数据均为int类型，包含如下功能：
            //出栈Pop()，弹出栈顶数据
            //入栈Push()，可以一次性压入多个数据
            //出 / 入栈检查，
            //如果压入的数据已超过栈的深度（最大容量），提示“栈溢出”
            //如果已弹出所有数据，提示“栈已空”
            //MimicStack arr = new MimicStack();
            //arr.Push(1);
            //arr.Push("哈哈");
            //arr.Push(true);
            //arr.Push(4.1);
            //arr.Push(5);
            //arr.Push(6);
            //arr.Pop();
            //arr.Pop();
            //arr.Pop();
            //arr.Pop();
            //arr.Pop();
            //arr.Pop();
            #endregion
            #region 继承
            //https://17bang.ren/Article/711
            //作业：
            //让User类无法被继承
            //观察一起帮的求助（Problem）、文章（Article）和意见建议（Suggest），根据他们的特点，抽象出一个父类：内容（Content）
            //  Content中有一个字段：kind，记录内容的种类（problem / article / suggest等），只能被子类使用
            //  确保每个Content对象都有kind的非空值
            //  Content中的createTime，不能被子类使用，但只读属性PublishTime使用它为外部提供内容的发布时间
            //  其他方法和属性请自行考虑，尽量贴近一起帮的功能实现。
            //实例化文章和意见建议，调用他们：
            //  继承自父类的属性和方法
            //  自己的属性和方法
            //Article LX = new Article();
            //LX.Search("121");

            //再为之前所有类（含User、HelpMoney等）抽象一个基类：Entity，包含一个只读的Id属性。试一试，Suggest能有Id属性么？
            #endregion
            //多态作业
            {
                //作业：
                //添加一个新类ContentService，其中有一个发布（Publish()）方法：
                //如果发布Article，需要消耗一个帮帮币
                //如果发布Problem，需要消耗其设置悬赏数量的帮帮币
                //如果发布Suggest，不需要消耗帮帮币
                //最后将内容存到数据库中，三个类存数据库的方法是完全一样的，现在用Console.WriteLine()代替。根据我们学习的继承和多态知识，实现上述功能。
                //Content lx = new Article();
                //new ContentService().Publish(lx);
                ////lx.consume();

                //Content lxx = new Problem();
                //new ContentService().Publish(lxx);
                ////lxx.consume();

                //Content llx = new Suggest();
                //new ContentService().Publish(llx);
                //llx.consume();
            }
            //C#-面向对象：抽象类和接口作业：
            {
                //思考之前的Content类，该将其抽象成抽象类还是接口？为什么？并按你的想法实现。
                //一起帮里的求助总结、文章和意见建议，以及他们的评论，都有一个点赞（Agree）/ 踩（Disagree）的功能，赞和踩都会增减作者及评价者的帮帮点。能不能对其进行抽象？如何实现？
                //引入两个子类EmailMessage和DBMessage，和他们继承的接口ISendMessage（含Send()方法声明），用Console.WriteLine()实现Send()。
                //一起帮还可以在好友间发私信，所有又有了IChat接口，其中也有一个Send()方法声明。假设User类同时继承了ISendMessage和IChat，如何处理？
                //ISendMessage ll = new DBMessage();
                //ll.Send();
                //ISendMessage li = new EmailMessage();
                //li.Send(); 

                //IChat ic = new User();
                //ic.Send();
                //ISendMessage im = new User();
                //im.Send();
                //User im = new User();
                //im.Send();
            }
            //结构和日期 作业
            {
                //作业：
                //用代码证明struct定义的类型是值类型
                //Bed bed /*= new Bed()*/;//new Bed()实际上给所有struct成员赋了默认值
                //bed._number = 12; //值类型不会报错  是他有一个无参构造函数
                //Console.WriteLine(bed._number);

                ////Beds beds = new Beds();//引用类型有无参构造函数是不会报错的
                //Beds beds /*= new Bed()*/;
                //beds._number = 12;//报错：使用了未赋值的变量  //Bed1引用类型
                //Console.WriteLine(beds._number);

                //源栈的学费是按周计费的，所以请实现这两个功能：
                //函数GetDate()，能计算一个日期若干（日 / 周 / 月）后的日期、
                //GetDate(5, 10, 8);
                //给定任意一个年份，就能按周排列显示每周的起始日期，如下图所示：
                //GetDate(2021);
                //注意：先写测试用例，确保所有测试用例通过

            }
            //枚举作业
            {
                //作业：
                //声明一个令牌（Token）枚举，包含值：SuperAdmin、Admin、Blogger、Newbie、Registered。
                //声明一个令牌管理（TokenManager）类：
                //使用私有的Token枚举_tokens存储所具有的权限
                //暴露Add(Token)、Remove(Token)和Has(Token)方法，可以添加、删除和判断其有无某个权限
                //User类中添加一个Tokens属性，类型为TokenManager
                //User lx = new User();
                ////lx.Tokens.ADD(Token.Newbie);//空引用
                //lx.Tokens = new TokenManager();
                //lx.Tokens.ADD(Token.Newbie);
                //lx.Tokens.ADD(Token.Newbie);

            }
            //Object和拆箱
            {
                //作业：
                //在https://source.dot.net/中找到 Console.WriteLine(new Student()); 输出Student类名的源代码
                //思考dynamic和var的区别，并用代码予以演示
                //var i = "1";//未赋值会报错  在声明的时候就要给他赋值一个类型
                //Console.WriteLine(i-2);//不能进行string类型跟int类型计算  ，编译时会报错

                //dynamic j=2;//未赋值不会报错
                //j = new User();
                //Console.WriteLine(j+3);// 不会进行类型检查，编译时不会报错，运行时会报错 


                //构造一个能装任何数据的数组，并完成数据的读写
                //object[] arr = new object[]{ "大傻", 1, true, 1.1 };

                //for (int i = 0; i < arr.Length; i++)
                //{
                //    Console.WriteLine(arr[i]);
                //}

                //使用object改造数据结构栈（MimicStack），并在出栈时获得出栈元素
            }
            #region  C#-面向对象-反射和特性

            //作业：
            //之前的Content类，其中的CreateTime（创建时间）和PublishTime（发布时间）都是只读的属性，想一想他们应该在哪里赋值比较好，并完成相应代码
            //在Content之外封装一个方法，可以修改Content的CreateTime和PublishTime

            //自定义一个特性HelpMoneyChanged（帮帮币变化）：
            //该特性只能用于方法
            //有一个构造函数，可以接受一个int类型的参数amount，表示帮帮币变化的数量
            //有一个string类型的Message属性，记录帮帮币变化的原因
            //将HelpMoneyChanged应用于Publish()方法
            //用反射获取Publish()上的特性实例，输出其中包含的信息
            //Attribute attribute = HelpMoneyChangedAttribute.GetCustomAttribute(
            //    typeof(ContentService).GetMethod("Publish"),               //ContentService类上的
            //    typeof(HelpMoneyChangedAttribute));   //HelpMoneyChangedAttribute特性
            //Console.WriteLine(((HelpMoneyChangedAttribute)attribute).Amount); ////将基类的Attribute对象强转为子类



            #endregion
            #region  泛型：声明/使用/约束/继承
            //作业：
            //改造Entity类，让其Id可以为任意类型
            //用泛型改造二分查找、堆栈和双向链表
            //Generic<int> generic = new Generic<int>();
            //generic.Dchotomy(new int[] { 2, 6, 9, 12, 16, 23, 44, 49, 55, 66 }, 6);

            ////用泛型改造“取数组中最大值”（提示：IComparable）
            //Generic<double> generic1 = new Generic<double>();
            //generic1.GetMax(new double[] { 32.3, 54.6, 76.7, 26.7, 98.01, 23.7, 14.1, 111 }, 0);

            //用代码演示泛型接口的协变/逆变
            #endregion
            #region 集合：List / Dictionary / ER模型 ……
            //作业：
            //在现有作业的基础上，观察一起帮的文章板块，以此为蓝本，补充（如果还没有的话）声明：
            //评论（Comment）类
            //评价（Appraise）类：包括“赞（Agree）”和“踩（Disagree）”
            //关键字（Keyword）类
            //并构建以下关系：

            ////关键字
            //Keyword csharp = new Keyword { name = "Csharp" };
            //Keyword js = new Keyword { name = "JavaScript" };
            //Keyword sql = new Keyword { name = "SQL" };

            ////文章 wz，lx
            //Article wz = new Article { name = "文章" };
            //Article lx = new Article { name = "类型" };
            ////评论
            //Comment pl = new Comment { name = "好" };
            //Comment PL = new Comment { name = "不错" };
            ////评价
            //Appraise Agree = new Appraise { name = "赞" };
            //Appraise Disagree = new Appraise { name = "踩" };

            ////一篇文章可以有多个评论
            //lx.Comment = new List<Comment> { pl,PL };


            ////一个评论必须有一个它所评论的文章
            //pl.Article = wz;
            //wz.Comment = new List<Comment> { pl };
            ////每个文章和评论都有一个评价
            //lx.Comment = new List<Comment> { pl };
            //pl.Article = lx;

            ////一篇文章可以有多个关键字，一个关键字可以对应多篇文章

            //wz.keyword = new List<Keyword> { csharp, js };
            //lx.keyword = new List<Keyword> {js, sql };

            //csharp.Article = new List<Article> { wz };
            //js.Article = new List<Article> { wz,lx };
            //sql.Article = new List<Article> { lx };
            //js.Article = new List<Article> { lx,wz };

            #endregion
            #region  C#进阶：集合：foreach背后
            //作业
            //让之前的双向链表，能够：被foreach迭代

            //Dictionary<string, DLinkNodeTests> DLinkNodeTest = new Dictionary<string, DLinkNodeTests>
            //{
            //    {"lx",new DLinkNodeTests() },
            //    {"ll",new DLinkNodeTests() },
            //    {"xx",new DLinkNodeTests() },

            //};
            //foreach (var item in DLinkNodeTest)
            //{
            //    Console.WriteLine(item.Key);
            //}

            //Console.WriteLine(typeof(DLinkNode<int>) == new DLinkNode<int>().GetType());
            #endregion

            #region 扩展（extension）方法
            //作业
            //调用扩展方法Max()：能够返回之前双向链表中存贮着最大值的节点


            #endregion
            #region  C#进阶：匿名方法 / Lambda / 闭包
            //作业：
            //声明一个委托：打水（ProvideWater），可以接受一个Person类的参数，返回值为int类型
            //使用：
            //方法
            //匿名方法
            //lambda表达式
            //给上述委托赋值，并运行该委托
            //声明一个方法GetWater()，该方法接受ProvideWater作为参数，并能将ProvideWater的返回值输出

            //ProvideWater provideWater = Water1;
            //provideWater(new Person());

            //ProvideWater provideWater1 = delegate (Person person){return 1;};

            //ProvideWater provideWater2 = (Person person) => { return 1; };

            #endregion
            #region C#进阶：Linq
            //作业：
            //在之前“文章 / 评价 / 评论 / 用户 / 关键字”对象模型的基础上，添加相应的数据，然后完成以下操作：
            //用户
            //User fg = new User { Name = "飞哥" };
            //User xy = new User { Name = "小鱼" };
            //IEnumerable<User> users = new List<User> { fg, xy };
            ////关键字
            //Keyword kw1 = new Keyword { key = "C#" };
            //Keyword kw2 = new Keyword { key = ".NET" };
            //Keyword kw3 = new Keyword { key = "avaScript" };
            //Keyword kw4 = new Keyword { key = "C" };
            //Keyword kw5 = new Keyword { key = "SQL" };
            //IEnumerable<Keyword> keywords = new List<Keyword> { kw1, kw2, kw3, kw4, kw5 };
            ////文章
            //Article csharp = new Article { Title = "C#文章", Author = fg, keyword = new List<Keyword> { kw1, kw3, kw5 } };
            //Article js = new Article { Title = "JavaScript文章", Author = fg, keyword = new List<Keyword> { kw2, kw3, kw4, kw5 } };
            //Article sql = new Article { Title = "SQL文章", Author = xy, keyword = new List<Keyword> { kw1, kw3, kw4, kw5 } };
            //Article net = new Article { Title = ".NET文章", Author = fg, keyword = new List<Keyword> { kw1, kw3 } };
            //Article java = new Article { Title = "JAVA文章", Author = xy, keyword = new List<Keyword> { kw3, kw4 } };
            //IEnumerable<Article> articles = new List<Article> { csharp, js, sql, net, java };

            ////找出“飞哥”发布的文章
            //var result = from a in articles //var==IEnumerable<Article>
            //             where a.Author == fg
            //             select a;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Title);
            //}
            //linq方法
            //var result = articles.Where(a => a.Author == fg);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Title);
            //}
            ////找出2019年1月1日以后“小鱼”发布的文章

            //Article article1 = new Article() { Title = "哈哈", Author = xy, PublishTime = new DateTime(2015, 6, 2) };
            //Article article2 = new Article() { Title = "哦豁", Author = fg, PublishTime = new DateTime(2010, 8, 2) };
            //Article article3 = new Article() { Title = "阿西吧", Author = xy, PublishTime = new DateTime(2020, 1, 2) };
            //Article article4 = new Article() { Title = "阿萨", Author = xy, PublishTime = new DateTime(2020, 5, 2) };
            //IEnumerable<Article> article = new List<Article> { article1, article2, article3, article4 };
            //var result1 = from a in article
            //              where a.Author == xy && a.PublishTime > new DateTime(2019, 1, 1)
            //              select a;
            //foreach (var item in result1)
            //{
            //    Console.WriteLine(item.PublishTime);
            //}
            ////linq方法
            //var result = article.Where(a => a.Author == xy && a.PublishTime > new DateTime(2019, 1, 1));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.PublishTime);
            //}
            ////按发布时间升序 / 降序排列显示文章
            //var result2 = from a in article
            //              orderby a.PublishTime
            //              select a;
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item.PublishTime);
            //}
            //var result3 = from a in article
            //              orderby a.PublishTime descending
            //              select a;
            //foreach (var item in result3)
            //{
            //    Console.WriteLine(item.PublishTime);
            //}
            //linq方法
            //var result = article.OrderBy(a => a.PublishTime);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.PublishTime);
            //}

            //var result = article.OrderByDescending(a => a.PublishTime);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.PublishTime);
            //}

            ////统计每个用户各发布了多少篇文章
            //var result4 = from a in articles
            //              group a by a.Author;
            //foreach (var item in result4)
            //{
            //    Console.WriteLine(item.Key.Name);//用户名
            //    foreach (var b in item)
            //    {
            //        Console.WriteLine(b.Title);
            //    }
            //    Console.WriteLine($"{item.Key.Name}一共发布了：{item.Count()}文章");
            //}
            //linq方法
            //var result = articles.GroupBy(a => a.Author);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key.Name);//用户名
            //    foreach (var b in item)
            //    {
            //        Console.WriteLine(b.Title);
            //    }
            //    Console.WriteLine($"{item.Key.Name}一共发布了：{item.Count()}文章");
            //}

            ////投影
            //var result5 = from a in articles
            //              group a by a.Author
            //              into gm  //into类似于命名，将之前的结果集命名为：gm
            //              select new
            //              {
            //                  gm.Key,
            //                  sum = gm.Count()
            //              };
            //foreach (var item in result5)
            //{
            //    Console.WriteLine(item.Key.Name + "一共发布了：" + item.sum + "文章");
            //}
            //////linq方法
            //var reslut = articles.GroupBy(a => a.Author);
            //var reslut1 = reslut.Select(a => new
            //{
            //    a.Key,
            //    sum = a.Count()
            //});
            //foreach (var item in reslut1)
            //{
            //    Console.WriteLine(item.Key.Name + "一共发布了：" + item.sum + "文章");
            //}

            ////找出包含关键字“C#”或“.NET”的文章
            //var result6 = from a in articles
            //              where a.Title.Contains("C#") || a.Title.Contains(".NET")
            //              select a;
            //foreach (var item in result6)
            //{
            //    Console.WriteLine(item.Title);
            //}
            //var result6 = from a in articles
            //              where a.keyword.Any(result6 => result6.key == "C#") || a.keyword.Any(result6 => result6.key == ".NET")//有一个存在就为真,result6可以简写(k=> k.key == "C#"),k是参数名
            //              select a;
            //foreach (var item in result6)
            //{
            //    Console.WriteLine(item.Title);
            //}
            ////linq 方法
            //var result = articles.Where(a => a.Title.Contains("C#") || a.Title.Contains(".NET"));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Title);
            //}
            //var result = articles.Where(a => a.keyword.Any(result6 => result6.key == "C#") || a.keyword.Any(result6 => result6.key == ".NET"));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Title);
            //}
            ////找出评论数量最多的文章
            //Comment comment = new Comment { Title = "偶是看", Article = csharp };
            //Comment comment1 = new Comment { Title = "大傻蛋", Article = js };
            //Comment comment2 = new Comment { Title = "士大夫", Article = csharp };
            //Comment comment3 = new Comment { Title = "来应", Article = java };
            //Comment comment4 = new Comment { Title = "读后感", Article = sql };
            //Comment comment5 = new Comment { Title = "热帖", Article = java };
            //Comment comment6 = new Comment { Title = "干饭", Article = sql };
            //Comment comment7 = new Comment { Title = "火锅", Article = java };
            //Comment comment8 = new Comment { Title = "软便", Article = net };
            //IEnumerable<Comment> comments = new List<Comment> {
            //    comment, comment1, comment2, comment3,comment4,comment5,comment6,comment7,comment8 };
            ////var result7 = from c in comments
            //              group c by c.Article
            //              into gm
            //              select new
            //              {
            //                  gm.Key,
            //                  number = gm.Count()
            //              };
            //foreach (var item in result7)
            //{
            //    if (item.number == result7.Max(m => m.number))//{ return m.number; })),m就是result7里面的元素
            //    {
            //        Console.WriteLine(item.Key.Title + ":" + item.number);
            //    }
            //}
            //////linq 方法
            //var result = comments.GroupBy(c => c.Article);
            //var result1 = result.Select(c => new
            //{
            //    c.Key,
            //    number = c.Count()
            //});
            //foreach (var item in result1)
            //{
            //    if (item.number == result1.Max(m => m.number))//{ return m.number; })),m就是result7里面的元素
            //    {
            //        Console.WriteLine(item.Key.Title + ":" + item.number);
            //    }
            //}
            ////找出每个作者评论数最多的文章
            //var result8 = from c in comments
            //              join a in articles on c.Article equals a
            //              group c by c.Article
            //              into gm
            //              select new
            //              {
            //                  num = gm.Count(),
            //                  title = gm.Key.Title,
            //                  author = gm.Key.Author
            //              };

            //foreach (var item in result8)
            //{
            //    //if (item.num == result8.Max(m => m.num))//{ return m.number; })),m就是result8里面的元素
            //    //{
            //    //    Console.WriteLine(item.author.Name + "---" + item.title + "---" + item.num);
            //    //}
            //    Console.WriteLine(item.author.Name + "---" + item.title + "---" + item.num);
            //}


            #endregion
            #region linq方法
            //作业：
            //将之前作业的Linq查询表达式用Linq方法实现
            //找出每个作者最近发布的一篇文章
            //var result = article.GroupBy(a =>new { a.Author,a.Title ,a.PublishTime });
            //var result2 = result.Select(a => new { a.Key.Author, a.Key.Title ,a.Key.PublishTime});
            //foreach (var item in result2)
            //{
            //    Console.WriteLine($"{item.Author.Name}：时间{item.PublishTime} 文章:{ item.Title} ");
            //}

            ////为求助（Problem）添加悬赏（Reward）属性，并找出每一篇求助的悬赏都大于5个帮帮币的求助作者
            //Problem problem = new Problem { Reward = 12, Author = xy, Title = "阿萨" };
            //Problem problem1 = new Problem { Reward = 2, Author = fg, Title = "多睡会" };
            //Problem problem2 = new Problem { Reward = 1, Author = xy, Title = "低功耗" };
            //Problem problem3 = new Problem { Reward = 17, Author = fg, Title = "换个方式" };
            //Problem problem4 = new Problem { Reward = 3, Author = fg, Title = "更多" };
            //IEnumerable<Problem> problems = new List<Problem> { problem, problem1, problem2, problem3, problem4 };

            //var result = problems.GroupBy(p => p.Author);
            //var result1 = result.Select(r => new
            //{
            //    author = r.Key.Name,
            //    reward = r.Key.Reward > 5,
            //});
            //foreach (var item in result1)
            //{
            //    Console.WriteLine(item.author);
            //}


            #endregion
            #region C#进阶：异常处理
            //作业：
            //修改之前的属性验证：problem.Reward为负数时直接抛出“参数越界”异常
            //Problem lx = new Problem();
            //lx.Reward = -1;
            //内容（Content）发布（Publish）的时候检查其作者（Author）是否为空，如果为空抛出“参数为空”异常

            //在ContentService中捕获异常
            //如果是“参数为空”异常，Console.WriteLine()输出：内容的作者不能为空，将当前异常封装进新异常的InnerException，再将新异常抛出
            //如果是“”参数越界”异常，Console.WriteLine()输出：求助的Reward为负数（-XX），不再抛出异常
            //ContentService中无论是否捕获异常，均要Console.WriteLine()输出：XXXX年XX月XX日 XX点XX分XX秒（当前时间），请求发布内容（Id = XXX）
            //在Main()函数调用ContentService时，捕获一切异常，并记录异常的消息和堆栈信息

            //try
            //{
            //    ContentService contentService = new ContentService();
            //    contentService.Publish(contentService);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //}
            #endregion



            //Console.WriteLine(
            //    string
            //    .Join('$', 12, 32)
            //    .Split('^',StringSplitOptions.RemoveEmptyEntries)
            //    );
            //Stringbuilder.MimicJoin(" - ", new string[] { "a", "b", "c", "d" });
            //User.GetCount("qwtargetwewtargetsdftarget", "target");

            //Content lx = new Article();
            //Console.WriteLine(lx);
            //Console.WriteLine(lx.ToString());
            //Console.WriteLine(new Student());
            //登录调用
            //Console.WriteLine(LogIn("q121", "青蛙", "1212"));
            //输出学生
            //array(new string[] { "陈国栋", "夏康平", "周丁浩", "胡涛", "韩家宝", "龚廷义" });
            //循环
            //getArray(1, 5);
            //getArray(1, 9);
            //奇数和
            //Console.WriteLine (summation(100));
            //找到最大最小值
            //Console.WriteLine(find(new double[] { 32.3, 54.6, 76.7, 26.7, 98.01, 23.7, 14.1, 111 }));
            //找到质数100以内的
            //find(100);
            //重构
            //GetArray();
            //排序
            //rank(new int[] { 32, 43, 12, 3, 46, 87, 54, 89, 14, 22, 999 });
            //计算平均成绩
            //double[] Average = { 32.3, 54.6, 76.7, 26.7, 98.01, 23.79, 14.1, 11.91 };
            //Console.WriteLine(Math.Round(GetAverage(Average), 2));
            //Console.WriteLine(GetAverage(Average));
            //猜数组
            //GuessMe();
            //调换位置
            //int location = 111, locations = 222;
            //Swap(ref location, ref locations);
            //Console.WriteLine(location);
            //Console.WriteLine(locations);
            //将登陆的过程封装成一个方法LogOn()，调用之后能够获得：
            //if (LogOn("青蛙", "1212", "q121", out string reason))
            //{
            //    Console.WriteLine(reason);
            //}
            //else
            //{
            //    Console.WriteLine(reason);
            //}
            //实现二分查找
            //Console.WriteLine(BinarySeek(new int[] { 12, 16, 25, 27, 33, 39, 44, 49, 55 }));


            //User lx = new User();
            //Console.WriteLine(lx.Tokens);
        }

        #region 声明/调用/返回值
        //https://17bang.ren/Article/299
        //作业
        //1将之前作业封装成方法（自行思考参数和返回值），并调用执行。且以后作业，如无特别声明，皆需使用方法封装。
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="code">验证码</param>
        /// <param name="name">用户名</param>
        /// <param name="password">用户登录密码</param>
        /// <returns>登录成功/用户名或密码错误</returns>
        //static string LogIn(string code, string name, string password)
        //{
        //    if (code != "q121")
        //    {
        //        return "验证码错误";
        //    }//else continue
        //    if (name != "青蛙")
        //    {
        //        return "用户名不存在";
        //    }//else continue
        //    if (password != "1212")
        //    {
        //        return "用户名或密码错误";
        //    }//else contnue
        //    return "恭喜！登录成功！";
        //}
        /// <summary>
        /// 输出同学的姓名
        /// </summary>
        /// <param name="name">学生姓名</param>
        //static void array(string[] name)
        //{
        //    string[] array = name;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.WriteLine(array[i]);
        //    }
        //}
        /// <summary>
        /// 循环输出1到5
        /// </summary>
        /// <param name="begin">起始值</param>
        /// <param name="end">结束值</param>
        //static void getArray(int begin, int end)
        //{
        //    for (int i = begin; i <= end; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    int i = begin;
        //    while (i <= end)
        //    {
        //        Console.WriteLine(i);
        //        i += 1;
        //    }
        //}
        /// <summary>
        /// 循环输出10以内的奇数
        /// </summary>
        /// <param name="begin">起始值</param>
        /// <param name="end">结束值</param>
        //static void getArray(int begin, int end) {
        //    //for (int i = begin; i <= end; i+=2)
        //    //{
        //    //    Console.WriteLine(i);
        //    //}
        //    int i = begin;
        //    while (i<=end)
        //    {
        //        Console.WriteLine(i);
        //        i += 2;
        //    }

        //}
        ///// <summary>
        /// 100以内奇数和
        /// </summary>
        /// <param name="number">最大数值</param>
        /// <returns></returns>
        //static int summation(int number)
        //{

        //    int sum = 0;
        //    for (int i = 1; i < number; i += 2)
        //    {
        //        sum += i;
        //    }
        //    return sum;
        //}
        /// <summary>
        /// 找到最大/小值
        /// </summary>
        /// <param name="grade">成绩</param>
        /// <returns>最大/小值</returns>
        //static double find(double[] grade)
        //{
        //    //将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
        //    double max = grade[0];//min = grade[0];
        //    for (int i = 0; i < grade.Length; i++)
        //    {
        //        if (grade[i] > max)
        //        {
        //            max = grade[i];
        //        }//else contiune
        //        //if (grade[i] < min)
        //        //{
        //        //    min = grade[i];
        //        //}//else contiune
        //    }
        //    return max;
        //    //return min;
        //}
        /// <summary>
        /// 输出100以内的质数
        /// </summary>
        /// <param name="number">最大值</param>
        //static void  find(int number)
        //{
        //for (int i = 2; i < number; i++)
        //    {
        //        bool isprime = true;//isprime是质数还是不是质数
        //        for (int j = 2; j < i - 1; j++) //判断当前判断的数字是不是质数
        //        {
        //            if (i % j == 0) //说明不是质数
        //            {
        //                isprime = false;//不是质数
        //                break;
        //            }
        //        }
        //        if (isprime)//是质数
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}
        /// <summary>
        /// 数组排序
        /// </summary>
        /// <param name="array">无序数组</param>
        //static void rank(int[] array)
        //{
        //    for (int i = 1; i < array.Length; i++)
        //    {
        //        for (int j = 0; j < array.Length - i; j++)
        //        {
        //            if (array[j] > array[j + 1])
        //            {
        //                int temp = array[j];
        //                array[j] = array[j + 1];
        //                array[j + 1] = temp;
        //            }
        //        }
        //    }
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.WriteLine(array[i]);
        //    }
        //}
        /// <summary>
        /// 求平均成绩（精确到两位小数）
        /// </summary>
        /// <param name="grade">学生成绩</param>
        /// <returns>全部学生平均值</returns>
        ///2计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
        //static double GetAverage(double[] grade)
        //{
        //    double sum = 0;
        //    for (int i = 0; i < grade.Length; i++)
        //    {
        //        sum = sum + grade[i];
        //    }
        //    double Average = sum / grade.Length;//声明一个存平均值的变量
        //    return Average;
        //}
        /// <summary>
        /// 猜数字游戏
        /// </summary>
        ///3完成“猜数字”游戏，方法名GuessMe()：
        ///   随机生成一个大于0小于1000的整数
        ///   用户输入一个猜测值，系统进行判断，告知用户猜测的数是“大了”，还是“小了”
        ///   没猜中可以继续猜，但最多不能超过10次
        ///      如果5次之内猜中，输出：你真牛逼！
        ///      如果8次之内猜中，输出：不错嘛！
        ///      10次还没猜中，输出：(～￣(OO)￣)ブ
        //static void GuessMe()
        //{
        //    Random r = new Random();
        //    int num = r.Next(1, 1000);
        //    Console.WriteLine("hello world！");
        //    Console.Write("请输入一个不超过1000的自然数：");
        //    Console.WriteLine();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine(num);
        //        int j = int.Parse(Console.ReadLine());
        //        if (j < 0 || j > 1000)
        //        {
        //            Console.WriteLine("输入的数不在范围");
        //            return;
        //        }
        //        if (j == num)
        //        {
        //            if (i <= 5)
        //            {
        //                Console.WriteLine($"恭喜您，答对了！只用了{i + 1} 次呢,你真牛逼！");
        //                break;
        //            }//else continue
        //            if (i <= 8)
        //            {
        //                Console.WriteLine($"恭喜您，答对了！只用了{i + 1} 次呢,不错嘛！");
        //                break;
        //            }//else continue
        //            if (i <= 9)
        //            {
        //                Console.WriteLine($"恭喜您，答对了！只用了{i + 1} 次呢,有点撇" +
        //                    $"！");
        //                break;
        //            }//else continue
        //        }
        //        else if (j > num)
        //        {
        //            Console.WriteLine($"太大了呢！(还剩{9 - i}次)");
        //        }
        //        else if (j < num)
        //        {
        //            Console.WriteLine($"太小了呢！(还剩{9 - i}次)");
        //        }//else continue
        //        if (i == 9)
        //        {
        //            Console.WriteLine("(～￣(OO)￣)ブ");
        //        }//else continue
        //    }

        #endregion
        #region 方法进阶：值/引用传递
        //https://17bang.ren/Article/303
        //作业
        //利用ref调用Swap()方法交换两个同学的床位号
        //static void Swap(ref int location, ref int locations)
        //{
        //    int temp = location;
        //    location = locations;
        //    locations = temp;
        //}


        //将登陆的过程封装成一个方法LogOn()，调用之后能够获得：
        //true / false，表示登陆是否成功
        //string，表示登陆失败的原因
        //static bool LogOn(string name, string password, string code, out string reason)
        //{
        //    // name = "青蛙"; password = "1212";code = "q121";
        //    Console.WriteLine("输入用户名:");
        //    if (name == Console.ReadLine())
        //    {
        //        Console.WriteLine("输入密码:");
        //        if (password == Console.ReadLine())
        //        {
        //            Console.WriteLine("输入验证码:");
        //            if (code == Console.ReadLine())
        //            {
        //                reason = "恭喜！登录成功 ";
        //                return true;
        //            }
        //            else
        //            {
        //                reason = "验证码错误";
        //                return false;
        //            }
        //        }
        //        else
        //        {
        //            reason = "密码输入错误";
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        reason = "用户名错误";
        //        return false;
        //    }
        //}
        #endregion
        #region 结构日期作业
        //函数GetDate()，能计算一个日期若干（日 / 周 / 月）后的日期
        //static void GetDate(int day, int week, int month)
        //{
        //    Console.WriteLine(DateTime.Now.AddDays(day));
        //    Console.WriteLine(DateTime.Now.AddDays(week * 7));
        //    Console.WriteLine(DateTime.Now.AddMonths(month));
        //}
        //给定任意一个年份，就能按周排列显示每周的起始日期，如下图所示：
        //public static void GetDate(int year)
        //{
        //    DateTime Dt = new DateTime(year, 1, 1);
        //    while (Dt.DayOfWeek != DayOfWeek.Monday)
        //    {
        //        Dt = Dt.AddDays(1);
        //    }
        //    //Console.WriteLine(Dt);//2021,1,4
        //    int i = 1;
        //    int years = Dt.Year;
        //    while (Dt.Year == years)
        //    {
        //        Console.WriteLine($"第{i}周：{Dt.ToString("yyyy年MM月dd日")} — {Dt.AddDays(6).ToString("yyyy年MM月dd日")}");
        //        Dt = Dt.AddDays(7);
        //        Console.WriteLine();
        //        i++;
        //    }
        //}
        #endregion


    }
}

