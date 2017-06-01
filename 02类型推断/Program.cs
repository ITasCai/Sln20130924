using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.Collections;

namespace _02类型推断
{
    class Program
    {

        //static var Age;

        static void Main(string[] args)
        {

            #region MyRegion
            //强类型,在编译的时候就已经能确定数据类型了。
            //string n = "aaaa";

            //n = 10;


            //弱类型,程序编译的时候无法确定数据类型，在运行的时候才会确定数据类型。
            //n = "aaaa";
            //n=10;

            //dynamic d = new ExpandoObject();

            //d.Name = "张三";

            //d.Age = 19;


            //Console.WriteLine(d.Name);
            //Console.WriteLine(d.Age);
            //Console.Read();
            #endregion

            #region C#中的 var 是强类型

            //var依然是强类型的，
            //编译器会在编译的时候将其替换为对应的数据类型
            //编译器根据“等号”右边的数据的类型自动推断出应该是什么数据类型，就会将var替换成对应的数据类型。

            //var这种类型推断只能应用在方法的局部变量中
            //不能将var应用于类的成员变量、方法的参数、方法的返回值
            //var n = 100;
            //var s = "aaaa";
            ////int n = 100;

            #endregion

            string[] names = new string[] { "a", "b" };

            foreach (var item in names)
            {

            }

            List<int> list = new List<int>();
            foreach (var item in list)
            {

            }


            ArrayList arrlist = new ArrayList();
            foreach (var item in arrlist)
            {

            }

            Hashtable hash = new Hashtable();
           

            foreach (var item in hash.Keys)
            {

            }

            foreach (var item in hash.Values)
            {

            }


            ////这里的var应该是DictionaryEntry类型，但类型推断却是object
            //foreach (var item in hash)
            //{

            //}

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var item in dict.Keys)
            {

            }

            foreach (var item in dict.Values)
            {

            }


            //这里的var可以正常推断出来var表示的是KeyValuePair<string,int> 类型。
            foreach (var item in dict)
            {

            }


           



        }

        //static void M1(var n)
        //{

        //}

        //static var M2()
        //{
        //    return "aaa";
        //}
    }
}
