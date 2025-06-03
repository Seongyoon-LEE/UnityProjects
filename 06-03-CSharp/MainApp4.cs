//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////프로퍼티와 생성자를 이용해서 유용하게 객체를 초기화 하는 방법
//namespace _06_03_CSharp
//{
//    public class BirthdayInfo
//    {
//        public string Name { get; set; } // 자동 구현 프로퍼티
//        public DateTime Birthday { get; set; } // 기본 생성자는 알아서 호출된다 
//        public BirthdayInfo() { Console.WriteLine("생성자 호출!"); }
        
//        public int Age
//        {
//            get
//            {
//                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
//            }
//        }
//    }
//    internal class MainApp4
//    {
//        static void Main(string[] args)
//        {
//            BirthdayInfo birth = new BirthdayInfo()
//            {
//                Name = "카리나",
//                Birthday = new DateTime(1998, 10, 30)
//            };
//            Console.WriteLine($"Name: {birth.Name}");
//            Console.WriteLine($"birthday: {birth.Birthday.ToShortDateString()}");
//            Console.WriteLine($"age: {birth.Age}");
//        }
//    }
//}
