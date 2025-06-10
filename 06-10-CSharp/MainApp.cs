//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _06_10_CSharp
//{
//    class MyList<T> : IEnumerable<T>, IEnumerator<T>
//    {
//        private T[] _array;
//        int position = -1;
//        public  MyList()
//        {
//            _array = new T[5];
//        }
//        //인덱스 프로퍼티
//        public T this[int index]
//        {
//            get { return _array[index]; }
//            set {
//                if (index >= _array.Length)
//                    Array.Resize(ref _array, index + 1);
//                _array[index] = value;
//            }
//        }
//        public int Length
//        {
//            get { return _array.Length-1; }
//        }

//        public T Current => _array[position];

//        object IEnumerator.Current => _array[position]!;

//        public void Dispose()
//        {
//            //throw new NotImplementedException();
//        }

//        public IEnumerator<T> GetEnumerator()
//        {
//            return this;
//        }

//        public bool MoveNext()
//        {
//            if(position == _array.Length-1)
//            {
//                Reset();
//                return false;
//            }
//            position++;
//            return position < _array.Length;
//        }

//        public void Reset()
//        {
//            position = -1;
//        }

//        IEnumerator IEnumerable.GetEnumerator()
//        {
//            return GetEnumerator();
//        }
//    }
//    internal class MainApp
//    {
//        static void Main(string[] args)
//        {
//            MyList<string> s_list = new MyList<string>();
//            s_list[0] = "Hello";
//            s_list[1] = "World";
//            s_list[2] = "C#";

//            for (int i = 0; i < s_list.Length; i++)
//            {
//                Console.WriteLine($"{s_list[i]}");
//            }

//            foreach(string s in s_list)
//            {
//                Console.WriteLine(s);
//            }

//            MyList<int>i_list = new MyList<int>();
//            i_list[0] = 1;
//            i_list[1] = 2;
//            i_list[2] = 3;

//            for(int i = 0; i< i_list.Length;i++)
//            {
//                Console.WriteLine($"{i_list[i]}");
//            }
//            Console.WriteLine();
//            foreach(int i in i_list)
//            {
//                Console.WriteLine(i);
//            }
      
            
//        }
//    }
//}
