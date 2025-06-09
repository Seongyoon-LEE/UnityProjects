//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _06_09_CSharp
//{
//    internal class MainApp4
//    {
//        static void CoppyArray<T>(T[] source, T[] target) // 자료형을 결정짓지 않겠다 <T>
//        {
//            for (int i = 0; i < source.Length; i++)
//            {
//                target[i] = source[i];
//            }
//        }
//        //static void CoppyArray(string[] source, string[] target)
//        //{
//        //    for (int i = 0; i < source.Length; i++)
//        //    {
//        //        target[i] = source[i];
//        //    }
//        //}

//        static void Main(string[] args)
//        {
//            int[] source = { 1, 2, 3, 4, 5 };
//            int[] target = new int[source.Length];
//            CoppyArray<int>(source, target); // 컴파일할때 자료형을 결정한다 <T>
//            Console.WriteLine("int 배열 복사:");
//            foreach (var item in target)
//            {
//                Console.WriteLine(item);
//            }
//            string[] sourceStr = { "하나", "둘", "셋", "넷", "다섯" };
//            string[] targetStr = new string[sourceStr.Length];
//            CoppyArray<string>(sourceStr, targetStr);
//            Console.WriteLine("string 배열 복사:");
//            foreach (var item in targetStr)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}
