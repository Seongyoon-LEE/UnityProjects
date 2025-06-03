using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0525_CSharp
{
    internal class Calculator
    {
        private int num1; // 클래스에 속한 멤버변수
        private int num2;
        //public Calculator() { // 기본 생성자
        //    num1 = 0;
        //    num2 = 0;
        //}
        //public Calculator(int num1)
        //{
        //    this.num1 = num1;
        //    this.num2 = 0;
        //}

        public Calculator(int num1 = 1 , int num2 = 3) 
        {
           this.num1 = num1;
           this.num2 = num2;
        }

        public int Add(int num1, int num2) // 클래스에 속한 동적 메써드
        {
            return num1 + num2;
        }
        public static int Divide(int num1,int num2) // 정적 메써드
        {
            return num1 + num2;
        }
        public void Result() // 리턴값
        {
            Console.WriteLine($"{num1} : {num2}");
        }
    }
}
