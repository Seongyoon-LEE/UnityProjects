using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//대리자 (delegate)와 이벤트(event)를 항상 같이 사용 
namespace _06_05_CSharp
{
    #region DeleGate 사용법1
    //delegate int MyDelegate(int a, int b); // 반환형이 int이고 매개변수가 int형 2개인 대리자 선언
    //class Calculator
    //{
    //    public static int Plus(int a, int b) // static이 붙어 멤버 메서드가 아닌 전역 메서드
    //    {
    //        return a + b;
    //    }
    //    public static int Minus(int a, int b)
    //    {
    //        return a - b;
    //    }
    //}
    #endregion
    internal class MainApp2
    {
        delegate int Compare(int a, int b);
        static int Ascending(int a, int b) //오름차순
        {
            if (a > b)
                return 1; // a가 b보다 크면 1반환
            else if (a < b)
                return -1; // a가 b보다 작으면 -1 반환
            else
                return 0; // a와 b가 같으면 0 반환
        }
        static int Descending(int a, int b) // 내림차순 
        {
            if (a < b)
                return 1;
            else if (a>b)
                return -1;
            else
                return 0;
        }
            static void BubbleSort(int[] arr,Compare compare)
           {
            int i = 0;
            int j = 0;
            int temp = 0;
            for (i = 0; i < arr.Length - 1; i++)
            {
                // 마지막 i개의 요소는 이미 정렬된 상태이므로, 내부 반복은 n-1-i 까지만 수행
                for (j = 0; j < arr.Length - 1 - i; j++)
                {
                    // 현재 요소가 다음 요소보다 크면 (오름차순)
                    if (compare(arr[j], arr[j + 1]) > 0)
                    {
                        // 두 요소의 위치를 바꿈 (스왑)
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

                // 최적화: 내부 반복문에서 스왑이 한 번도 발생하지 않았다면,
                // 배열이 이미 정렬된 상태이므로 더 이상 진행할 필요가 없음
            }
        }
        static void Main(string[] args)
        {
            #region delegate 사용법2
            //Calculator cal = new Calculator();
            //MyDelegate CallBack;
            //CallBack = new MyDelegate(Calculator.Plus);
            //Console.WriteLine($"{CallBack(3,4)}");

            //CallBack = new MyDelegate(Calculator.Minus);
            //Console.WriteLine($"{CallBack(7,5)}");

            // 대리자는 왜 그리고 언제 사용하는가?
            // 프로그래밍을 하다보면 값이 아닌 코드 덩어리 자체를 전달 할 경우가 있는데 
            // 단순한 값이 아닌 코드 덩어리 자체를 매개변수에 전달 하고 싶을때
            #endregion
            int[] arr = { 5, 3, 8, 6, 2, 44, 2, 7, 88, 66 };
            Console.WriteLine("정렬 전: ");
            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");
            }
            BubbleSort(arr,new Compare(Ascending));
            Console.WriteLine("정렬 후: 오름차순 출력 ");
            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");
            }

            BubbleSort(arr, new Compare(Descending));
            Console.WriteLine("정렬 후: 내림차순 출력 ");
            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
