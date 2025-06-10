using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _06_10_CSharp
{
    static internal class MainApp2
    {
        //static int Divide(int dividend, int divisor)
        //{
        //    try
        //    {
        //        Console.WriteLine("Divide() 시작");
        //        return dividend / divisor; // 0으로 나누면 예외 발생
        //    }
        //    catch(DivideByZeroException e)
        //    {
        //        Console.WriteLine($"Divide 예외 발생: {e.Message}");
        //        throw e; // 예외를 던져서 호출한 곳에서 처리하도록 함
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Divide 메서드 종료");
        //    }
        //}
        static void Main(string[] args)
        {
            
                try
                {
                    int[] arr = new int[10];

                    for (int i = 0; i < 10; i++)
                        arr[i] = i;

                    for (int i = 0; i < 11; i++)
                        Console.WriteLine(arr[i]);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine($"처리되지 않은 예외: {e.Message}:인덱스가 배열 범위를 벗어났습니다.");
                }
                finally
                {
                    Console.WriteLine("비정상 종료합니다.");
                }
            
            #region 배열의 경계를 넘어가는 예외처리
            //int[] arr = new int[3] { 1, 2, 3 };
            //try // 예외가 발생할만한 지역에 try 블록을 사용 
            //{
            //    for(int i = 0; i<3; i++)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //    Console.WriteLine();
            //}
            //catch(IndexOutOfRangeException e)
            //{
            //    Console.WriteLine($"예외 발생 : {e.Message}");
            //}
            //Console.WriteLine("종료!!!");
            #endregion

            #region 0으로 나누기 예외처리
            //try
            //{
            //    Console.WriteLine("0이상 정수를 두개 입력하세요");
            //    Console.Write("첫번째 정수 입력: ");
            //    int num1 = int.Parse(Console.ReadLine()!);
            //    Console.Write("두번째 정수 입력: ");
            //    int num2 = int.Parse(Console.ReadLine()!);
            //    Console.WriteLine($"나눗셈 출력: {num1 / num2}");

            //}
            //catch ( DivideByZeroException e)
            //{
            //    Console.WriteLine($"예외 발생: {e.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("프로그램 종료");
            //}
            //Console.WriteLine("완전종료");

            #endregion

            #region 예외처리 종류
            //try
            //{
            //    int? a = null; // Nullable<int> 타입으로 선언
            //    int b = a ?? throw new ArgumentNullException(); // throw 예외 던짐 
            //}
            //catch (ArgumentNullException e)
            //{
            //    Console.WriteLine($"예외발생: {e.Message}");
            //}

            //try
            //{
            //    int[] array = new int[3] { 1, 2, 3 };
            //    int index = 4;
            //    int value = array[index >= 0 && index <3? index : throw new IndexOutOfRangeException()];
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine($"예외 발생: {e.Message}");
            //}
            #endregion

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("제수를 입력바람");
            //        String temp = Console.ReadLine()!;
            //        int dividend = int.Parse(temp);  // 제수 입력
            //        Console.WriteLine("피제수를 입력 바람");
            //        temp = Console.ReadLine()!;
            //        int divisor = Convert.ToInt32(temp); // 피제수 입력

            //        Console.WriteLine($"{dividend}/{divisor} {Divide(dividend, divisor)}");
            //        break;
            //    }
            //    catch (FormatException e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //    catch (DivideByZeroException e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //}

            
        }
    }
}
