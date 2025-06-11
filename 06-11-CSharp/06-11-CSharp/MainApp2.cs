//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;
////대리자 체인
////delegate Chain;
////하나의 대리자에 여러 메서드를 연결할 수 있다.
//namespace _06_11_CSharp
//{
//    delegate void Notify(string message); //대리자 선언
//    class Notifier
//    {
//        public Notify? EventOccured;
//    }
//    public class EventListener
//    {
//        public string name;
//        public EventListener(string name)
//        {
//            this.name = name;
//        }
//        public void SomethingHappened(string message)
//        {
//            Console.WriteLine($"{name}.SomethingHappened: {message}");
//        }
       
//    }
//    internal class MainApp2
//    {
//        static void Main(string[] args)
//        {

//            Notifier notifier = new Notifier();
//            EventListener listener1 = new EventListener("Listener1");
//            EventListener listener2 = new EventListener("Listener2");
//            EventListener listener3 = new EventListener("Listener3");

//            notifier.EventOccured += listener1.SomethingHappened; //이벤트에 메서드 연결
//            // += 연산자를 이용해서 체인 만들기
//            notifier.EventOccured += listener2.SomethingHappened; //이벤트에 메서드 연결
//            notifier.EventOccured += listener3.SomethingHappened; //이벤트에 메서드 연결

//            notifier.EventOccured("You've got mail!"); //이벤트 발생
//            Console.WriteLine();

//            notifier.EventOccured -= listener2.SomethingHappened; //이벤트에서 메서드 제거
//            notifier.EventOccured!("DownLoad Complate!"); //이벤트 발생

//            notifier.EventOccured = new Notify(listener1.SomethingHappened) //이벤트에 메서드 연결
//                                   +new Notify(listener3.SomethingHappened); //이벤트에 메서드 연결
//            notifier.EventOccured("NuClear lauch detected!"); //이벤트 발생

//        }
//    }
//}
