//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _06_09_CSharp
//{
//    class MyList : IEnumerable, IEnumerator
//    {
//        private int[] arr;
//        int position = -1; // 배열 위치를 나타내는 변수 
//        public MyList()
//        {
//            arr = new int[3];
//        }
//        public int this[int index]
//        {
//            get
//            {
//                return arr[index];
//            }
//            set
//            {
//                if (index >= arr.Length)
//                {
//                    Array.Resize(ref arr, index + 1); // 배열 크기 조정
//                    Console.WriteLine($"Array Resized: {arr.Length}");
//                }
//                arr[index] = value; // 인덱스에 해당하는 값 설정
//            }
//        }
//        public int Length
//        {
//            get { return arr.Length; }
//        }

//        public object Current
//        {
//            get
//            {
//                return arr[position];
//            }
//        }

//        public IEnumerator GetEnumerator()
//        {
//            return this; // GetEnumerator 메서드는 현재 객체를 반환
//        }

//        public bool MoveNext()
//        {
//            if (position == arr.Length - 1)
//            {
//                Reset(); // 마지막 요소에 도달하면 Reset 호출
//                return false; // 더이상 요소가 없으면 false 반환
//            }
//            position++;
//            return position < arr.Length;
//            //현재 위치가 배열의 길이보다 작으면 true 반환
//        }

//        public void Reset()
//        {
//            position = -1; // 위치를 초기화 하여 처음으로 돌아감
//        }
//    }
//    internal class MainApp3
//    {
//        static void Main(string[] args)
//        {
//            MyList myList = new MyList();
//            for (int i = 0; i < 5; i++)
//            {
//                myList[i] = i + 1; // 인덱서를 사용하여 값 설정
//            }
//            foreach (var list in myList)
//            {
//                Console.WriteLine(list);
//            }
//        }
//    }
//}
