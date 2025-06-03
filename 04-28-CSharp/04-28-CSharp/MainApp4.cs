//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////출력 전용 매개변수 
//namespace _04_28_CSharp
//{
//    internal class MainApp4
//    {                     //out 매개변수는 반드시 초기화 해야함 -> 유니티에서 많이씀
//                          //출력 전용 매개변수 -> 메서드 안에서 결과가 나오지 않고 매개변수로 나와서 전달됨
//        static void Divide( int a,  int b, out int quotient, out int remainder)
//        {
//            quotient = a / b;
//            remainder = a % b;

//        }
//        //가변 개수의 인수
//        static int Sum(params int [] numbers)
//        {
//            int sum = 0;
//            for (int i = 0; i < numbers.Length; i++)
//            {
//                sum += numbers[i];
//            }
//            Console.WriteLine();
//            return sum;
//        }

//        //보통 함수들은 중괄호 안에서 결과가 나옴
//        static void Main(string[] args)
//        {
//            //int a = 20;
//            //int b = 3;
//            //Divide(a, b, out int c, out int d);
//            //Console.WriteLine($"a :{a} b :{b}, a/b :{c} a%b : {d}");
//            int sum = Sum(1,2,3,4,5,6,7,8,9,10);
//            int sum2 = Sum(1, 2, 3, 4, 5);
//            Console.WriteLine($"sum : {sum}, sum2 : {sum2}");
//        }
//    }
//}
