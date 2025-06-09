using System;
using System.Collections; // ArrayList
using System.Collections.Generic; // List

namespace _06_09_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList
            //ArrayList arrayList = new ArrayList();
            //for (int i = 0; i < 5; i++)
            //{
            //    arrayList.Add(i);
            //}
            //foreach (var array in arrayList)
            //{
            //    Console.WriteLine(array);
            //}
            //Console.WriteLine();
            //arrayList.Remove(2);
            //foreach (var array in arrayList)
            //{
            //    Console.WriteLine(array);
            //}
            //Console.WriteLine();
            //ArrayList arrayList1 = new ArrayList();
            //arrayList1.Add(1.1);
            //arrayList1.Add("Hello");
            //arrayList1.Add(true);
            //foreach (var array1 in arrayList1)
            //{
            //    Console.WriteLine(array1);
            //}
            //Console.WriteLine();
            //arrayList1.Insert(1, 2.2);
            //foreach (var array1 in arrayList1)
            //{
            //    Console.WriteLine(array1);
            //}
            #endregion
            #region 스택, 큐
            //List<int> list = new List<int>();
            ////큐 Queue FiFO: First In First Out
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}
            //Console.WriteLine();
            //// 스택 Stack LIFO : Last in First out
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}
            //Console.WriteLine();
            #endregion
            #region HashTable
            //Hash Table
            //키 값 쌍으로 이루어진 데이터 구조

        //    Hashtable ht = new Hashtable();
        //    ht["하나"] = "One";
        //    ht["둘"] = "Two";
        //    ht["셋"] = "Three";
        //    ht["넷"] = "Four";
        //    ht["다섯"] = "Five";
        //    Console.WriteLine(ht["하나"]);
        //    Console.WriteLine(ht["둘"]);
        //    Console.WriteLine(ht["셋"]);
        //    Console.WriteLine(ht["넷"]);
        //    Console.WriteLine(ht["다섯"]);
        //    Console.WriteLine();

        //    Hashtable ht1 = new Hashtable();
        //    ht1["book"] = "책";
        //    ht1["pen"] = "펜";
        //    ht1["apple"] = "사과";
        //    ht1["tweet"] = "지저기다";
        //    foreach (DictionaryEntry entry in ht)
        //    {
        //        Console.WriteLine($"{entry.Key} : {entry.Value}");
        //    }
        //Console.WriteLine();

        //    Hashtable ht2 = new Hashtable();
        //    ht2["회사"] = "Microsoft";
        //    ht2["URL"] = "www.microsoft.com";
        //    //Console.WriteLine("회사 : {0}", ht["회사"]);
        //    //Console.WriteLine("URL : {0}", ht["URL"]);
        //    foreach (DictionaryEntry entry in ht2)
        //    {
        //        Console.WriteLine($"{entry.Key} : {entry.Value}");
        //    }
            #endregion
            #region ArrayList, stack, queue 
            //int[] arr = { 123, 456, 789 };
            //ArrayList list = new ArrayList(arr);
            //foreach (object item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //Stack stack = new Stack(arr);
            //foreach (object item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //Queue queue = new Queue(arr);
            //foreach (object item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //ArrayList list2 = new ArrayList() { 11, 22, 23, 34, 55 };
            //foreach (object item in list2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            #endregion
        }
    }
}
