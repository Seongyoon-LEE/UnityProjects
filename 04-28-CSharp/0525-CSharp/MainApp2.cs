using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0525_CSharp
{
    public class MyClass
    {
        int a, b, c;
        public MyClass()
        {
            this.a = 5425;
            Console.WriteLine("My Class()");

        }
        public MyClass(int b) : this() // this()는 생성자 호출
        {
            //this.a = 5425;
            this.b = b;
            Console.WriteLine("My Class(b)");
        }
        public MyClass(int b, int c) : this(b)
        {
            //this.a = 5425;
            //this.b = b;
            this.c = c;
            Console.WriteLine("My Class(b,c)");
        }
        public void printFeild()
        {
            Console.WriteLine($"a : {a}, b : {b}, c : {c}");
        }
    }
    internal class MainApp2
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.printFeild();
            Console.WriteLine();
            MyClass b = new MyClass(10);
            b.printFeild();
            Console.WriteLine();
            MyClass c = new MyClass(10, 20);
            c.printFeild();
        }

    }

}
