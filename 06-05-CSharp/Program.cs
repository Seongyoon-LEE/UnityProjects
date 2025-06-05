//namespace _06_05_CSharp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[,] arr = new int[2, 3]
//            {
//                {1,2,3 },
//                {4,5,6 }
//            };
//            for(int i =0; i < arr.GetLength(0); i++)
//            {
//                for(int j=0; j < arr.GetLength(1); j++)
//                {
//                    Console.WriteLine($"{i} {j}: {arr[i,j]}  ");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//            int[,] GuguDan = new int[8, 9];
//            for(int i =0; i< GuguDan.GetLength(0); i++)
//            {
//                for(int j =0;j<GuguDan.GetLength (1); j++)
//                {
//                    GuguDan[i, j] = (i + 2) * (j + 1);
//                    Console.WriteLine($"{GuguDan[i,j],3}");
//                }
//                Console.WriteLine();
//            }
//            int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 } };
//            for(int i = 0; i <arr3.GetLength(0); i++)
//            {
//                for(int j = 0; j < arr3.GetLength(1); j++)
//                {
//                    Console.WriteLine($"{arr3[i,j]}");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
