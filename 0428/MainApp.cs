//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _04_28_CSharp
//{
//    public class Calculator
//    {
//        public static int Plus(int a, int b)
//        {
//            return a + b;
//        }

//        public static int Minus(int a, int b)
//        {
//            return a - b;
//        }
//        public static int Multiply(int a, int b)
//        {
//            return a * b;
//        }
//        public static int Divide(int a, int b)
//        {
//            return a / b;
//        }


//    }

//    public class MainApp
//    {
//        static void Main(string[] args)
//        {
//            #region 동적 할당
//            // 정적 할당 동적 할당 차이
//            // 정적할당 : 메모리 할당이 컴파일 시점에 결정 -> 실행전 메모리 확보 static
//            // 동적할당 : 메모리 할당이 런타임(실시간) 시점에 결정 -> 실시간 메모리 확보 new
//                            // 객체 생성 
//            //Calculator cal = new Calculator();
//            //int result = cal.Plus(10, 20);
//            //Console.WriteLine(result);
//            //result = cal.Minus(30, 10);
//            //Console.WriteLine(result);
//            //result = cal.Multiply(30, 40);
//            //Console.WriteLine(result);
//            #endregion

//            #region 정적 할당
//            //int result = Calculator.Plus(1, 2);
//            //Console.WriteLine(result);
//            //result = Calculator.Minus(30, 10);
//            //Console.WriteLine(result);
//            //result = Calculator.Multiply(30, 40);
//            //Console.WriteLine(result);
//            #endregion


//        }
//    }
//}
