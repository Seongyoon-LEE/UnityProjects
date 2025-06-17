//namespace _06_17_CSharp_Attribute
//{
//    // Attribute
//    // 개발자가 쓰고 컴파일러가 읽어서 컴퓨터로 실행 시킨다.
//    // 메타데이터 : 데이터의 데이터를 말한다.
//    // C#코드도 데이터이지만 이코드에 대한 정보 데이터의 데이터를
//    // 메타 데이터라고한다.
//    // 어트리뷰트나 리플렉션을 통해 얻는 정보등을 말함
//    class MyClass
//    {
//        [Obsolete("이 메서드는 폐기되었습니다. NewMethod를 사용바람")]
//        public void OldMethod()
//        {
//            Console.WriteLine("I'm Old");
//        }
//        public void NewMethod()
//        {
//            Console.WriteLine("I'm new");
//        }

//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            MyClass obj = new MyClass();
//            obj.OldMethod();
//            obj.NewMethod();
//        }
//    }
//}
