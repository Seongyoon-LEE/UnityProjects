//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _06_03_CSharp
//{
//    class BirthdayInfo
//    {
//        private string? name;
//        private DateTime birthday; // 생일
//        public string? Name
//        {
//            get { return name; }
//            set { name = value; }
//        }
//        public DateTime Birthday
//        {
//            get { return birthday; }
//            set { birthday = value; }
//        }
//        public int Age
//        {
//            get
//            {
//                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
//            }
//        }
//        internal class MainApp
//        {
//            static void Main(string[] args)
//            {
//                BirthdayInfo birthday = new BirthdayInfo();
//                birthday.Name = "카리나";
//                birthday.Birthday = new DateTime(1998, 10, 30);
//                Console.WriteLine($"이름: {birthday.Name}");
//                Console.WriteLine($"이름: {birthday.Birthday.ToShortDateString()}");
//                Console.WriteLine($"이름: {birthday.Age}세");
//            }
//        }
//    }
//}
