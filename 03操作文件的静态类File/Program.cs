using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _03操作文件的静态类File
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.判断一个文件是否存在
            //bool b = File.Exists(@"c:\hello.txt");
            //Console.WriteLine(b);
            //Console.Read();


            ////2.拷贝一个文件
            //File.Copy(@"c:\hello.txt", @"d:\hello.txt");
            //Console.WriteLine("ok");
            //Console.Read();
            //File.Move(); 移动，剪切文件

            ////3.创建一个文件
            //File.Create(@"c:\abc.txt");
            //Console.WriteLine("ok");
            //Console.Read();


            ////4.删除一个文件
            ////文件的删除，即便文件不存在也不会报异常
            //File.Delete(@"c:\abc.txt");
            //Console.WriteLine("ok");
            //Console.Read();


            //5.读取一个文件，写入

            //File.WriteAllText(@"c:\xxx.txt", "你好China !");
            //string[] lines=new string[]{"aaaaaaaaaaa","bbbbbbbbbbb","cccccccccc"};
            //File.WriteAllLines(@"c:\yyy.txt",lines);

            ////把一个字符串转换为一个byte[]
            //string msg = "哈喽沃尔德你好世界Hello World、！！！！！";
            //byte[] bytes = System.Text.Encoding.UTF8.GetBytes(msg);

            //File.WriteAllBytes(@"c:\ooo.txt", bytes);
            //Console.WriteLine("ok");
            //Console.Read();


            //看两个方法有什么区别，首先看这两个方法的功能有什么不同，然后看这两个方法的参数与返回值有什么不同，最后使用reflector 看看微软的内部实现有什么不同。

            //读取字符串
            //File.ReadAllText();
            //File.ReadAllLines();

            //byte[] byts = File.ReadAllBytes(@"c:\ooo.txt");
            ////把byte[]数组转换为字符串
            //string msg = System.Text.Encoding.UTF8.GetString(byts);
            //Console.WriteLine(msg);
            //Console.Read();

            //////File.ReadAllText(,Encoding.Default
            ////Encoding e = Encoding.Default;
            //string msg = "";
            //File.WriteAllText("", "", Encoding.GetEncoding("gb2312"));


        }
    }
}
