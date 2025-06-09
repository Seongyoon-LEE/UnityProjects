//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _06_09_CSharp
//{
//    //인덱서 indexer
//    class MyList
//    {
//        private int[] arr;
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
//    }
//    class YourList // 일반화 프로그래밍
//    {
//        private float[] arrF;
//        public YourList()
//        {
//            arrF = new float[3];
//        }
//        public float this[int index]
//        {
//            get
//            {
//                return arrF[index];
//            }
//            set
//            {
//                if (index >= arrF.Length)
//                {
//                    Array.Resize(ref arrF, index + 1); // 배열 크기 조정
//                    Console.WriteLine($"Array Resized: {arrF.Length}");
//                }
//                arrF[index] = value; // 인덱스에 해당하는 값 설정
//            }
//        }
//        public int Length
//        {
//            get { return arrF.Length; }
//        }
//    }

//    internal class MainApp2
//    {
//        static void Main(string[] args)
//        {
//            MyList myList = new MyList();
//            for (int i = 0; i < 5; i++)
//            {
//                myList[i] = i;
//            }
//            for(int i = 0; i < myList.Length; i++)
//            {
//                Console.WriteLine(myList[i]); // 인덱서를 사용하여 값을 출력 
//            }

//            YourList yourList = new YourList();
//            for(int i = 0; i<5; i++)
//            {
//                yourList[i] = i;
//            }
//            for (int i = 0; i < yourList.Length; i++)
//            {
//                Console.WriteLine(yourList[i]);
//            }
//        }
//    }
//}
