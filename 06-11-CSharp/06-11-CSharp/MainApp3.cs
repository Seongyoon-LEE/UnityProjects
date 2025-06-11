//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//// 익명의 메소드
//namespace _06_11_CSharp
//{
//    //delegate int Compare<T>(int a, int b); //대리자
//    internal class MainApp3
//    {
//        static void BubbleSort<T>(T[] DataSet, Func<T,T,int>Compare) where T : IComparable<T> // 형식 제약 
//        {
//            int i = 0;
//            int j = 0;
//            T temp;
//            for (i = 0; i < DataSet.Length - 1; i++)
//            {
//                for (j = 0; j < DataSet.Length - i - 1; j++)
//                {
//                    if (Compare(DataSet[j], DataSet[j + 1]) > 0)
//                    {
//                        temp = DataSet[j];
//                        DataSet[j] = DataSet[j + 1];
//                        DataSet[j + 1] = temp;
//                    }
//                }
//            }
//        }
//        static void PrintArray<T>(T[] array)
//        {
//            foreach (var item in array)
//            {
//                Console.Write($"{item} ");
//            }
//            Console.WriteLine();
//        }
//        static void Main(string[] args)
//        {
//            // int 배열 정렬
//            int[] array = new int[] { 5, 2, 9, 1, 5, 6 };
//            Console.WriteLine("Sorting ascending...");
//            BubbleSort(array, (a, b) => a.CompareTo(b)); //익명 메소드
            
//            PrintArray(array);

//            Console.WriteLine("Sorting Descending...");
//            BubbleSort(array, (a, b) => b.CompareTo(a)); //익명 메소드
            
//            PrintArray(array);

//            Console.WriteLine();

//            // 문자열 배열 정렬
//            string[] strArray = new string[] { "apple", "orange", "banana", "grape" };
//            Console.WriteLine("Sorting ascending....");
//            BubbleSort(strArray, (a, b) => a.CompareTo(b)); //익명 메소드
//            PrintArray(strArray);

//            Console.WriteLine("Sorting Descending...");
//            BubbleSort(strArray, (a, b) => b.CompareTo(a)); //익명 메소드
//            PrintArray(strArray);
//        }
//    }
//}
