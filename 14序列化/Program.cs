using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Person> list = new List<Person>() { 
            //new Person(){ Name="张三",Age =18},
            //new Person(){ Name="李四",Age =19},
            //new Person(){ Name="王五",Age =17}
            //};

            //string s = "==Name:张三,Age:18==|==Name:李四,Age:19==|==Name:王五,Age:17==";


            //string s = "开发部门王五25岁2008年10月25日入职|开发部门王五25岁2008年10月25日入职开发部门王五25岁2008年10月25日入职开发部门王五25岁2008年10月25日入职开发部门王五25岁2008年10月25日入职开发部门王五25岁2008年10月25日入职开发部门王五25岁2008年10月25日入职开发部门王五25岁2008年10月25日入职开发部门王五25岁2008年10月25日入职开发部门王五25岁2008年10月25日入职开发部门王五25岁2008年10月25日入职开发部门王五25岁2008年10月25日入职";


            //string s1 = "王五,开发部,25,2008-10-25|王五,开发部,25,2008-10-25王五,开发部,25,2008-10-25王五,开发部,25,2008-10-25王五,开发部,25,2008-10-25王五,开发部,25,2008-10-25王五,开发部,25,2008-10-25王五,开发部,25,2008-10-25";


            //序列化:就是指，格式化的过程。
            //对象序列化：对象格式化，把某个对象，使用另外一种格式来存储，更方便数据交换。
            //二进制序列化
            //xml序列化
            //JavaScript序列化


            //反序列化




        }
    }

    class Person
    {
        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }
    }
}
