//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _06_05_CSharp
//{
//    internal class MainApp
//    {
//        static void Main(string[] args)
//        {
//            int[,,] arr = new int[2, 3, 4]
//            {
//                {
//                    { 1, 2, 3, 4},
//                    { 5, 6, 7, 8},
//                    { 9, 10, 11, 12 }
//                },
//                {
//                    { 13, 14, 15, 16 },
//                    { 17, 18, 19, 20 },
//                    { 21, 22, 23, 34}
//                }
//            };
//            for(int i =0; i< arr.GetLength(0); i++)
//            {
//                for(int j = 0;  j< arr.GetLength(1); j++)
//                {
//                    for(int k =0; k <arr.GetLength(2); k++)
//                    {
//                        Console.WriteLine($"{i} {j} {k} : {arr[i,j,k]}    ");
//                    }
//                    Console.WriteLine();
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
