using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_04_CSharp
{
    internal class BinarySearch
    {
        static int LnearSearch(int[] arr, int len, int target)
        {
            for (int i = 0; i < len; i++)
            {
                if (arr[i] == target)
                {
                    return i; // 찾은 경우 인덱스 반환
                }
            }
            return -1; // 찾지 못한 경우 -1 반환

        }
        public static int BSearch(int[] ar, int len, int target)
        {
            int first = 0; // 탐색 대상의 시작 인덱스 값
            int last = len - 1; // 탐색 대상의 마지막 인덱스 값
            int mid;

            while (first <= last)
            {
                mid = first + (last - first) / 2; // 중간 인덱스 계산

                if (target == ar[mid]) // 중앙에 저장된 것이 타겟이라면
                {
                    return mid; // 찾은 대상의 인덱스 값 반환
                }
                else // 타겟이 아니라면
                {
                    if (target < ar[mid])
                    {
                        last = mid - 1; // 뒷부분을 탐색 대상에서 제외
                    }
                    else
                    {
                        first = mid + 1; // 앞부분을 탐색 대상에서 제외
                    }
                }
            }
            return -1; // 찾지 못한 경우 -1 반환
        }
        public static void BubbleSort(int[] arr) // 버블정렬 알고리즘(문제를 해결하는 방법(처리)) 구현
        {
            int n = arr.Length;

            for(int i= 0; i < n; i++)
            {
                // 마지막 i개의 요소는 이미 정렬된 상태이므로, 내부 반복은 n-1-i 까지만 수행
                for(int j=0;j < n - 1 - i; j++)
                {
                    // 인접한 두 요소를 비교하여 정렬
                    if (arr[j] > arr[j + 1])
                    {
                        // 스왑
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //이진탐색 알고리즘은 일단 정렬이 되어야 한다.
            int[] arr = { 160, 8, 11, 15, 20, 22, 66, 88, 123, 159 };
            int idx;
            BubbleSort(arr); // 배열을 정렬합니다.

            idx = BSearch(arr, arr.Length, 123);
            if (idx == -1)
            {
                Console.WriteLine("탐색 실패");
            }
            else
            {
                Console.WriteLine($"타겟 저장 인덱스:{idx}");
            }
            idx = BSearch(arr, arr.Length, 11);
            if (idx == -1)
            {
                Console.WriteLine("탐색 실패");
            }
            else
            {
                Console.WriteLine($"타겟 저장 인덱스:{idx}");
            }
        }
    }
}
