//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////무명형식
//namespace _06_03_CSharp
//{
//    interface INamedValue
//    {
//        string Name { get; set; } // Interface는 구현부가 없어서 string Name은 자동구현프로퍼티가 아니다.
//        string Value { get; set; }
//    }
//    class NamedValue : INamedValue
//    {
//        public string? Name { get; set; }
//        public string? Value { get; set; }
        
//    }

//    internal class MainApp5
//    {
       
//        static void Main(string[] args)
//        {
//            #region 무명형식
//            ////인스턴스 될때 프로퍼티가 초기화 된다.
//            //var myInstance = new { Name = "이승엽", Age = 47 };
//            //Console.WriteLine($"Name: {myInstance.Name}");
//            //Console.WriteLine($"Age: {myInstance.Age}");

//            //var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };
//            //Console.WriteLine($"Subject {b.Subject}, Scores:");
//            //foreach(var score in b.Scores)
//            //{
//            //    Console.WriteLine(score);
//            //}
//            //Console.WriteLine();
//            #endregion

//            NamedValue name = new NamedValue()
//            {
//                Name = "이름",
//                Value = "이성윤"
//            };
//            NamedValue height = new NamedValue()
//            {
//                Name = "키",
//                Value = "180"
//            };
//            NamedValue weight = new NamedValue()
//            {
//                Name = "몸무게",
//                Value = "80kg"

//            };
//            //무명형식으로 프로퍼티 초기화
//            Console.WriteLine($"{name.Name} : {name.Value}");
//            Console.WriteLine($"{height.Name} : {height.Value}");
//            Console.WriteLine($"{weight.Name} : {weight.Value}");

//        }

//    }
//}
