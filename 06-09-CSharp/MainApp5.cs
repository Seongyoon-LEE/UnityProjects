//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _06_09_CSharp
//{
//    class MyList<T> : IEnumerator<T>, IEnumerable<T>
//    {
//        private T[] arr;
//        int position = -1; // 배열 위치를 나나태는 변수

//        public MyList()
//        {
//            arr = new T[3];
//        }
//        public T this[int index]
//        {
//            get
//            {
//                return arr[index];
//            }
//            set
//            {
//                if (index >= arr.Length)
//                {
//                    Array.Resize<T>(ref arr, index + 1); // 배열 크기 조정
//                    Console.WriteLine($"Array Resized: {arr.Length}");
//                }
//                arr[index] = value; // 인덱스에 해당하는 값 설정
//            }
//        }
//        public int Length
//        {
//            get { return arr.Length; }
//        }

//        public T Current
//        {
//            get { return arr[position]; }
//        }

//        object IEnumerator.Current
//        {
//            get { return arr[position]; } // IEnumerator의 Current 속성 구현
//        }

//        public void Dispose()
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerator<T> GetEnumerator()
//        {
//            return this;
//        }

//        public bool MoveNext()
//        {
//            if(position == arr.Length -1)
//            {
//                Reset(); // 마지막 요소에 도달하면 Reset호출
//                return false; // 더이상 요소가 없으면 false 반환
//            }
//            position++;
//            return (position < arr.Length); // 현재 위치가 배열 길이보다 작은지 확인
//        }

//        public void Reset()
//        {
//            position = -1; // 위치를 초기화하여 반복을 다시 시작할수 있도록 설정
//        }

//        IEnumerator IEnumerable.GetEnumerator()
//        {
//            return this; // GetEnumerator 
//        }
//    }


//        internal class MainApp5
//        {
//            static void Main(string[] args)
//            {
//                MyList<string> str_list = new MyList<string>();
//                str_list[0] = "abc";
//                str_list[1] = "def";
//                str_list[2] = "ghi";
//                str_list[3] = "jki";
//                str_list[4] = "mno";
//                for(int i = 0; i <str_list.Length; i++)
//                {
//                    Console.WriteLine(str_list[i]) ; // 인덱서를 사용하여 값 출력
//                }
//                Console.WriteLine();
//                foreach(var item in str_list)
//            {
//                Console.WriteLine(item);
//            }

//                MyList<int> int_list = new MyList<int>();
//                int_list[0] = 1;
//                int_list[1] = 2;
//                int_list[2] = 3;
//                int_list[3] = 4;
//                int_list[4] = 5;
//                for(int i = 0;i <int_list.Length;i++)
//                {
//                    Console.WriteLine(int_list[i]);
//                }
//                Console.WriteLine();
//            }
//        }
//    }
