using static System.Console;

namespace _04_22_CSharp
{
    internal class Program
    {
      //정적할당      //매개변수 -> 전달인자를 넣는 것 
        //static void Main(string[] args)//문자열의 길이가 0이면 
        //{
        //    #region 메인 메서드 매개변수 args 사용 방법 로직
        //    //if(args.Length == 0)
        //    //  {
        //    //      WriteLine($"2025-04-22-CSharp");//이 라인 출력 
        //    //      return; // 위에 조건에 맞다면 빠져 나감 
        //    //  }
        //    ////위의 조건이 아니라면 첫번째 문자열을 출력 
        //    //for(int i = 1; i < args.Length; i++) 
        //    //  WriteLine($"2025-04-22-CSharp: {args[i]}");
        //    #endregion

        //    #region 기본 데이터 형식
        //    //sbyte a = -10;
        //    //byte b = 40;
        //    //WriteLine($"a={a} b={b}");

        //    //short c = -30000;
        //    //ushort d = 60000;
        //    //WriteLine($"c={c} d={d}");

        //    //int e = -1000_0000; // _ ->자리 구분자 
        //    //uint f = 3_0000_0000;
        //    //WriteLine($"e={e} f={f}")
        //    //    ;
        //    //long g = -5000_0000_0000;
        //    //ulong h = 200_0000_0000_0000;
        //    //WriteLine($"g={g} h={h}");
        //    #endregion

        //    #region 2진수 16진수를 10진수로 변환 
        //    ////sbyte a = -10;
        //    ////sbyte b = -5000_0000_0000; // 오버플로우 : 값을 넘치는 현상
        //    ////        //overflow
        //    //byte a = 240;   //10진수 리터럴 상수 : 메모리 어딘가에 있는 것
        //    //WriteLine($"a = {a}");
        //    ////int sum = 20 + 30;
        //    //byte b = 0b111_0000; // 2진수 리터럴(literal) 상수 -> 0b를 붙힘
        //    //WriteLine($"b = {b}");
        //    //byte c = 0XF0; // 16진수 리터럴 상수 -> 0x를 붙힘
        //    //WriteLine($"c = {c}");
        //    //uint d = 0x1234_abcd; // 16진수 리터럴 상수
        //    //WriteLine($"d = {d}");
        //    #endregion

        //    #region overFlow되는 로직
        //    //byte a = 255;
        //    //sbyte b = (sbyte)a;
        //    ////형변환(Casting)
        //    //WriteLine(a);
        //    //WriteLine(b);
        //    //uint a = uint.MaxValue;
        //    //a += 1;//a=a+1;
        //    //WriteLine(a);
        //    #endregion

        //    #region 부동소수점을 표현하는 자료형들
        //    ////4바이트 소수점 7자리의 정밀도
        //    //float a = 3.1415_9265_3589_7963f;
        //    //WriteLine(a);
        //    ////8바이트 소수점 15자리의 정밀도
        //    //double b = 3.1415_9265_3589_7963d;
        //    //WriteLine(b);
        //    ////16바이트 29~30자리 근처의 정밀도
        //    //decimal c = 3.1415_9265_3589_7963_46234123456789m;
        //    //WriteLine(c);
        //    #endregion

        //    #region char string의 차이
        //    ////2바이트 글자 하나
        //    //char a = '안';
        //    //char b = '녕';
        //    //char c = '하';
        //    //char d = '세';
        //    //char e = '요';
        //    //string str = "안녕하세요!";
        //    //WriteLine(a);
        //    //WriteLine(b);
        //    //WriteLine(c);
        //    //WriteLine(d);
        //    //WriteLine(e);
        //    //WriteLine(str);
        //    #endregion

        //    #region object(모든 자료형의 부모, heap방식(참조형식))

        //    //bool isDead = false;
        //    ////object = 모든자료형의 부모이다.모든 자료형을 받아서 쓸 수가 있다.
        //    ///형변환이 일어나기 때문에 다른 데이터 형식을 사용한다.
        //    //object a = 123;
        //    //object b = 3.1415;
        //    //object c = "안녕하세요";
        //    //// 힙 참조형 데이터 
        //    //object d = true;
        //    //WriteLine($"{a}\t{b}\t{c}\t{d}");
        //    //int a = 123;
        //    //object b = (object)a;//박싱
        //    //int c = (int)b;//언박싱
        //    //Console.WriteLine($"{a} {b} {c}");
        //    #endregion

        //    #region
        //    //sbyte a = 127; //0111 1111
        //    //Console.WriteLine(a);
        //    //int b = (int)a;
        //    //int x = 128;
        //    //Console.WriteLine(x);
        //    //sbyte y = (sbyte)x;
        //    //Console.WriteLine(y);
        //    #endregion

        //}
    }
}
