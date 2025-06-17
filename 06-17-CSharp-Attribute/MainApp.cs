//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace _06_17_CSharp_Attribute
//{
//    public static class Trace
//    {
//        public static void WriteLine(string message,
//            // 파일 전체 경로
//            [CallerFilePath]string file = "",
//            // 줄 라인 행번호
//            [CallerLineNumber]int line = 0,
//            // 호출한 메서드 또는 프로퍼티
//            [CallerMemberName]string member = "")
//        {
//            Console.WriteLine($"{file} (Line : {line} {member} {message})");
//        }
//    }
//    internal class MainApp
//    {
//        static void Main(string[] args)
//        {
//            Trace.WriteLine("즐거운 프로그래밍");
//        }
//    }
//}
