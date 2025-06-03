using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace _04_25_CSharp
{
    internal class MainApp
    {
        //public static void NineNine(int num1, int num2)
        //{
        //    for (int dan = num1; dan <= num2; dan++)
        //    {
        //        for (int i = 1; i < 10; i++)
        //        {
        //            Console.WriteLine($"{dan} x {i} = {dan * i}");
        //        }
        //        Console.WriteLine();
        //    }
        //}
        static void Main(string[] args)
        {
            #region for와 foreach 차이
            //int[] arr = new int[5] { 1, 2, 3, 4, 5 }; //1차원 배열
            //int[,] arr2D = new int[4, 4]; //2차원 배열
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] += 2;

            //}
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            ////for (int i = 0; i < arr.Length; i++)
            ////{
            ////    Console.WriteLine($"{arr[i]} \t"); // for문은 배열에 최적화된 반복문이다.
            ////}

            //int[] numbers = new int[100];
            //Random random = new Random();//랜덤 클래스 동적할당
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = random.Next(1, 100);
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"1에서 100사이 랜덤값 {i + 1}번째 출력 : {numbers[i]}");
            //}
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] arr  = { 1,2,3,4,5,6,7,8,9,10};


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 3 == 0) continue;
            //    Console.WriteLine(arr[i]);



            //for(int i=2;i<10;i++)
            //{
            //    if (i % 2 == 0)
            //        continue;
            //    for(int j = 1; j<10;j++)
            //    {
            //        if (i < j) break;
            //        Console.WriteLine($"{i}x{j} = {i*j}");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 문제1
            //int[] arr = new int[100];
            //int sum = 0;
            //for (int i = 0; i <= arr.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine($"총합 : {sum}");
            #endregion

            #region 문제2
            //int num1, num2;
            //Console.WriteLine("두개의 정수 입력 : ");
            //num1 = int.Parse(Console.ReadLine()!);
            //num2 = int.Parse(Console.ReadLine()!);
            //if (num1 < num2)
            //    NineNine(num1, num2);
            //else
            //    NineNine(num2, num1);
            #endregion

            #region 문제3
            //const int BAKE = 500;
            //const int COKE = 400;
            //const int SNACK = 700;
            //Console.WriteLine("현재 당신이 소유하고 있는 금액: ");
            //int money = int.Parse(Console.ReadLine()!);
            //for(int i = 1; i< money/BAKE; i++)
            //{
            //    for(int j = 1;j<money/COKE; j++)
            //    {
            //        for(int k =1; k<money/SNACK; k++)
            //        {
            //            if(money == i*BAKE + j*COKE + k*SNACK)
            //                Console.WriteLine($"크림빵:{i}개 새우깡:{j}개 콜라:{k}개");
            //        }
            //    }
            //}
            #endregion


            //문제4
            //int a = 5;
            //for(int i = 1; i<=a;i++)
            //{
            //    for(int j = 0; j<i;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //문제5
            //int a = 1;
            //for (int i = 5; i >= a; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //문제6
            //int a = 5;
            //int i = 1;

            //while (i <= a)
            //{
            //    int j = 0;
            //    while (j<i)
            //    {
            //        Console.Write("*");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}

            //int a = 5;
            //int i = 0;

            //do
            //{
            //    int j = 0;
            //    do
            //    {

            //        Console.Write("*");
            //        j++;
            //    } while (j <= i);
            //    Console.WriteLine();
            //    i++;
            //} while (i < a);
            //문제7
            //Write("반복 횟수를 입력하세요 :");
            //int input = int.Parse(Console.ReadLine()!);

            //if (input <= 0)
            //{
            //    WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
            //}

            //for (int i = 0; i < input; i++) // 표시될 줄 갯수
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Write("*");
            //    }
            //    WriteLine();
            //}


            //문제8
            const int BAKE = 500;
            const int COKE = 400;
            const int SNACK = 700;

            Console.Write("당신이 가진 돈 입력: ");
            int money = int.Parse(Console.ReadLine()!);

            for (int i = 0; i <= money / BAKE; i++)
            {
                for (int j = 0; j <= money / COKE; j++)
                {
                    for (int k = 0; k <= money / SNACK; k++)
                    {
                        if (money == (i * BAKE) + (j * COKE) + (k * SNACK))
                        {
                            Console.WriteLine($"크림빵:{i}개, 콜라:{j}개, 과자:{k}개");
                        }
                    }
                }
            }
        }
    }
}
