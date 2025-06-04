using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _06_04_CSharp
{
    internal class Mainapp1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            Random random = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 100); // 1부터 1000 사이의 랜덤한 정수 생성
            }
            //정렬, 이진탐색알고리즘으로 원하는 값을 찾아보자
            
        }
        public static int BSearch(int[] ar, int len, int target)
        {
            int first = 0; // 탐색 대상의 시작 인덱스 값
            int last = len - 1; // 탐색 대상의 마지막 인덱스 값
            int mid;

            while(first <= last)
            {
                mid = first + (last - first) / 2; // 중간 인덱스 계산

                if ((target == ar[mid])) // 중앙에 저장된 것이 타겟이라면
                {
                    return mid; // 찾은 대상의 인덱스 값 반환
                }
                else
                {

                }
            }
        }
    }
}
