//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace _06_02_CSharp
//{
//    interface ILogger
//    {
//        void WriteLog(string message);
//    }
//    interface IFormattableLogger : ILogger // IFormattableLogger 인터페이스는 ILogger를 상속 받음 
//    {
//        void WriteLog(string message,params Object[] args);
//    }
//    class ConsoleLogger2 : IFormattableLogger
//    {
//        public void WriteLog(string message)
//        {
//            Console.WriteLine($"{DateTime.Now.ToLocalTime()} {message}");
//        }
//        public void WriteLog(string format, params Object[] args)
//        {
//            string message = string.Format(format, args);
//            Console.WriteLine($"{DateTime.Now.ToLocalTime()} {message}");
//        }
//    }
//    internal class MainApp
//    {
//        static void Main(string[] args)
//        {
//            IFormattableLogger logger = new ConsoleLogger2();
//            // IFormattableLogger 타입의 logger 객체 생성-> 상속 받았기 떄문에 인터페이스가 동적할당 될수 있따
//            logger.WriteLog("The world is not flat"); // 포맷된 로그 메세지 출력
//            logger.WriteLog("{0} + {1} = {2}", 1, 1, 2); // 포맷된 로그 메세지 출력 
//        }
//    }
//}
