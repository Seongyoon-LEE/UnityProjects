//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _06_12_CSharp
//{

//    internal class MainApp2
//    {


//        delegate int MyCalculator(int a, int b); //대리자 
//        internal class Program
//        {
//            static int Asend<T>(T a, T b) where T : IComparable<T> //형식제약
//            {
//                return a.CompareTo(b); //IComparable<T> 인터페이스를 구현한 형식에 대해 사용
//            }
//            static int Desend<T>(T a, T b) where T : IComparable<T> //형식제약
//            {
//                return a.CompareTo(b) * -1; //IComparable<T> 인터페이스를 구현한 형식에 대해 사용
//                                            // -1을 곱하는 이유는 내림차순으로 정렬하기 위해서
//                                            //-1을 곱하면 자신보다 큰 경우 1 같으면 0 작은경우 -1을 반환하게 된다.
//            }
//            static void BubbleSort<T>(T[] DataSet, Func<T, T, int> compare)
//            {
//                int i = 0;
//                int j = 0;
//                T temp;
//                for (i = 0; i < DataSet.Length - 1; i++)
//                {
//                    for (j = 0; j < DataSet.Length - i - 1; j++)
//                    {
//                        if (compare(DataSet[j], DataSet[j + 1]) > 0)
//                        {

//                            temp = DataSet[j];
//                            DataSet[j] = DataSet[j + 1];
//                            DataSet[j + 1] = temp;
//                        }
//                    }
//                }
//            }
//            static void Main(string[] args)
//            {
//                int[] intArray = { 3, 2, 5, 4, 1 };
//                Console.WriteLine("Original integer array: " + string.Join(",",intArray));

//                // 2. 오름차순 정렬: Asend 메소드 대신 람다식을 직접 전달합니다.
//                // (a, b) => a.CompareTo(b)는 Asend 메서드와 동일한 기능을 수행합니다.
//                BubbleSort<int>(intArray,(a, b) => a.CompareTo(b));
//                Console.WriteLine("Asscending sorted: " + string.Join(",",intArray));

//                // 3. 내림차순 정렬: Desend 메소드 대신 람다식을 직접 전달합니다.
//                // (a, b) => b.CompareTo(a)는 Desend 메서드와 동일한 기능을 수행합니다.
//                BubbleSort<int>(intArray, (a, b) => b.CompareTo(a));
//                Console.WriteLine("Descending sorted: " + string.Join(",",intArray));

//                Console.WriteLine();

//                string[] stringArray = { "Banana", "Apple", "Cherry", "Orange" };
//                Console.WriteLine("Original string array: " + string.Join(",",stringArray));

//                // 문자열 배열에도 동일하게 람다식을 적용할 수 있습니다.
//                BubbleSort(stringArray,(a, b) => a.CompareTo(b));
//                Console.WriteLine("Asscending sorted:" + string.Join(",",stringArray));


//                BubbleSort(stringArray, (a, b) => b.CompareTo(a));
//                Console.WriteLine("Descending sorted:" + string.Join(",", stringArray));
//            }
//        }
//    }
//}

