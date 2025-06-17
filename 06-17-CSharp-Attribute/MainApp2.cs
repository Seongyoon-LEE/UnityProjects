//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//// 어트리뷰트 자체보다 용도를 중심으로 공부 하는 편이 좋다.
//// 어트리뷰트는 부가정보이지 핵심이 아니기 때문이다.
//// 상황에 따라 사용방법도 그 수 너무 많기 때문이다.
//namespace _06_17_CSharp_Attribute
//{
//    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)] // Attribute, Property,Event가 두번 되게 허용
//    class History : System.Attribute
//    {
//        private string? programmer;
//        public double Version { get; set; }
//        public string Changes { get; set; }
//        public History(string programmer)
//        {
//            this.programmer = programmer;
//            Version = 1.0;
//            Changes = "초기 버전";
//        }
//        public string? Programmer
//        {
//            get { return programmer; }
//        }
//        [History("Kang", Version = 1.0, Changes = "2024-11-01 Created Class")]
//        [History("Sung", Version = 1.1, Changes = "2024-12-03 Add Class")]


//        class MyClass
//        {
//            public void Func()
//            {
//                Console.WriteLine("Func()");
//            }
//        }
//        internal class MainApp2
//        {
//            static void Main(string[] args)
//            {
//                Type type = typeof(MyClass);
//                Attribute[] attributes = Attribute.GetCustomAttributes(type);
//                Console.WriteLine("MyClass changes history.....");
//                foreach (Attribute a in attributes)
//                {
//                    History? h = a as History;
//                    if (h != null)
//                    {
//                        Console.WriteLine($"Ver : {h.Version} Programmer : {h.Programmer}" +
//                            $"Changes : {h.Changes}");
//                    }
//                }
//            }
//        }
//    }
//}
