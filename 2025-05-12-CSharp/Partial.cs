//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2025_05_12_CSharp
//{
//    //분할 클래스 : 클래스의 구현이 길어질 경우 여러 파일로 나누어 구현할 수 있다
//    public partial class MyClass
//    {
//        public void Methoad_A()
//        {
//            Console.WriteLine("Methoad_A");
//        }
//        public void Methoad_B()
//        {
//            Console.WriteLine("Methoad_B");
//        }
//    }

//    public partial class MyClass
//    {
//        public void Methoad_C()
//        {
//            Console.WriteLine("Methoad_C");
//        }
//        public void Methoad_D()
//        {
//            Console.WriteLine("Methoad_D");
//        }
//    }
//    internal class Partial
//    {
//        static void Main(string[] args)
//        {
//            MyClass myClass = new MyClass();
//            myClass.Methoad_A();
//            myClass.Methoad_B();
//            myClass.Methoad_C();
//            myClass.Methoad_D();
//            Console.WriteLine();
//        }
//    }
//}
