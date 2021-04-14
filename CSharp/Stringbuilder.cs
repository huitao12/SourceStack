using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class Stringbuilder
    {
        //实现GetCount(string container, string target)方法，可以统计出container中有多少个target

        public static int GetCount(string container, string target)
        {
            int resul = 0;
            while (container.Contains(target)) //container包含target
            {
                container = container.Substring(container.IndexOf(target) + target.Length);//截取container包含target的 返回下标
                resul++;
            }
            return resul;
        }
        //不使用string自带的Join()方法，定义一个mimicJoin()方法，能将若干字符串用指定的分隔符连接起来，
        //比如：mimicJoin("-","a","b","c","d")，其运行结果为：a-b-c-d
        public static string MimicJoin(string interval, string[] value)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < value.Length; i++)
            {
                sb = sb.Append(value[i]);//更改
                if (i != value.Length-1)//-1没有下一个字符，不要-
                {
                    sb.Append(interval);//在字符后面添加-
                }
            }
            Console.WriteLine(sb);
            return sb.ToString();
        }

    }
}
