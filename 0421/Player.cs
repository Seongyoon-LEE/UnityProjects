using static System.Console;
//한번만 선언하고 생략할 수 있다. -> Console클래스 생략
namespace _04_21_CSharp
{
    internal class Player
    {
        //정적할당,비어있음 함수(메서드) 명:Main (입력)
        static void Main(string[] args)
        {
            #region 복합연산자 (+=, -=, *=, /=, %=)
            ////F5는 한줄씩 검사 ctr + f5 전체 한꺼번에 검사 
            //int hp = 100;
            //int attack = 10;
            //hp -= attack;   // -= 복합연산자
            ////hp = hp - attack;
            //WriteLine(hp);
            //hp += 2;
            //WriteLine(hp);
            //hp *= 3;
            //WriteLine(hp);
            //hp /= 5; WriteLine(hp);
            //hp %= 5; WriteLine(hp);
            #endregion

            #region 실수표현 하는 자료형
            //float PI = 3.1415000f;
            //double dPI = 3.141512345689012345678d;
            //decimal dePI = 3.141512345689012345678123456m;
            ////데시몰 회계
            //Write($"{PI} \t"); Write($"{dPI}\t"); Write($"{dePI}");
            #endregion

            #region 정수표현 하는 자료형
            ////int는 4byte
            //int num1 = 20, num2 = 20, sum = 0;
            //sum += num1;
            //sum += num2;
            //WriteLine($"합계:{sum}");
            ////short는 2byte
            //short n1 = 1, n2 = 2;
            //short sum2 = n1 + n2;   // 계산하는 순간 int 형식이 되는데 short 형식으로 변환 x
            //WriteLine($"{sizeof(short)}");
            //WriteLine($"{sum2}");
            #endregion

            //정수형 자료형 
            byte n1 = 0; // 1byte
            short n2 = 0;// 2byte
            int n3 = 0; //  4byte 21억 이상까지 int로 표현
            long n4 = 0; // 8byte 21억 이상이면 long으로 표현
        }
    }
}
