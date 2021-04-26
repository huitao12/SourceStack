using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Captcha
{
    class Program
    {
        static void Main(string[] args)
        {
            //作业：

            //参考一起帮的登录页面，绘制一个验证码图片，存放到当前项目中。验证码应包含：
            //随机字符串
            //混淆用的各色像素点
            //混淆用的直线（或曲线）


            Bitmap image = new Bitmap(200, 100);  //生成一个像素图“画板”

            Graphics g = Graphics.FromImage(image);    //在画板的基础上生成一个绘图对象
            g.Clear(Color.AliceBlue);           //添加底色

            string list = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890";//list中存放着验证码的元素
            Random r = new Random();
            string code = "";   //验证码
            for (int i = 0; i < 4; i++)   //循环4次得到一个伪随机的4位数验证码
            {
                code += list[r.Next(0, list.Length)];
            }
            Color[] color = { Color.DarkSlateGray, Color.DarkCyan, Color.Black, Color.Chartreuse, Color.White, Color.Red, Color.LightGreen, Color.Aquamarine, Color.BurlyWood, Color.DarkRed ,Color.Yellow};
            for (int i = 0; i < 50; i++)
            {
                g.DrawLine(new Pen(color[r.Next(0, 11)]), new Point(r.Next(0, 200), r.Next(0, 200)), new Point(r.Next(0, 100), r.Next(0, 100))); //画直线
                g.DrawString(code,       //绘制字符串
                    new Font("宋体", 35),                //指定字体
                    new SolidBrush(color[r.Next(0, 11)]),     //绘制时使用的刷子
                    new PointF(25, 36)                    //左上角定位
                );
            }
            // 给定范围获得随机颜色
            for (int i = 0; i < 500; i++)
            {
                image.SetPixel(r.Next(1, 200), r.Next(1, 100), Color.Blue);  //绘制一个像素的点
            }

            image.Save(@"D:\A学-C#高阶\hello.jpg", ImageFormat.Jpeg);   //保存到文件


            //string list = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890";//list中存放着验证码的元素
            //Random r = new Random();
            //string code = "";   //验证码
            //for (int i = 0; i < 4; i++)   //循环4次得到一个伪随机的4位数验证码
            //{
            //    code += list[r.Next(0, list.Length)];
            //}
            //Console.WriteLine(code);

            //Bitmap image = new Bitmap(200, 100);  //生成一个像素图“画板”
            //Graphics g = Graphics.FromImage(image);    //在画板的基础上生成一个绘图对象
            //g.Clear(Color.AliceBlue);           //添加底色

            //for (int i = 0; i < 10; i++)
            //{
            //    image.SetPixel(r.Next(0, 300), r.Next(0, 200), Color.YellowGreen);  //绘制一个像素的点

            //}

            //HttpClient client = new HttpClient();
            //string message = client.GetStringAsync("https://17bang.ren/Article/538").Result;



        }
    }
}
