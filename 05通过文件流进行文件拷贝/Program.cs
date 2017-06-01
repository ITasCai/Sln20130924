using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _05通过文件流进行文件拷贝
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FileStream文件流的使用方式

            ////1.创建一个    中国.txt
            //string txt = "中国是世界上人口第一大国。中国是世界上最幸福的国家之一。中国是四大文明古国之一。中国有个杨中科。";

            ////一、创建一个文件流
            //FileStream fs = new FileStream(@"c:\中国.txt", FileMode.Create, FileAccess.Write);

            //byte[] buffer = Encoding.UTF8.GetBytes(txt);


            ////二、读文件或者写文件

            ////参数1：表示要把哪个byte[]数组中的内容写入到文件
            ////参数2：表示要从该byte[]数组的第几个下标开始写入,一般都是0
            ////参数3：要写入的字节的个数。
            //fs.Write(buffer, 0, buffer.Length);

            //////三、关闭文件流

            //////清空缓冲区
            ////fs.Flush();

            ////fs.Close();

            ////四、释放相关资源
            //fs.Dispose();

            //Console.WriteLine("ok");

            //Console.ReadKey();


            //=================================================================

            ////1.创建一个    中国.txt
            //string txt = "中国是世界上人口第一大国。中国是世界上最幸福的国家之一。中国是四大文明古国之一。中国有个杨中科。";

            ////一、创建一个文件流
            ////当把一个对象放到using()中的时候，当超出using的作用于范围后，会自动调用该对象的Dispose()f方法。
            //using (FileStream fs = new FileStream(@"c:\中国.txt", FileMode.Create, FileAccess.Write))
            //{

            //    byte[] buffer = Encoding.UTF8.GetBytes(txt);


            //    //二、读文件或者写文件

            //    //参数1：表示要把哪个byte[]数组中的内容写入到文件
            //    //参数2：表示要从该byte[]数组的第几个下标开始写入,一般都是0
            //    //参数3：要写入的字节的个数。
            //    fs.Write(buffer, 0, buffer.Length);
            //}
            //Console.WriteLine("ok");

            //Console.ReadKey();



            #endregion


            #region using使用

            ////using (Person p=new Person())
            ////{
            //            //using中的代码
            ////}

            //Person p = new Person();
            //try
            //{
            //    //using中的代码
            //}
            //finally
            //{
            //    p.Dispose();
            //}

            //Console.WriteLine("ok");
            //Console.ReadKey();
            #endregion


            #region using + FileStream

            ////创建文件流
            //using (FileStream fs = new FileStream("世界.txt", FileMode.Create))
            //{
            //    string world = "你好世界！";
            //    byte[] buffer = Encoding.UTF8.GetBytes(world);
            //    //2.读写文件
            //    fs.Write(buffer, 0, buffer.Length);

            //}
            //Console.WriteLine("ok");
            //Console.ReadKey();

            #endregion


            #region 使用文件流进行拷贝

            string source = @"e:\全面回忆.rmvb";
            string target = @"c:\全面回忆.rmvb";

            CopyFile(source, target);
            Console.WriteLine("ok");
            Console.ReadKey();


            #endregion

        }

        //文件拷贝
        private static void CopyFile(string source, string target)
        {
            //1.创建一个读取源文件的文件流
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            {
                //2.创建一个写入新文件的文件流
                using (FileStream fsWrite = new FileStream(target, FileMode.Create, FileAccess.Write))
                {

                    //创建缓冲区
                    byte[] buffer = new byte[1024 * 1024 * 5];//更方便阅读

                    //3.通过fsRead读取源文件，然后再通过fsWrite写入新文件

                    //通过文件流读取
                    //参数1：表示将来读取到的内容要存放到哪个数组中
                    //参数2：表示这个数据要从第几个索引开始填充数据、
                    //参数3：表示本次读取最多可以读取多少个字节。
                    //返回值：表示本次实际读取到的字节个数。
                    int byteCount = fsRead.Read(buffer, 0, buffer.Length);
                    while (byteCount > 0)
                    {
                        //把刚刚读取到的内容写入到新文件流中
                        fsWrite.Write(buffer, 0,byteCount);

                        //需要循环执行读写操作

                        //把上次读取到内容写入完毕后，继续再读取
                        byteCount = fsRead.Read(buffer, 0, buffer.Length);
                        //fsRead.Position
                        //fsWrite.Position
                        Console.Write(". ");
                    }




                }
            }


        }
    }

    class Person : IDisposable
    {

        #region IDisposable 成员

        public void Dispose()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Dispose()方法被调用了。。。。。");
        }

        #endregion
    }
}
