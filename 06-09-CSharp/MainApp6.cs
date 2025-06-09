//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class MyList<T> : IEnumerable, IEnumerator
//{
//    private T[] arr;
//    int position = -1; //배열위치를 나타내는 변수 
//    public MyList()
//    {
//        arr = new T[3];
//    }
//    public T this[int index] // 인덱서(property) 정의 
//    {
//        get
//        {
//            return arr[index];
//        }
//        set
//        {
//            if (index >= arr.Length)
//            {
//                Array.Resize<T>(ref arr, index + 1); // 배열 크기 조정
//                Console.WriteLine($"Array Resized : {arr.Length}");
//            }
//            arr[index] = value; // 인덱스에 해당하는 값 설정

//        }
//    }
//    public int Length
//    {
//        get { return arr.Length; }
//    }

//    public object Current
//    {

//        get { return arr[position]; }

//    }

//    public IEnumerator GetEnumerator()
//    {
//        return this; // GetEnumerator 메서드는 현재 객체를 반환
//    }

//    public bool MoveNext()
//    {
//        if (position == arr.Length - 1)
//        {
//            Reset(); // 마지막 요소에 도달하면 Reset 호출
//            return false; // 더 이상 요소가 없으면 false 반환
//        }
//        position++;
//        return position < arr.Length;
//        // 현재 위치가 배열의 길이보다 작으면 true 반환
//    }

//    public void Reset()
//    {
//        position = -1; // 위치를 초기화하여 처음으로 돌아감
//    }
//}
//internal class MainApp6
//{
//    static void Main(string[] args)
//    {
//        MyList<string> str_List = new MyList<string>();
//        str_List[0] = "하나";
//        str_List[1] = "둘";
//        str_List[2] = "셋";
//        str_List[3] = "넷";
//        for (int i = 0; i < str_List.Length; i++)
//        {
//            Console.WriteLine(str_List[i]);
//        }
//        Console.WriteLine();

//        foreach (var number in str_List)
//        {
//            Console.WriteLine(number);
//        }
//        Console.WriteLine();

//        MyList<float> float_List = new MyList<float>();
//        float_List[0] = 1.1f;
//        float_List[1] = 2.2f;
//        float_List[2] = 3.3f;
//        float_List[3] = 4.4f;
//        for (int i = 0; i < float_List.Length; i++)
//        {
//            Console.WriteLine(float_List[i]);
//        }
//        Console.WriteLine();
//        foreach (var numbur in float_List)
//        {
//            Console.WriteLine(numbur);
//        }
//        Console.WriteLine();
//    }
//}
