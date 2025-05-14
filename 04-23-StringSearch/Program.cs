using System.Diagnostics.CodeAnalysis;
using static System.Console;
namespace _04_23_StringSearch
{
    //문자열 다루기 
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 문자열 다루기
            //string? greeting = null;
            //greeting = "Good Morning";
            //WriteLine(greeting);
            //WriteLine($"IndexOf 'Good' : {greeting.IndexOf("Good")}");
            //WriteLine($"IndexOf 'o' : {greeting.IndexOf("o")}");
            ////현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치를 찾음 

            //WriteLine($"LastIndexOf 'Good' : {greeting.LastIndexOf("Good")}");
            //WriteLine($"LastIndexOf 'Good' : {greeting.LastIndexOf("o")}");
            ////현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치를 뒤에서 부터 찾음

            //WriteLine($"StartWith 'Good' : {greeting.StartsWith("Good")}");
            //WriteLine($"StartWith 'Morning' : {greeting.StartsWith("Morning")}");
            ////현재 문자열이 지정된 문자열로 시작하는지 평가한다.

            //WriteLine($"EndtWith 'Good' : {greeting.EndsWith("Good")}");
            //WriteLine($"EndWith 'Morning' : {greeting.EndsWith("Morning")}");
            ////현재 문자열이 지정된 문자열로 끝나는지 평가한다.

            //WriteLine($"Contains Evening : {greeting.Contains("Evening")}");
            //WriteLine($"Contains Morning : {greeting.Contains("Morning")}");
            ////현재 문자열이 지정된 문자열을 포함하는지 평가한다.

            //WriteLine($"Replace 'Morning' with 'Evening' : {greeting.Replace("Morning", "Evening")}");
            ////현재 문자열을 지정된 문자열로 변경
            #endregion

            #region 문자열 다루기2
            //WriteLine("ToLower() : {0}", "ABC".ToLower()); // 소문자 변환
            //WriteLine("ToUpper() : {0}", "abc".ToUpper()); // 대문자 변환

            //WriteLine("Insert() : {0}", "Happy Friday!".Insert(5,"Sunny")); 
            //WriteLine("Remove() : {0}", "Happy Friday!".Remove(2,3)); 
            #endregion

            #region 논리 연산자
            //// ++ -- 증감 연산자
            //WriteLine($"{3 > 4}");
            ////2+4*7= 연산자 우선순위
            ////논리   연산자 &&(and) ||(or) !(not)
            //WriteLine($"{1>0 && 4<5}");
            //WriteLine($"{1 == 0 && 4 > 5}");
            //WriteLine($"{1 == 1 || 4 > 5}");
            //WriteLine($"{!true}");
            #endregion

            #region 조건 연산자
            //조건식 ? 참 : 거짓
            //int a = 30;
            //int b = 20;
            //string result = a == 30 ? "삼십" : "삼십 아님";
            //WriteLine(result);
            //result = b == 25 ? "삼십" : "삼십 아님";
            //WriteLine(result);

            //WriteLine("입력한 숫자가 짝이냐 홀수냐 판별하세요 ");
            //int a = int.Parse(ReadLine()!);

            //if (a != 0)
            //{
            //    string result1 = (a % 2 == 0 ? "짝수" : "홀수");
            //    WriteLine(result1);

            //}
            //else
            //    WriteLine("a는 0이다");



            //WriteLine("입력한 숫자가 3의 배수인지 아닌지 판별하세요");
            //WriteLine("정수 입력 : ");
            //int a = int.Parse(ReadLine()!);
            //string result2 = a % 3 == 0 ? "3의 배수" : "3의 배수 아님";
            //WriteLine(result2);

            #endregion

            #region if 조건문 분기문
            // if else if else 조건문 분기문, switch문

