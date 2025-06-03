//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////추상클래스와 프로퍼티와의 관계
//namespace _06_03_CSharp
//{
//    abstract class Product
//    {
//        private static int serial = 0;
//        public  string SerialID
//        {
//            get { return String.Format("{0:d5}",serial++); }
//        }
//        abstract public DateTime ProductDate { get; set; } //추상 메서드 Abstract 메서드라서 자동구현 x 
//    }
//    class MyProduct : Product
//    {
//        public override DateTime ProductDate 
//        {
//            get; set;
//        }
//    }
//    internal class MainApp6
//    {
//        static void Main(string[] args)
//        {
//            MyProduct product_1 = new MyProduct()
//            {
//                ProductDate = new DateTime(2020,1,10)
//            };
//            Console.WriteLine($"Product: {product_1.SerialID} Product Date:{product_1.ProductDate}");

//            MyProduct product_2 = new MyProduct()
//            {
//                ProductDate = new DateTime(2020, 2, 3)
//            };
//            Console.WriteLine($"Product: {product_2.SerialID} Product Date:{product_2.ProductDate}");
//        }

//    }
//}
