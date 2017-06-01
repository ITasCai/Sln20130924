using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _10专门针对文本文件操作的文件流
{
    class Program
    {
        static void Main(string[] args)
        {
            //如果对文本文件需要读取一部分显示一部分则使用FileStream会有问题，因为可能FileStream会在读取的时候把一个汉字的字节数给分开。所以造成显示的时候无法正确显示字符串


            //所以对于读取大文本文件一般使用StreamReader类

            //对于大文本文件写入一般用StreamWriter类。



            #region StreamWriter类的使用


            ////1.创建一个StreamWriter
            //using (StreamWriter sw = new StreamWriter("test.txt", false, Encoding.UTF8))
            //{
            //    //2.执行读写
            //    for (int i = 0; i < 1000; i++)
            //    {
            //        sw.WriteLine(i + "======" + System.DateTime.Now.ToString());
            //    }
            //}
            //Console.WriteLine("ok");
            //Console.ReadKey();


            #endregion


            #region StreamReader使用
            //1.创建StreamReader 对象
            using (StreamReader reader = new StreamReader("英汉词典TXT格式.txt", Encoding.Default))
            {

                #region 1

                //while (!reader.EndOfStream)
                //{
                //    string line = reader.ReadLine();
                //    Console.WriteLine(line);
                //}
                #endregion
                #region 2
                //int count = 0;
                //while (reader.ReadLine() != null)
                //{
                //    count++;
                //    Console.WriteLine(reader.ReadLine());
                //}
                //Console.WriteLine(count );
                //File.ReadAllLines(
                #endregion
                #region 2
                //2.循环读取每一行数据。
                string line = null;
                //int count = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    //count++;
                    Console.WriteLine(line);
                }
                //Console.WriteLine(count);

                #endregion
            }
            Console.WriteLine("ok");
            Console.ReadKey();


            #endregion


        }
    }
}
