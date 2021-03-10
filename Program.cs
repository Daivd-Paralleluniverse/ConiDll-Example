using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConiDll;
//ConiDll库运用范例

namespace 对象程序
{
    class Program
    {
        //函数定义运用
        /*
         static void Comp(double a, double b, double c)
        {
            if (a > b && b > c)

                Console.WriteLine("最大值为：" + a);

            else if (b > a && b > c)

                Console.WriteLine("最大值为：" + b);

            else

                Console.WriteLine("最大值为：" + c);
            
        }
        */
        static void Main(string[] args)
        {
            /*
               //Judge.Camax()三数比大应用
                Console.Write("请输入第一个数字:");
                string x = Console.ReadLine();
                Console.Write("请输入第二个数字:");
                string y = Console.ReadLine();
                Console.Write("请输入第三个数字:");
                string z = Console.ReadLine();
                double Res = Judge.Camax(Convert.ToDouble(x), Convert.ToDouble(y), Convert.ToDouble(z));
                Console.WriteLine("最大值为：" + Res);
                Console.ReadKey();
           
            //Judge.Camin()三数比小应用
                 Console.Write("请输入第一个数字:");
                 string x1 = Console.ReadLine();
                 Console.Write("请输入第二个数字:");
                 string y1 = Console.ReadLine();
                 Console.Write("请输入第三个数字:");
                 string z1 = Console.ReadLine();
                 double Res1 = Judge.Camin(Convert.ToDouble(x1), Convert.ToDouble(y1), Convert.ToDouble(z1));
                 Console.WriteLine("最小值为：" + Res1);
                 Console.ReadKey();
            //Ext.Sep()浮点数分离运用
            //Console.Write("请输入待转换的数字：");
            //string a=Console.ReadLine();
            //目前遇到元组解析需两次的情况。
            Console.WriteLine("整数部分为："+Ext.Sep().Item1+ "小数部分为：" + Ext.sep().Item2);
            Console.ReadKey();
            
            //Ext.For()an=n for语句集成方法
            Console.Write("请输入要累加的a1：");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入要累加的项数：");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("结果为："+Ext.For(a1,n));
            Console.ReadKey();
            
            //Ext.Rond()四舍五入方法
            Console.Write("请输入一个小数：");
            double a=Convert.ToDouble(Console.ReadLine());
            int a1=Convert.ToInt32(Ext.Rond(a));
            Console.WriteLine("结果为："+a1);
            Console.ReadKey();
            */
        }
    }
}

