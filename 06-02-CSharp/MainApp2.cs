//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Channels;
//using System.Threading.Tasks;

//namespace _06_02_CSharp
//{
//    interface IRunnable
//    {
//        void Run();
//    }
//    interface IFlyable
//    {
//        void Fly();
//    }
//    class FlyIngCar : IRunnable, IFlyable
//    {
//        public void Run()
//        {
//            Console.WriteLine("The flying car is running on the road.");
//        }
//        public void Fly()
//        {
//            Console.WriteLine("The flying car is flying in the sky");
//        }
//    }
//    interface ILogger
//    {
//        void WriteLog(string message);
//        void WriteError(string message)
//        {
//            WriteLog($"Error: {message}");
//        }
//    }
//    public class  ConsoleLogger : ILogger
//    {
//        public void WriteLog(string message)
//        {
//            Console.WriteLine($"{DateTime.Now.ToLocalTime()} {message}");
//        }
//        public void WriteError(string message)
//        {
//            Console.WriteLine($"{DateTime.Now.ToLocalTime()} Error: {message}");
//        }
//    }
//    internal class MainApp2
//    {
//        static void Main(string[] args)
//        {
//            //FlyIngCar car = new FlyIngCar();
//            //car.Run();
//            //car.Fly();
//            //// FlyingCar 클래스는 IRunnable과 IFlyable 인터페이스를 모두 견하므로,
//            //// 두 메서드를 모두 호출할 수 있습니다.
//            //IRunnable runnable = car as IRunnable;
//            //runnable?.Run();
//            //IFlyable flyable = car as IFlyable;
//            //flyable?.Fly();
            
//            ILogger logger = new ConsoleLogger();
//            logger.WriteLog("System UP");
//            logger.WriteError("SystemFaile");
//            ConsoleLogger cLogger = new ConsoleLogger();
//            cLogger.WriteLog("SystemUP");
//            cLogger.WriteError("SystemFail");
//            //에러가 나는 이유 : ConsoleLogger가 WriteError를 오버라이딩 하지 않았기 때문

//        }
//    }
//}
