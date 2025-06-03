using System.Reflection.Metadata.Ecma335;
using static System.Console;
namespace _2025_04_24_CSharp
{
    internal class Program
    {
        // if 조건문 분기문 조건연산자 -> 코드의 흐름을 제어한다.
        //static int Pluse(int n1, int n2)
        //{
        //    int sum = n1 + n2;
        //    return sum;
        //}

        static void Main(string[] args)
        {
            //int result = Pluse(10, 30);
            //Console.WriteLine(result);

            #region switch문 조건이 간단 분기(나열)이 많을때
            //WriteLine("요일을 입력 바람");
            //string day = ReadLine()!;
            //switch (day)
            //{
            //    case "일":
            //        WriteLine("Sunday!");
            //        break;
            //    case "월":
            //        WriteLine("Monday!");
            //        break;
            //    case "화":
            //        WriteLine("Tuseday!");
            //        break;
            //    case "수":
            //        WriteLine("Wendsday!");
            //        break;
            //    case "목":
            //        WriteLine("Thursday!");
            //        break;
            //    case "금":
            //        WriteLine("Friday!");
            //        break;
            //    case "토":
            //        WriteLine("Saturday!");
            //        break;
            //    default:
            //        WriteLine("잘못 입력 하셨습니다.");
            //        break;
            #endregion

            #region switch문으로 성적 계산하기
            //int input = Convert.ToInt32(ReadLine());
            ////1의 자리 버림 ex) 92->90, 87->80
            //int score = (int)(Math.Truncate(input / 10.0) * 10);
            //string result = "";
            //switch (score)
            //{
            //    case 90:
            //        result = "A";
            //        break;
            //    case 80:
            //        result = "B";
            //        break;
            //    case 70:
            //        result = "C";
            //        break;
            //    case 60:
            //        result = "D";
            //        break;
            //    default:
            //        result = "F";
            //        break;
            //}
            //WriteLine(result);
            #endregion

            #region for문
            //WriteLine("5에서 10 숫자 사이의 값을 입력바람");
            //WriteLine("정수 입력 : ");
            //int input = int.Parse(ReadLine()!);

            //WriteLine("입력 한 숫자만큼 출력 결과가 나온다.");
            //    //초기화 // 조건 // 증감 
            //for(int i = 0; i < input; i++)
            //{
            //    WriteLine("MBC 아카데미!");
            //}

            //int num = 7;
            //for (int i = 9; i >= 1; i--)
            //{
            //    WriteLine($"{num}×{i} = {num * i}");
            //}

            #endregion

            #region 이중 for문
            //for(int i =2; i < 10 ;i++)
            //{
            //    for(int j = 1; j < 10 ;j++)
            //    {
            //        Console.WriteLine($"{i}x{j} = {i*j}");
            //    }
            //    WriteLine();
            //}

            //for (int i = 9; i > 1; i--)
            //{
            //    for (int j = 9; j > 0; j--)
            //    {
            //        Console.WriteLine($"{i}x{j} = {i * j}");
            //    }
            //    WriteLine();
            //}

            //for (int i = 0; i < 5;i++)
            //{
            //    for(int j=0; j<=i ;j++)
            //    {
            //        Write("*");
            //    }
            //    WriteLine();
            //}
            #endregion

            #region While문, 이중 while문
            //int a = 10; //초기화
            //while (a>0) //조건
            //{
            //    WriteLine(a--); //증감
            //}

            //int num = 5;
            //int i = 10;
            //while (i-- > 0)
            //{
            //    WriteLine($"{num}x{i} = {num * i}");
            //}

            //int cur = 9;
            //int num = 0;
            //while (cur > 1)
            //{
            //    num = 9;
            //    while (num > 0)
            //    {
            //        WriteLine($"{cur}x{num} = {cur * num}");
            //        num--;
            //    }
            //    cur--;
            //    WriteLine();
            //}


            //int i = 0;
            //int j = 0;
            //while(i++<5)
            //{
            //    j = 0;
            //    while(j++<i )
            //    {
            //        Write("*");                    
            //    }          
            //    WriteLine();
            //}

            #endregion

            #region do while문(실행을 무조건 한번 한다)
            //int total = 0, num = 0;
            //do
            //{
            //    WriteLine("정수 입력(0 to quit) :");
            //    num = int.Parse(ReadLine()!);
            //    total += num;

            //} while (num != 0);
            //WriteLine($"합계:{total}");

            //int i = 10;
            //do
            //{
            //    if (i == 100) break;
            //    WriteLine(i++);
            //} while (true);

            // for while do while

            #endregion

            #region 문제1
            //WriteLine("양의 정수 하나 입력 ");
            //int a = int.Parse(Console.ReadLine()!);

            //for (int i = 0; i < a; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 문제2
            //Console.WriteLine("양의 정수 하나 입력 바람");
            //int a = int.Parse(ReadLine()!);

            //for(int i = 1; i < a+1; i++)
            //{
            //    Console.WriteLine($"{i * 3}");
            //}


            #endregion

            #region 문제3
            //int total = 0;
            //Console.WriteLine("정수 입력해");
            //int a = int.Parse(Console.ReadLine()!);
            //int b = 1;
            //for (int i = 0; i < b; i++)
            //{
            //    if (a == 0)
            //    {
            //        total += a;
            //    }
            //    else
            //    {
            //        Console.WriteLine("정수 입력해주세요");
            //        a = int.Parse(Console.ReadLine()!);

            //        total += a;
            //        b++;
            //    }
            //}
            // Console.WriteLine($"총합 : {total}");
            #endregion

            #region 문제4
            //int num = int.Parse(Console.ReadLine()!);
            //int i = 10;
            //while (i-- > 0)
            //{
            //    WriteLine($"{num}x{i} = {num * i}");
            //}
            #endregion

            #region 문제5
            //float total = 0;
            //int b = 0;
            //WriteLine("정수 몇개?");
            //float a = int.Parse(ReadLine()!);

            //for (int i = 0; i < a; i++)
            //{
            //    WriteLine("정수 입력");
            //    b = int.Parse(ReadLine()!);
            //    total += b;
            //}
            //WriteLine($"평균 값 : {total / a}");

            //int total = 0, i = 0;
            //int num, input;
            //Console.WriteLine("입력할 정수의 수는 ?");
            //num = int.Parse(ReadLine()!);
            //while (i++<num)
            //{
            //    Console.WriteLine("정수의 입력 :");
            //    input = int.Parse(ReadLine()!);
            //    total += input;
            //}
            //Console.WriteLine($"입력의 평균 :{(double)total/num:F3}");

            #endregion
            //문제 6


            //WriteLine("정수 5개 입력 바람");
            //int b = 5;
            //int total = 0;
            //for (int i = 0; i < b; i++)
            //{
            //    Write("정수 입력 : ");
            //    int a = int.Parse(ReadLine()!);
            //    if (a < 1)
            //    {
            //        WriteLine("0보다 큰 수를 입력해주세요");
            //        b++;
            //    } else
            //    {
            //        total += a;
            //    }
            //}
            //WriteLine(total);

            //int i = 0;
            //int hap = 0;
            //int input = 0;
            //Console.WriteLine("정수 5개 입력");
            //while(i<5)
            //{
            //    while(input<=0)
            //    {
            //        Console.WriteLine($"0보다 큰수를 입력 {i}번째");
            //        input = int.Parse( Console.ReadLine()!);
            //    }
            //    hap += input;
            //    input = 0;
            //    i++;
            //}

            //문제 7
            //행
            //for (int i = 0; i < 5; i++)
            //{                //열
            //    for (int j = 0; j < i; j++)
            //    {
            //        WriteLine("*");
            //    }
            //    Console.WriteLine("0");
            //}

            //int a = int.Parse(Console.ReadLine()!);
            //int i = 1;
            //while(i<=a)
            //{
            //    Console.WriteLine(i*3);
            //    i++;
            //}


            int num = 5;
            for(int i = 1; i <=num; i++)
            {
                Console.WriteLine("*");
                for(int j = 0; j >i; j++)
                {
                    Console.WriteLine("*");
                }
            }
        }
    }
}

