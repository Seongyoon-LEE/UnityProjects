using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//명명된 인수  : 이름이 있는 인수 
namespace _04_28_CSharp
{
    internal class MainApp5
    {
        //static void PrintProfile(string name, string phoneNum)
        //{
        //    Console.WriteLine($"Name:{name}, PhoneNum:{phoneNum}");
        //}
        //static void Main(string[] args)
        //{
        //    PrintProfile("홍길동", "010-9727-6432");
        //    PrintProfile(phoneNum : "010-9757-6432",name: "홍길동");
        //    PrintProfile(phoneNum : "010-9738-6732", name: "임꺽쩡");
        //    PrintProfile(name : "우영우", "010-1235-5988");
        //    PrintProfile("이순신", phoneNum: "010-1275-6432");
        //}

        #region 문제1
        //static double Square(double arg)
        //{
        //    return arg * arg;
        //}
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("수를 입력하세요 : ");
        //    string input = Console.ReadLine()!;
        //    double arg = Convert.ToDouble(input);

        //    Console.WriteLine("결과 : {0}", Square(arg));
        //}
        //}
        #endregion

        #region 문제2
        //static void Main(string[] args)
        //{
        //    double mean = 0;

        //    Mean(  1, 2, 3, 4, 5, ref mean);
        //    Console.WriteLine("평균 : {0}",mean);
        //}
        //public static void Mean(
        //     double a, double b, double c,
        //     double d, double e,ref double mean)
        //{
        //    mean = (a + b + c + d + e) / 5;
        //}
        #endregion

        #region 문제3
        //{
        //    int a = 3;
        //    int b = 4;
        //    int resultA = 0;

        //    Plus(a, b, out resultA);

        //    Console.WriteLine("{0} + {1} = {2}", a, b, resultA);

        //    double x = 2.4;
        //    double y = 3.1;
        //    double resultB = 0;

        //    Plus1(x, y, out resultB);

        //    Console.WriteLine("{0} + {1} = {2}", x, y, resultB);
        //}

        //public static void Plus(int a, int b, out int c)
        //{
        //    c = a + b;
        //}
        //public static void Plus1(double x, double y, out double d)
        //{
        //    d = x + y;
        //}
        #endregion
        #region 문제4
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("첫번째 숫자 입력");
        //    int num1 = int.Parse(Console.ReadLine()!);
        //    Console.WriteLine("두번째 숫자 입력");
        //    int num2 = int.Parse(Console.ReadLine()!);
        //    Console.WriteLine("세번째 숫자 입력");
        //    int num3 = int.Parse(Console.ReadLine()!);

        //    int max = Max(num1,num2, num3);
        //    int min = Min(num1,num2,num3);

        //    Console.WriteLine($"가장 큰 수 : {max}");
        //    Console.WriteLine($"가장 작은 수 : {min}");


        //}



        //public static int Max(int a, int b, int c)
        //{
        //    int max = a;
        //    if (b > max)
        //        max = b;
        //    if (c > max)
        //        max = c;
        //    return max;


        //}
        //public static int Min(int a, int b, int c)
        //{
        //    int min = a;
        //    if (b < min)
        //        min = b;
        //    if (c < min)
        //        min = c;
        //    return min;
        //}
        #endregion

        #region 문제5
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("1.섭씨를 화씨로");
        //    double a = Convert.ToDouble(Console.ReadLine()!);

        //    Console.WriteLine(CelToFah(a));

        //    Console.WriteLine("1.화씨를 섭씨로");
        //    double b = Convert.ToDouble(Console.ReadLine()!);

        //    Console.WriteLine(FahToCel(b));

        //}
        //public static double CelToFah(double x)
        //{
        //    return 1.8 * x + 32;
        //}

        //public static double FahToCel(double x)
        //{
        //    return (x - 32) / 1.8;
        //}

        #endregion

        #region 문제6
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("몇번째 피보나치 수를 출력할까요? :");
        //    int count = int.Parse(Console.ReadLine()!);

        //    for(int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine($"피보나치{i} = {Fibonacci(i)}");

        //    }

        //}


        //static int Fibonacci(int n)
        //{
        //    if (n == 0)
        //        return 0;
        //    else if (n == 1)
        //        return 1;
        //    else
        //        return Fibonacci(n - 1) + Fibonacci(n - 2);
        //}
        #endregion

        //    static void Main(string[] args)
        //    {
        //        int sum = 0;
        //        int[] numburs = new int[10];
        //        for (int i = 0; i < numburs.Length; i++)
        //        {
        //            Console.WriteLine("10개의 정수 입력");
        //            numburs[i] = int.Parse(Console.ReadLine());

        //            sum += numburs[i];
        //        }
        //        Console.WriteLine($"입력한 10개의 정수의 합 : {sum}");
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    int[] numburs = new int[100];
        //    for (int i = 0; i < numburs.Length; i++)
        //    {
        //        if(i == 0)
        //            Console.WriteLine("0입니다.");
        //        if (i % 2 == 0)
        //            Console.WriteLine($"짝수만 출력 : {i}");
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    int sum = 0;

        //    int count = 1;
        //    while(true)
        //    {


        //        Console.WriteLine("정수를 입력하시오");
        //        int a = int.Parse(Console.ReadLine()!);


        //        sum += a;



        //        if (a == 0)

        //            break;
        //        count++;

        //    }
        //    if(count > 0)
        //    {
        //        double avg = (double)sum / count;
        //        Console.WriteLine($"입력한 수들의 합계 : {sum} \n 입력한 수들의 평균 : {avg}");
        //    }


        //}

        //static void Main(string[] args)
        //{
        //    int[] numburs = new int[5];
        //    for (int i = 0; i < numburs.Length; i++)
        //    {
        //        Console.WriteLine("5개의 정수를 입력 : ");
        //        numburs[i] = int.Parse(Console.ReadLine()!);

        //    }
        //    int max = numburs[0];
        //    int min = numburs[0];

        //    for(int i = 1; i < numburs.Length; i++)
        //    {
        //        if (numburs[i] > max)
        //            max = numburs[i];
        //        if(numburs[i] < min)
        //            min = numburs[i];
        //    }
        //    Console.WriteLine($"최대값 : {max}");

        //    Console.WriteLine($"최소값 : {min}");
        //}

        #region Abs 큰수 작은수
        //static void Abs(int num1, int num2,out int num3)
        //{

        //    num3 = Math.Abs((num1 > num2) ? num1 : num2);

        //}
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("정수 입력 :");
        //    int num1 = int.Parse(Console.ReadLine());


        //    Console.WriteLine("정수 입력 :");
        //    int num2 = int.Parse(Console.ReadLine());

        //    int result;
        //    Abs(num1, num2, out result);
        //    Console.WriteLine($"더 큰수 : {result}");
        //}
        #endregion
    }

}


