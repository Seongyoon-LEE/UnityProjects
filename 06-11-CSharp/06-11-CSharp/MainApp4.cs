//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//// delegate와 Event를 같이 사용하는 예제 // 유니티에서 많이 사용 되는 형태 
//namespace _06_11_CSharp
//{
//    delegate void EventHandler(string message); // 이벤트 대리자 선언
//    class MyNotifier
//    {
//        public event EventHandler? SomethingHappend; // 위의 델리게이트를 클래스 안에서 수식 하고 있다.
//        public void DoSomething(int number)
//        {
//            int temp = number % 10;
//            if(temp !=0 && temp %3 == 0)
//            {
//                SomethingHappend!(String.Format("{0}:3의 배수.", number));
//            }
//        }
//    }
//    internal class MainApp4
//    {
//        static public void MyHandler(string message)
//        {
//            Console.WriteLine(message);
//        }
//        static void Main(string[] args)
//        {
//            MyNotifier notifier = new MyNotifier();
//            notifier.SomethingHappend += new EventHandler(MyHandler); // 이벤트에 메서드 연결
//            // += 연산자를 이용해서 체인 만들기
//            for(int i = 1; i <= 100; i++)
//            {
//                notifier.DoSomething(i); // 이벤트 발생
//            }
//            Console.WriteLine();
//            // 이벤트가 event 키워드로 수식한 대리자이다.
//            // 대리자와 이벤트의 차이 가장 큰 차이는 이벤트는 클래스 안에서만 호출할 수 있따.
//            // 이벤트는 public으로 선언되어 있어도 자신이 선언된 클래스 외부에서 호출이 불가능하다.
//            // 반면에 대리자는 public으로 선언되어 있으면 클래스 외부에서 호출이 가능하다.
//        }
//    }
//}