            //WriteLine("양의 정수를 입력 : ");
            //int a = int.Parse(ReadLine()!);
            //if (a > 10)
            //{
            //    WriteLine("a는 10보다 크다");
            //}
            //else if (a < 0)
            //{
            //    WriteLine("a는 10보다 작다");
            //}
            //else
            //{
            //    WriteLine("a는 10이다");
            //}

            //WriteLine("정수를 입력하시오 :");
            //string input = ReadLine()!;
            //int num = int.Parse(input);
            //long num1 =Convert.ToInt64(input);

            //if(num < 0)
            //{
            //    WriteLine("음수");
            //}
            //else if(num > 0)
            //{
            //    WriteLine("양수");
            //}
            //else
            //{
            //    WriteLine("0");
            //}

            // 국어 수학 영어 점수 입력 받은 후 총점과 평균을 계산 하세요
            //WriteLine("국어 점수를 입력하시오 : ");
            //int? guk = int.Parse(ReadLine()!);
            //WriteLine("영어 점수를 입력하시오 : ");
            //int? yong = int.Parse(ReadLine()!);
            //WriteLine("수학 점수를 입력하시오 : ");
            //int? su = int.Parse(ReadLine()!);

            //int? sum = guk + yong + su;
            //int? sum1 = (guk + yong + su) / 3;

            //Write($"총점 : {sum}, 평균 : {sum1}, 학점 : ");
            //if (sum1 >= 90)
            //{
            //    WriteLine("A");
            //}
            //else if (sum1 >= 80)
            //{
            //    WriteLine("B");
            //}
            //else if (sum1 >= 70)
            //{
            //    WriteLine("C");
            //}
            //else if (sum1 >= 60)
            //{
            //    WriteLine("D");
            //}
            //else
            //{
            //    WriteLine("재수강");
            //}






            #endregion

            #region 중첩 if문
            //WriteLine("숫자를 입력하세요 : ");
            //string input = Console.ReadLine()!;
            //int num = Convert.ToInt32(input);
            //if(num > 0)
            //{
            //    if(num % 2 == 0)

            //        WriteLine($"0보다 큰 짝수");

            //    else

            //        WriteLine("0보다 큰 홀수");
            //}
            //else
            //{
            //    WriteLine("0보다 작거나 같은 수");
            //    //ABS : 절대값 
            //    WriteLine($"절대값 : {(MathF.Abs(num))}");
            //    WriteLine($"절대값 : {(num < 0 ? num*-1 :num)}");
            //}

            #endregion

            #region 문제1
            //WriteLine("정수를 입력하시오");
            //int a = int.Parse(Console.ReadLine()!);

            //WriteLine("정수를 입력하시오2");
            //int b = int.Parse(Console.ReadLine()!);

            //if(a>=b)
            //{
            //    WriteLine(a - b);
            //}
            //else
            //{
            //    WriteLine(b - a);
            //}
            #endregion

            #region 문제2
            //int? a = null;
            //int? b = null;
            //int? c = null;
            //float? avg = (a + b + c) / 3;

            //WriteLine("국어 점수 입력 :");
            //int.Parse(Console.ReadLine()!);
            //WriteLine("영어 점수 입력 :");
            //int.Parse(Console.ReadLine()!);
            //WriteLine("수학 점수 입력 :");
            //int.Parse(Console.ReadLine()!);

            //if (avg >= 90)
            //{
            //    WriteLine("A");
            //}
            //else if (avg >= 80)
            //{
            //    WriteLine("B");
            //}
            //else if (avg >= 70)
            //{
            //    WriteLine("C");
            //}
            //else if (avg >= 50)
            //{
            //    WriteLine("D");
            //}
            //else
            //{
            //    WriteLine("F");
            //}

            #endregion

            #region 문제3
            //WriteLine("정수를 입력하시오");
            //int a = int.Parse(Console.ReadLine()!);

            //WriteLine("정수를 입력하시오2");
            //int b = int.Parse(Console.ReadLine()!);

            //int result = a >= b ? a - b : b - a;
            //WriteLine(result);
            #endregion
        }
    }
}



