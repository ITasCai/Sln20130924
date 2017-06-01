using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _11工资文件翻倍练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.读取
            using (StreamReader reader = new StreamReader("工资文件.txt", Encoding.Default))
            {
                //2.写入
                using (StreamWriter writer = new StreamWriter("新工资文件.txt", false, Encoding.UTF8))
                {
                    string line = null;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        string newLine = parts[0] + "|" + Convert.ToInt32(parts[1]) * 2;
                        writer.WriteLine(newLine);
                    }
                }

            }
            Console.WriteLine("ok");
            Console.ReadKey();
        }
    }
}
