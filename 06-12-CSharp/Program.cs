//namespace _06_12_Lambda_CSharp
//{
//    internal class Program
//    {
//        delegate int Calculate(int x, int y);
//        delegate string Concatenate(string[] args);
//        delegate void DoSomething();
//        static void Main(string[] args)
//        {
//            // Lambda식
//            Calculate add = (x, y) => x + y;
//            Calculate multi = (x, y) => x * y;
//            Calculate divide = (x, y) => x / y;

//            Calculate cal;
//            cal = delegate (int x, int y)
//            {
//                return x + y;
//            };
//            Console.WriteLine($"{3} + {4} : {add(3, 4)}");
//            Console.WriteLine($"{3} * {4} : {multi(3, 4)}");
//            Console.WriteLine($"{3} / {4} : {divide(3, 4)}");
//            Console.WriteLine();
//            Concatenate concat = (string[] str) =>
//            {
//                string result = "";
//                foreach (var s in str)
//                {
//                    result += s + " ";
//                }
//                return result;
//            };
//            Console.WriteLine(concat(args));
//            // Func<string[], string> 델리게이트를 사용하여 익명 메소드 정의
//            Func<string[], string> concat2 = delegate (string[] str)
//            {
//                string result = " ";
//                foreach (var s in str)
//                {
//                    result += s + " ";
//                }
//                return result;
//            };
//            Console.WriteLine(concat2(args));

//            DoSomething DoIt = () =>
//            {
//                Console.WriteLine("무언가를 해보자");
//                Console.WriteLine("한숨만 쉬지 말고");
//            };
//            DoIt();
//            Console.WriteLine();

//            DoSomething DoIt2 = delegate ()
//            {
//                Console.WriteLine("무언가를 해볼까");
//                Console.WriteLine("한숨만 쉬지 말까");
//            };
//            DoIt2();
//        }
//    }
//}
