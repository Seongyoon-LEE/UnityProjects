//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//// Func와 Action을 사용한 람다식 예제
//namespace _06_12_CSharp
//{
//    internal class MainApp
//    {
//        static void Main(string[] args)
//        {
//            // Func: 매개변수와 반환형이 있는 대리자
//            Func<int> func1 = () => 42; // 매개변수 없음, int 반환
//            Console.WriteLine(func1());
//            Console.WriteLine();
//            Func<int, int> func2 = x => x * 2;
//            Console.WriteLine(func2(4));
//            Console.WriteLine();
//            Func<double, double, double> func3 = (x, y) => x + y; // 매개변수 2개, double 반환
//            Console.WriteLine(func3(3.14, 2.71));
//            Console.WriteLine();
//            // Action: 반환형이 없는 void 메서드를 대리 하는 대리자
//            Action action1 = () => Console.WriteLine("Hello, World!"); // 매개변수,반환형 없음
//            action1();
//            int result = 0;
//            Action<int> action2 = x => result += x; // 매개변수 1개, 반환형 없음
//            action2(10);
//            Console.WriteLine(result);
//            Action<double, double> action3 = (x, y) =>
//            {
//                double pi = x / y;
//                Console.WriteLine($"x: {x},y: {y} : {pi}");
//            }; // 매개변수 2개, 반환형 없음
//            action3(3.14, 2.71);
//        }
//    }
//}
