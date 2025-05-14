using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _04_18_CSharp
{
    internal class Class1
    {
       
        static void Main(string[] args)
        {
            #region int형 float double 변수 선언및 초기화 
            // svn tab + tab
            //int a = 10; // 선언과 동시에 초기화
            //int b = 20; // 선언과 동시에 초기화
            //int c = 30;      // 선언만 
            //Console.WriteLine($"{a} {b} {c}");
            //float f1 = 3.14f;   // float 실수형식 자료형 4byte
            //float f2 = 3.1415f; // float 실수형식 자료형 4byte
            //double d1 = 3.1412345678912345678d; // double 실수형식 자료형 8byte
            //Console.WriteLine($"{f1} {f2} {d1}");
            #endregion

            #region 콘솔 입력 받아서 콘솔에서 출력하기
            //console.write("정수 두개를 입력 바람  \n");
            //console.write("첫번째 입력 : ");
            //int n1 = int.parse(console.readline()!);
            //console.writeline();
            //console.write("두번째 입력 : ");
            //int n2 = int.parse(console.readline()!);
            //int sum = n1 * n2;
            //console.writeline("합계:" + sum);
            //console.writeline($"합계:{sum}"); // 이걸 많이씀 
            #endregion

            #region 문자열로 입력 받아서 출력 해보기
            string? name = null;
            Console.Write("이름을 입력:");
            name = Console.ReadLine();
            Console.Write("주소를 입력:");
            string? Adress = Console.ReadLine();
            //Console.Write("주민번호를 뒷번 1자리 입력:");
            Console.Write("전화번호 입력:");

            //int phoneNum = int.Parse( Console.ReadLine()!);
            string? phoneNum = Console.ReadLine();
            Console.WriteLine($"출력:이름 :{name} \n주소:{Adress} \n전화번호:{phoneNum}");


            #endregion

            #region 문제
            //string? name = null;

            //string? name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine()!);
            //string? adress = Console.ReadLine();
            //Console.WriteLine($"제 이름은 {name} 입니다.\n제 나이는 {age}이고요.\n제가 사는곳의 번지수는 {adress}입니다.");
            #endregion

            #region 문제2
            //Console.WriteLine("첫번째 문제 : ");
            //int num1 = int.Parse(Console.ReadLine()!);
            //int num2 = int.Parse(Console.ReadLine()!);
            //int mul = num1 * num2;

            //int n1 = int.Parse(Console.ReadLine()!);
            //int n2 = int.Parse(Console.ReadLine()!);
            //int mul1 = n1 * n2;
            //Console.WriteLine($"4*5 = {mul}\n7*9 = {mul1}");
            #endregion

            #region 문제3

            //Console.WriteLine("정수 한개 입력 바람 : ");
            //Console.WriteLine("첫번째 입력 : ");
            //int n1 = int.Parse(Console.ReadLine()!);
            //Console.WriteLine();
            //Console.WriteLine("두번째 입력 : ");
            //int n2 = int.Parse(Console.ReadLine()!);
            //int ma = n1 - n2;

            //Console.WriteLine("정수 한개 입력 바람 : ");
            //Console.WriteLine("첫번째 입력 : ");
            //int n3 = int.Parse(Console.ReadLine()!);
            //Console.WriteLine();
            //Console.WriteLine("두번째 입력 : ");
            //int n4 = int.Parse(Console.ReadLine()!);
            //int mul = n1 * n2;
            //Console.WriteLine($"뺄셈 : {ma} 곱셈 : {mul}");

            #endregion

            #region 문제4
            //Console.WriteLine("num1 입력:");
            //int n1 = int.Parse(Console.ReadLine()!);
            //Console.WriteLine("num2 입력:");
            //int n2 = int.Parse(Console.ReadLine()!);
            //Console.WriteLine("num3 입력:");
            //int n3 = int.Parse(Console.ReadLine()!);
            //int mul = n1 * n2 + n3;
            //Console.WriteLine($"{n1}*{n2}+{n3}={mul}");
            #endregion

            #region 문제5
            //Console.WriteLine("하나의 정수를 입력 바람 : ");
            //int n1 = int.Parse(Console.ReadLine());
            //int mul = n1 * n1;
            //Console.WriteLine($"{mul}");
            #endregion

            #region 문제6
            //Console.WriteLine("하나의 정수를 입력 바람 : ");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("하나의 정수를 입력 바람 : ");
            //int n2 = int.Parse(Console.ReadLine());
            //int sum = n1 / n2;
            //int sum1 = n1 % n2;
            //Console.WriteLine($"{sum},{sum1}");
            #endregion

            #region 문제7
            //Console.WriteLine("첫번째 정수를 입력 바람 : ");
            //int n1 = int.Parse(Console.ReadLine()!);
            //Console.WriteLine("두번째 정수를 입력 바람 : ");
            //int n2 = int.Parse(Console.ReadLine()!);
            //Console.WriteLine("세번째 정수를 입력 바람 : ");
            //int n3 = int.Parse(Console.ReadLine()!);
            //int sum = (n1 - n2) * (n2 + n3) * (n3 % n1);
            //Console.WriteLine($"(num1 - num2) * (num2 + num3) * (num3 % num1) = {sum}");

            #endregion
        }




    }
}
