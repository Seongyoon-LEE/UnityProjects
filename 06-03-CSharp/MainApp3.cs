//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _06_03_CSharp
//{
//    class BirthdayInfo
//    {
//        public string? Name { get; set; } = "UnKnown"; // 자동구현프로퍼티
//        public DateTime Birthday { get; set; } = new DateTime(1999, 10, 11);
//        public int Age
//        {
//            get
//            {
//                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
//            }
//        }//자동구현 프로퍼티로 Age를 게산하는 프로퍼티
//    }
//    internal class MainApp3
//    {
//        static void Main(string[] args)
//        {
//            BirthdayInfo birthday = new BirthdayInfo();
//            Console.WriteLine($"Name: {birthday.Name}");
//            Console.WriteLine($"birthday: {birthday.Birthday.ToShortDateString()}");
//            Console.WriteLine($"Age: {birthday.Age}세");

//            birthday.Name = "카리나";
//            birthday.Birthday = new DateTime(2000, 01, 17);

//            Console.WriteLine($"Name : {birthday.Name}");
//            Console.WriteLine($"birthday : {birthday.Birthday.ToShortDateString()}");
//            Console.WriteLine($"Age : {birthday.Age}세");
//        }

//    }
//}
