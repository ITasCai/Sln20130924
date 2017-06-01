using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _06文件拷贝复习
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"C:\Documents and Settings\Administrator\桌面\Net黑马9期讲课\Net基础加强20130924\视频\04文件流操作.avi";

            string target = @"c:\wjl.avi";

            CopyFile(source, target);
            Console.WriteLine("ok");
            Console.ReadKey();
        }

        private static void CopyFile(string source, string target)
        {
            //创建两个文件流，一个读取，一个写入

            //读取文件的流
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            {
                //byte b = 19;
                //byte bb = (byte)(byte.MaxValue - b);

                //获取原文件的大小
                long len = fsRead.Length;

                //写入文件流
                using (FileStream fsWrite = new FileStream(target, FileMode.Create, FileAccess.Write))
                {
                    //创建一个缓冲区
                    byte[] buffer = new byte[1024 * 1024 * 2];

                    //通过fsRead流读取一部分数据到buffer中
                    int r = fsRead.Read(buffer, 0, buffer.Length);
                    while (r > 0)
                    {
                        Console.Write(". ");
                        //将读取到的内容写入到fsWrite流中
                        fsWrite.Write(buffer, 0, r);
                        double d = fsWrite.Position * 1.0 / len;
                        Console.WriteLine("已经拷贝完毕了：{0}%", d * 100);

                        r = fsRead.Read(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }


}
