//using MBCInfoLogic;
//using System.Data;
//using System.Threading.Tasks.Dataflow;

//namespace _06_11_CSharp
//{
//    //전에 했던 버블 정렬은 일반화 프로그래밍이 되지 않았다.


//    delegate int MyCalculator(int a, int b); //대리자
//    delegate int Compare<T>(T a, T b); //대리자
//    internal class Program
//    {
//        static int Asend<T>(T a, T b) where T : IComparable<T>
//        {
//            return a.CompareTo(b); //IComparable<T> 인터페이스를 구현한 형식에 대해 사용
//        }
//        static int Desend<T>(T a, T b) where T : IComparable<T>
//        {
//            return a.CompareTo(b) * -1;
//            //-1을 곱하는 이유는 내림차순으로 정렬하기 위해서
//            //-1을 곱하면 자신 보다 큰 경우 1 같으면 0 작은 경우 -1을 반환ㅇ하게 된다.
//        }

//        static void BubbleSort<T>(T[] DataSet, Compare<T> compare)
//        {
//            int i = 0;
//            int j = 0;
//            T temp;
//            for (i = 0; i < DataSet.Length - 1; i++)
//            {
//                for (j = 0; j < DataSet.Length - i - 1; j++)
//                {
//                    if (compare(DataSet[j], DataSet[j + 1]) > 0)
//                    {
//                        temp = DataSet[j];
//                        DataSet[j] = DataSet[j + 1];
//                        DataSet[j + 1] = temp;
//                    }
//                }
//            }
//        }


//        static void Main(string[] args)
//        {
//            #region delegate 일반화 (Generic) 델리게이트 (delegate)
//            //Calculator<int> calculator = new Calculator<int>();
//            //MyCalculator callBack = new MyCalculator(calculator.Plus); //대리자에 메서드 할당
//            //Console.WriteLine($"{callBack(7, 5)}");
//            //callBack = new MyCalculator(calculator.Minus); //대리자에 메서드 할당
//            //Console.WriteLine($"{callBack(10, 5)}");

//            //Calculator<double> doubleCalculator = new Calculator<double>();
//            //double doublesum = doubleCalculator.Plus(10.5, 5.2);
//            //double doubleDifference = doubleCalculator.Minus(10.5, 5.2);

//            //Console.WriteLine("실수형(Double) 계산 결과 :");
//            //Console.WriteLine($"10.5+5.2={doublesum}");
//            //Console.WriteLine($"10.5-5.2={doubleDifference}");
//            #endregion

//            int[] array = { 5, 2, 9, 1, 5, 6 };
//            Console.WriteLine("오름차순 정렬");
//            BubbleSort<int>(array, new Compare<int>(Asend));
//            foreach (var item in array)
//            {
//                Console.Write($"{item}");
//            }
//            Console.WriteLine();
//            Console.WriteLine("내림 차순 정렬");
//            BubbleSort<int>(array, new Compare<int>(Desend));
//            foreach (var item in array)
//            {
//                Console.Write($"{item}");
//            }
//            Console.WriteLine();
//            // double 형과 string 등도 정렬이 되게 일반화 프로그래밍으로 바꾸어야 함
//            double[] doubleArray = { 5.5, 2.2, 9.9, 1.1, 5.5, 6.6 };
//            Console.WriteLine("오름차순 정렬");
//            BubbleSort<double>(doubleArray, new Compare<double>(Asend));
//            foreach (var item in doubleArray)
//            {
//                Console.Write($"{item}");
//            }
//            Console.WriteLine();

//            string[] stringArray = { "apple", "orange", "banana", "grape" };
//            Console.WriteLine("내림차순 정렬");
//            BubbleSort<string>(stringArray, new Compare<string>(Desend));
//            foreach (var item in stringArray)
//            {
//                Console.Write($"{item} ");
//            }


//        }
//    }
//}
