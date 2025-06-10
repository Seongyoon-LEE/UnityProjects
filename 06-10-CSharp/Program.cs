//using System.Collections;


//namespace _06_10_CSharp
//{
//    internal class Program
//    {
       

//        static void Main(string[] args)
//        {
//            #region 가변길이 배열
//            //// 가변길이 배열 : 가변길이란 말은 들쭉 날쭉한 길이를 가진다는 뜻
//            //int[][] jaggedArr = new int[3][]; // 3개의 배열을 담을 수 있는 배열 생성 

//            //jaggedArr[0] = new int[5] { 1, 2, 3, 4, 5 }; // 0번째 행의 배열은 5개의 열(길이)
//            //jaggedArr[1] = new int[] { 60, 70, 80 }; // 1번째 행의 배열은 3개의 열(길이)
//            //jaggedArr[2] = new int[] { 100, 200, 300, 400 }; // 2번째 배열은 길이가 4인 배열
//            //foreach(int[] i in jaggedArr)
//            //{
//            //    Console.WriteLine($"Lenght:{i.Length}");
//            //        foreach(int num in i)
//            //    {
//            //        Console.WriteLine($"{num}   ");
//            //    }
//            //    Console.WriteLine();
//            //}

//            //int[][] jagged2 = new int[2][]
//            //{
//            //    new int[]{100,200,300},
//            //    new int[]{6,7,8,9 }
//            //};
//            //foreach (int[] i in jagged2)
//            //{
//            //    Console.WriteLine($"Lenght:{i.Length}");
//            //    foreach(int num in i)
//            //    {
//            //        Console.WriteLine($"{num}   ");
//            //    }
//            //    Console.WriteLine();
//            //}
//            #endregion

//            #region list 사용
//            //List<int> list = new List<int>();
//            //for(int i =0; i< 5; i++)
//            //{
//            //    list.Add(i);
//            //}
//            //foreach(int i in list)
//            //    Console.WriteLine(i);
//            //Console.WriteLine();
//            //list.Insert(2, 100); // 2번째 위치에 100을 삽입
//            //foreach (int i in list)
//            //    Console.WriteLine(i);
//            //Console.WriteLine();
//            //list.RemoveAt(3); // 3번째 위치의 요소를 삭제
//            // foreach(int i in list)
//            //    Console.WriteLine(i);
//            //Console.WriteLine();
//            #endregion

//            #region stack, queue, dictionary
//            //Queue<int> queue = new Queue<int>();
//            //queue.Enqueue(1);
//            //queue.Enqueue(2);
//            //queue.Enqueue(3);
//            //queue.Enqueue(4);
//            //queue.Enqueue(5);
//            //while (queue.Count > 0)
//            //{
//            //    Console.WriteLine($"Dequeue: {queue.Dequeue()}");
//            //}
//            //Console.WriteLine();

//            //Stack<int> stack = new Stack<int>();
//            //stack.Push(1);
//            //stack.Push(2);
//            //stack.Push(3);
//            //stack.Push(4);
//            //stack.Push(5);
//            //while (stack.Count > 0)
//            //{
//            //    Console.WriteLine($"Pop:{stack.Pop()}");
//            //}
//            //Console.WriteLine();
//            //Hashtable ht = new Hashtable();
//            //Dictionary<string, string> dic = new Dictionary<string, string>();
//            //dic["하나"] = "one";
//            //dic["둘"] = "two";
//            //dic["셋"] = "three";
//            //foreach(KeyValuePair<string, string> kvp in dic)
//            //{
//            //    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
//            //}
//            //Console.WriteLine();

//            //Dictionary<string,int> dic2 = new Dictionary<string,int>();
//            //dic2["마녀"] = 100;
//            //dic2["마법사"] = 150;
//            //dic2["범죄의 도시"] = 500;
//            //dic2["광장"] = 300;

//            //foreach(KeyValuePair<string,int> kvp in dic2)
//            //{
//            //    Console.WriteLine($"영화 : {kvp.Key}, {kvp.Value}만");
//            //}
//            //Console.WriteLine();
//            #endregion
//        }
//    }
//}
