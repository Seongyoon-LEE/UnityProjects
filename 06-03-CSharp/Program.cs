//using System.Security.Cryptography.X509Certificates;

//namespace _06_03_CSharp
//{
//    class MyClass
//    {
//        private int myField; // 은닉성
//        public int GetMyField() // getter 메서드 
//        {
//            return myField;
//        }
//        public void SetMyField(int value) // setter 메서드 
//        {
//            myField = value;
//        }  
//    }
//    class YourClass
//    {
//        private int myField; // 은닉성
//        private int myField2;
//        //property 사용
//        public int MyField
//        {
//            get { return myField; }
//            set {  myField = value; }
//        }
//        public int MyField2
//        {
//            get { return myField2; }
//            set { myField2 = value; }
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//           MyClass obj = new MyClass();
//            obj.SetMyField(10); // Set the value using the setter
//            Console.WriteLine(obj.GetMyField());
           
//            YourClass yourObj = new YourClass();
//            yourObj.MyField = 20;
//            Console.WriteLine(yourObj.MyField);
//            yourObj.MyField2 = 30;
//            Console.WriteLine(yourObj.MyField2);
//        }
//    }
//}
