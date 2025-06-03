//namespace _0525_CSharp;
//using static System.Console;

//#region static 변수
////public class Golobal
////{
////    public static int count = 0; // 정적 변수 전역 변수
////}
////public class ClassA
////{
////    public ClassA()
////    {
////        Golobal.count++;
////    }
////}
////public class ClassB
////{
////    public ClassB()
////    {
////        Golobal.count++;
////    }
////}
//#endregion

////객체 복사하기 얕은 복사 깊은 복사
//public class MyClass // 얕은 복사
//{
//    public int num1;
//    public int num2;

//}
//public class MyClass2 // 깊은 복사
//{
//    public int num1;
//    public int num2;
//    public MyClass2 DeepCopy()
//    {
//        MyClass2 newCopy = new MyClass2();
//        newCopy.num1 = this.num1;
//        newCopy.num2 = this.num2;
//        return newCopy;
//    }
//}
//internal class MainApp
//{
//    static void Main(string[] args)
//    {
//        #region 정적변수 전역변수
//        //Console.WriteLine($"Clobal.Count : {Golobal.count}");
//        //new ClassA();
//        //new ClassA();
//        //new ClassB();
//        //new ClassB();
//        //Console.WriteLine($"Clobal.Count : {Golobal.count}");
//        #endregion
//        #region 생성자및 정적 메소드 동적 메소드
//        //Calculator cal = new Calculator();
//        //cal.Result();
//        //Calculator cal2 = new Calculator(10);
//        //cal2.Result();
//        //Calculator cal3 = new Calculator(10, 20);
//        //cal3.Result();
//        //Calculator.Divide(10, 20);
//        #endregion
//        MyClass source = new MyClass();
//        source.num1 = 10;
//        source.num2 = 20;
//        MyClass target = source; //얕은 복사 스왈로그 카피 
//        target.num2 = 30;
//        WriteLine($"source.num1 : {source.num1}, source.num2 : {source.num2}");

//        MyClass2 source2 = new MyClass2();
//        source2.num1 = 10;
//        source2.num2 = 20;
//        MyClass2 target2 = source2.DeepCopy();  
//        target.num2 = 30;
//        WriteLine($"source2.num1 : {source2.num1}, source2.num2 : {source2.num2}");
//    }
//}

