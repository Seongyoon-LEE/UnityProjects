//using System.Threading.Channels;

//namespace _06_02_CSharp
//{
//    interface ILogger // 메서드나 뒤에 배울 속성, 이벤트 등을 정의할 수 있는 인터페이스, Interface는 선언을 하고 그걸 상속받은 Class가 구현을 강제 당한다.
//    {
//        void WriteLog(string message);
//    }
//    class ConsolLogger : ILogger // 인터페이스를 구현하는 클래스
//    {
//        public void WriteLog(string message) // 인터페이스의 메서드 구현
//        {
//            Console.WriteLine($"{DateTime.Now.ToLocalTime} {message}");
//        }
//    }
//    class FileLogger : ILogger // 인터페이스를 구현하는 클래스
//    {
//        private StreamWriter writer;
//        public FileLogger(string path) // 생성자에서 파일 경로를 받아서 초기화
//        {
//            writer = File.CreateText(path); // 파이릉ㄹ 생성하고 스트림 라이터를 초기화
//            writer.AutoFlush = true; // 자동으로 버퍼를 비우도록 설정
//        }
//        public void WriteLog(string message) // 인터페이스의 메서드 구현
//        {
//            // 파일에 로그를 기록하는 로직을 여기에 작성
//            writer.WriteLine($"File log: {DateTime.Now.ToShortTimeString()} {message}");
//        }
//    }
   
//    class ClimateMonitor
//    {
//        private ILogger logger; // ILogger 인터페이스 타입의 필드
//        public ClimateMonitor(ILogger logger) // 생성자에서 ILogger 타입의 객체를 받음
//        {
//            this.logger = logger; // 필드에 할당
//        }
//        public void start() // 온도를 로그로 기록하는 메서드
//        {
//            while(true)
//            {
//                Console.WriteLine("온도를 입력 해주세요: ");
//                string? temperature = Console.ReadLine(); // 사용자로부터 온도 입력 받기
//                if (temperature == "") break;
//                logger.WriteLog($"현재 온도 : {temperature}");
//            }
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MoyLog.txt"));
//            // 파일 로거를 사용하여 ClimateMonitor 생성 
//            monitor.start(); // 온도 입력을 시작

//        }
//    }
//}
