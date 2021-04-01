using System;

namespace CSharp
{
    class Program
    {

        static void Main(string[] args)
        {
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
            //double grade = (double)((23 + 7) * 12 - 8) / 6;
            //Console.WriteLine(grade);

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


            //4实现二分查找，方法名BinarySeek(int[] numbers, int target)：
            //  传入一个有序（从大到小 / 从小到大）数组和数组中要查找的元素
            //  如果找到，返回该元素所在的下标；否则，返回 - 1
            //static int BinarySeek(int[] numbers, int target = 91)
            //{
            //    int left = 0, right = numbers.Length-1, middle;
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
            User lxx = new User();
            lxx.Password = "q12";
            //Console.WriteLine(lxx.Password); //不能读
            //  如果user.Name为“admin”，输入时修改为“系统管理员”
            lxx.name = "admin";
            Console.WriteLine(lxx.name);
            //  problem.Reward不能为负数
            //Problem lx = new Problem();
            //lx.Reward = 1;
            //Console.WriteLine(lx.Reward);
            //调用这些类的有参 / 无参构造函数，生成这些类的对象，调用他们的方法
            // 一起帮的求助可以有多个（最多10个）关键字，请为其设置索引器，以便于我们通过其整数下标进行读写。
            //设计一种方式，保证：
            //  每一个Problem对象一定有Body赋值
            //  每一个User对象一定有Name和Password赋值
            Problem key = new Problem(10);
            key[1] = "sql";
            key[2] = "c#";
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
        //再为之前所有类（含User、HelpMoney等）抽象一个基类：Entity，包含一个只读的Id属性。试一试，Suggest能有Id属性么？
        #endregion

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
        //排序
        //rank(new int[] { 32, 43, 12, 3, 46, 87, 54, 89, 14, 22, 999 });
        //计算平均成绩
        //double[] Average = { 32.3, 54.6, 76.7, 26.7, 98.01, 23.79, 14.1, 11.91 };
        //Console.WriteLine(Math.Round(GetAverage(Average), 2));
        //Console.WriteLine(GetAverage(Average));
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
    //    var num = r.Next(1, 1000);
    //    Console.WriteLine("hello world！");
    //    Console.Write("请输入一个不超过1000的自然数：");
    //    Console.WriteLine();
    //    for (int i = 9; i >= 0; i--)
    //    {
    //        int j = int.Parse(Console.ReadLine());

    //        if (j < 0 || j > 1000)
    //        {
    //            Console.WriteLine("输入的数不在范围");
    //            return;
    //        }
    //        if (j == num)
    //        {
    //            if (i < 5)
    //            {
    //                Console.WriteLine($"恭喜您，答对了！只用了{10 - i} 次呢,你真牛逼！");
    //                break;
    //            }//else continue
    //            if (i < 8)
    //            {
    //                Console.WriteLine($"恭喜您，答对了！只用了{10 - i} 次呢,不错嘛！");
    //                break;
    //            }//else continue
    //        }
    //        else if (j > num)
    //        {
    //            Console.WriteLine($"太大了呢！(还剩{i}次)");
    //        }
    //        else if (j < num)
    //        {
    //            Console.WriteLine($"太小了呢！(还剩{i}次)");
    //        }//else continue
    //        if (i == 0)
    //        {
    //            Console.WriteLine("(～￣(OO)￣)ブ");
    //        }//else continue
    //    }
    //}
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
    //static void Agree(User article)
    //{
    //    article.agreeCount++;
    //}
    //static User /*void*/ Stature(/*ref*/ User user)//ref引用传递
    //{
    //    user = new User();////new了一个新的对象，改变的也是新的对象，不影响原来的对象，加ref他就是引入了zlz的值，但是新new了一个对象就为0
    //    user.age++;
    //    return user;
    //}




}

}
