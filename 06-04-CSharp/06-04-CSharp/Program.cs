//using System.Collections.Generic;
//using System.Collections;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Numerics;
////1.배열과 컬렉션 그리고 인덱서를 배워보자
////2.배열을 선언하는 방법 세가지
//namespace _06_04_CSharp;
//internal class Program
//{
//    static bool CheckPassed(int score) // 반환형 bool, 매개변수 int score
//    {
//        return score >= 60;
//    }
//    static void PrintScores(int value)
//    {
//        Console.WriteLine($"{value}");
//    }
//    static void Main(string[] args)
//    {
//        #region 1.배열과 컬렉션 그리고 인덱서를 배워보자
//        //List<int> numbers = new List<int>();
//        //Array<int> arry = new Array<int>(5);
//        //데이터 형식 [] 배열이름 = new 데이터 형식[크기];
//        //int[] scores = new int[5]; // 배열 선언
//        //Console.WriteLine($"배열의 크기: {scores.Length}");
//        //Console.WriteLine($"배열의 메모리 사이즈 : {sizeof(int) * scores.Length} ");
//        //scores[0] = 100; // 배열에 값 할당
//        //scores[1] = 90; // 배열에 값 할당
//        //scores[2] = 80; // 배열에 값 할당
//        //scores[3] = 70; // 배열에 값 할당
//        //scores[4] = 60; // 배열에 값 할당

//        //foreach(int score in scores)
//        //{
//        //    Console.WriteLine($"점수: {score}");

//        //int[] scores = new int[5];
//        //int sum = 0;
//        //for (int i = 0; i <scores.Length; i++)
//        //{
//        //    scores[i] = int.Parse(Console.ReadLine()!);
//        //    sum += scores[i]; // 합계 계산
//        //}
//        //foreach (int score in scores)
//        //{
//        //    Console.WriteLine($"점수: {score}");
//        //}
//        //int avg = sum / scores.Length;
//        //Console.WriteLine($"점수 합계: {sum}");
//        //Console.WriteLine($"점수 평균: {avg}");
//        #endregion
//        #region 2.배열을 선언하는 방법 세가지
//        //배열을 선언하는 방법 세가지
//        //string[] array1 = new string[3] { "Apple", "Banana", "Cherry" }; // 용량을 넣음
//        //string[] array2 = new string[] { "Apple", "Banana", "Cherry" }; // 용량 없이 초기화
//        //string[] array3 = { "Apple", "Banana", "Cherry" }; // 배열 선언과 동시에 초기화

//        //foreach (string fruit in array1)
//        //{
//        //    Console.WriteLine(fruit);
//        //}
//        //Console.WriteLine();
//        //foreach (string fruit in array2)
//        //{
//        //    Console.WriteLine(fruit);
//        //}
//        //Console.WriteLine();
//        //foreach (var fruit in array3)
//        //{
//        //    Console.WriteLine(fruit);
//        //}
//        #endregion
//        #region 배열의 타입과 기본 타입
//        //int[] array = new int[5] { 1, 2, 3, 4, 5 };
//        //Console.WriteLine($"Type Of Array: {array.GetType()}");
//        //Console.WriteLine($"Base type Of array: {array.GetType().BaseType}");
//        #endregion

//        int[] scores = new int[5] { 80, 74, 81, 90, 34};
//        foreach (int score in scores)

//            Console.WriteLine($"{score}");
//        Console.WriteLine();
//        Array.Sort(scores); // 배열 정렬
//        foreach (var score in scores)
//            Console.WriteLine($"{score}");
//        Console.WriteLine();         //Action : 반환형이 없는 대리자
//        Console.WriteLine("Array.ForEach<int>로 출력");
//        Array.ForEach<int>(scores, new Action<int>(PrintScores)); // 배열의 각 요소를 출력하는 메서드


//        Console.WriteLine($"Number Of dimensions : {scores.Rank}"); // 배열의 차원 수 -> 1차원
//        int[,] multiArray = new int[2, 3] // 2차원 배열선언
//        {
//            {1,2,3 },
//            {4,5,6 }

//        };
//        Console.WriteLine($"Number Of dimensions : {multiArray.Rank}"); // 배열의 차원 수 -> 2차원
//        int[,,] threeDArray = new int[2, 2, 2] // 3차원 배열 선언
//        {
//            {{1,2 },
//            {3,4 } },

//            {{5,6 },
//            {7,8 } }

//        };
//        Console.WriteLine($"Number Of dimensions : {threeDArray.Rank}"); // 배열의 차원 수 -> 3차원

//        Console.WriteLine($"Binary Search : 81 is at {Array.BinarySearch<int>(scores, 81)}"); // Binary Search : 이진탐색알고리즘 사용해서 배열에서 81을 찾는다.
//        Console.WriteLine($"Linear Search : 81 is at {Array.IndexOf<int>(scores,81)}"); // Linear Search : 선형탐색알고리즘 사용해서 배열에서 81을 찾는다.
//        Console.WriteLine($"Everyone passed? {Array.TrueForAll<int>(scores,CheckPassed)}"); // TrueForAll : 배열과 함께 조건을 검사하는 메서드를 매개변수로 받는다.

//        int index = Array.FindIndex<int>(scores, scores => scores < 60); // 람다식, FindIndex : 배열에서 조건에 맞는 첫 번째 요소의 인덱스를 찾는다.
//        scores[index] = 61;
//        Console.WriteLine($"Everyone passed? {Array.TrueForAll<int>(scores, CheckPassed)}"); // TrueForAll : 배열과 함께 조건을 검사하는 메서드를 매개변수로 받는다.

//        Console.WriteLine($"old Length of scores: {scores.GetLength(0)}"); // 배열에서 지정한 차원의 길이를 반환

//        Array.Resize<int>(ref scores, 10); // 배열의 크기를 변경
//        Console.WriteLine($"New Length of scores: {scores.GetLength(0)}"); // 배열에서 지정한 차원의 길이를 반환

//        Array.ForEach<int>(scores, new Action<int>(PrintScores)); // 배열의 각 요소를 출력하는 메서드
//        Console.WriteLine("\n");
//        Array.Clear(scores, 3, 7);
//        Array.ForEach<int>(scores, new Action<int>(PrintScores)); // 배열의 각 요소를 출력하는 메서드
//        Console.WriteLine("\n");
//        int[] sliced = new int[3];
//        Array.Copy(scores, 0, sliced, 0, 3); // 배열의 일부를 복사
//        Array.ForEach<int>(sliced, new Action<int>(PrintScores)); // 배열의 각 요소를 출력하는 메서드
//        Console.WriteLine("\n");
//    }
//}

