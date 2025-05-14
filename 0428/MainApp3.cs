//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _04_28_CSharp
//{
//    internal class MainApp3
//    {
//        //참조에 의한 매개변수 전달 
//        //메써드 오버로딩 : 함수명이 같아도 매개변수나 자료형이 다르면  에러가 안남 + ref가 붙어도 
        
//        public static void Swap(ref int a,ref int b)
//        {//
//            int temp = b;
//            b = a;
//            a = temp;
            
//            Console.WriteLine($"a : {a}, c : {b}");
//        }
//        public static void Swap(ref int a, ref int b, ref int c)
//        {//
//            int temp = c;
//            c = a;
//            a = temp;

//            Console.WriteLine($"a : {a}, b : {b}, c : {c}");
//        }
//        static void Main(string[] args)
//        {
//            //int x = 3;
//            //int y = 5;
//            //
//            //Swap(ref x,ref y); //호출 한 다후 다음줄에서 메모리가 사라짐 -> 그래서 ref를 붙힘 
//            //Console.WriteLine($"x : {x}, y : {y}");

//            int a = 3;
//            int b = 5;
//            int c = 7;
//            Swap(ref a,ref c);
//            Console.WriteLine($"a : {a}, b : {b}, c : {c}");

//        }
//    }
//}
