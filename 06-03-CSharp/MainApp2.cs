//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////자동구현프로퍼티 7.0 이상버전에서 사용 가능
//namespace _06_03_CSharp
//{
//    public class NameCard
//    {
//        private string? name;
//        private string? phoneNumber;
//        public string? Name
//        {
//            get;set; // 자동 구현 프로퍼티
//        }
//        public string? PhoneNumber
//        {
//            get; set; // 자동 구현 프로퍼티
//        }
//    }
//    internal class MainApp2
//    {
//        static void Main(string[] args)
//        {
//            NameCard nameCard = new NameCard();
//            nameCard.Name = "카리나";
//            nameCard.PhoneNumber = "010-1234-5678";
//            Console.WriteLine($"이름: {nameCard.Name}");
//            Console.WriteLine($"폰번호: {nameCard.PhoneNumber}");
//        }
//    }
//}
